using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Microsoft.Win32;
using System.IO;
using System.Text.RegularExpressions;

namespace NewsToday
{
    /// <summary>
    /// Interaction logic for User_ArticleInterface.xaml
    /// </summary>
    public partial class User_ArticleInterface : Window
    {
        public string coverImageSource;
        public User_ArticleInterface()
        {
            InitializeComponent();

            if(Textbox_Title.Text == "" & SomeArticlePreview.currentArticlePreview == null)
            {

            }
            else
            {
                Textbox_Title.Text = SomeArticlePreview.currentArticlePreview.title;
                Textbox_Byline.Text = SomeArticlePreview.currentArticlePreview.byline;
                coverImageSource = SomeArticlePreview.currentArticlePreview.coverImage;
                Combobox_Category.Text = SomeArticlePreview.currentArticlePreview.category;
                Richtextbox_ArticleBody.Selection.Load(new FileStream(SomeArticlePreview.currentArticlePreview.body, FileMode.Open), DataFormats.Rtf);

            }

            Combobox_Fonts.SelectionChanged += (s, e) =>
            Richtextbox_ArticleBody.Selection.ApplyPropertyValue(TextElement.FontFamilyProperty, e.AddedItems[0]);

           

        }


        private void Button_InsertImage_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                Image myimage = new Image();
                myimage.Source = new BitmapImage(new Uri(openFileDialog.FileName,
                    UriKind.RelativeOrAbsolute));
                myimage.Height = 500;
                myimage.Width = 1072;
                InlineUIContainer myUI = new InlineUIContainer();
                myUI.Child = myimage;

                Paragraph myparagraph = new Paragraph();
                Richtextbox_ArticleBody.Document.Blocks.Add(myparagraph);
                myparagraph.Inlines.Add(myUI);

            }
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Richtextbox_ArticleBody.Selection.ApplyPropertyValue(TextElement.FontStyleProperty, FontStyles.Italic);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Richtextbox_ArticleBody.Selection.ApplyPropertyValue(TextElement.FontWeightProperty, FontWeights.UltraBold);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Richtextbox_ArticleBody.Selection.ApplyPropertyValue(TextElement.FontStyleProperty, FontStyles.Normal);
            Richtextbox_ArticleBody.Selection.ApplyPropertyValue(TextElement.FontWeightProperty, FontWeights.Normal);
        }

        private void Button_Align_Left_Click(object sender, RoutedEventArgs e)
        {
            Richtextbox_ArticleBody.Selection.ApplyPropertyValue(Block.TextAlignmentProperty, TextAlignment.Left);
        }

        private void Button_Align_Center_Click(object sender, RoutedEventArgs e)
        {
            Richtextbox_ArticleBody.Selection.ApplyPropertyValue(Block.TextAlignmentProperty, TextAlignment.Center);

        }

        private void Button_Align_Right_Click(object sender, RoutedEventArgs e)
        {
            Richtextbox_ArticleBody.Selection.ApplyPropertyValue(Block.TextAlignmentProperty, TextAlignment.Right);
        }

        private void Button_Align_Justify_Click(object sender, RoutedEventArgs e)
        {
            Richtextbox_ArticleBody.Selection.ApplyPropertyValue(Block.TextAlignmentProperty, TextAlignment.Justify);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                Image myimage = new Image();
                myimage.Source = new BitmapImage(new Uri(openFileDialog.FileName,
                    UriKind.RelativeOrAbsolute));
                //Label_Test.Content = myimage.Source;
                coverImageSource = myimage.Source.ToString();

            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            TextRange textRange = new TextRange(Richtextbox_ArticleBody.Document.ContentStart,Richtextbox_ArticleBody.Document.ContentEnd);
            FileStream fstream = new FileStream(@"C:\Users\alf_b\Desktop\Spring 2019\Fall 2019\Senior Capstone - Finished\NewsToday\NewsToday\bin\Debug\articles_saved\" + Data.articleGetNextID() + ".Rtf", FileMode.Create);
            textRange.Save(fstream, DataFormats.Rtf);

            Article article = new Article(Data.articleGetNextID() ,Someone.currentUser.nickname, DateTime.Now.ToString("MM/dd/yyyy") + " " + DateTime.Now.ToString("hh:mm tt "), Combobox_Category.Text, Someone.currentUser.location.city, Textbox_Title.Text, Textbox_Byline.Text, @"C: \Users\alf_b\Desktop\Spring 2019\Fall 2019\Senior Capstone - Finished\NewsToday\NewsToday\bin\Debug\articles_saved\" + Data.articleGetNextID() + ".Rtf", coverImageSource);
            Data.addArticle(article);

            this.Hide();
            MainWindow_User sistema = new MainWindow_User();
            sistema.ShowDialog();
            this.Close();
        }

        private void Button_Preview_Click(object sender, RoutedEventArgs e)
        {
            TextRange textRange = new TextRange(Richtextbox_ArticleBody.Document.ContentStart, Richtextbox_ArticleBody.Document.ContentEnd);
            FileStream fstream = new FileStream(@"C:\Users\alf_b\Desktop\Spring 2019\Fall 2019\Senior Capstone - Finished\NewsToday\NewsToday\bin\Debug\articlesPreview_saved\" + Data.articlePreviewGetNextID() + ".Rtf", FileMode.Create);
            textRange.Save(fstream, DataFormats.Rtf);

            Article article = new Article(Data.articlePreviewGetNextID(), Someone.currentUser.nickname, DateTime.Now.ToString("MM/dd/yyyy") + " " + DateTime.Now.ToString("hh:mm tt "), Combobox_Category.Text, Someone.currentUser.location.city, Textbox_Title.Text, Textbox_Byline.Text, @"C:\Users\alf_b\Desktop\Fall 2019\Senior Capstone\NewsToday\NewsToday\bin\Debug\articlesPreview_saved\" + Data.articlePreviewGetNextID() + ".Rtf", coverImageSource);
            Data.addArticlePreview(article);

            //Label_Tester.Content = article.articleID.ToString();

            string selectArticleId = article.articleID.ToString();
            SomeArticlePreview.currentArticlePreview = Login.validateArticlePreviewGet(selectArticleId);
            fstream.Flush();
            fstream.Close();
            

            this.Hide();
            Article_Preview sistema = new Article_Preview();
            sistema.ShowDialog();
            this.Close();
            
            
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainWindow_User sistema = new MainWindow_User();
            sistema.ShowDialog();
            this.Close();
        }
    }
}
