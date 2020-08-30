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
using System.IO;

namespace NewsToday
{
    /// <summary>
    /// Interaction logic for Article_Preview.xaml
    /// </summary>
    public partial class Article_Display : Window
    {
        public Article_Display()
        {
            InitializeComponent();
            Button_Return.Background = SomeBorderColor.currentColor;
            Headline_BackgroundColor.Background = SomeBorderColor.currentColor;
            Label_Category.Content = SomeArticle.currentArticle.category;
            Textblock_Headline.Text = SomeArticle.currentArticle.title;
            Textbox_Byline.Text = SomeArticle.currentArticle.byline;
            Textbox_AuthorAndTime.Text = "BY " + SomeArticle.currentArticle.author.ToUpper() + " " + "\n" +
            SomeArticle.currentArticle.dateTime + "" +
            "\n";

            System.Windows.Media.ImageSource imageSource = new ImageSourceConverter().ConvertFromString(SomeArticle.currentArticle.coverImage) as ImageSource;
            Image_ArticleCover.Source = imageSource;
            

            RichTextBox_ArticleDisplay.Selection.Load(new FileStream(SomeArticle.currentArticle.body, FileMode.Open), DataFormats.Rtf);
            this.RichTextBox_ArticleDisplay.IsReadOnly = true;

            //TextRange range;
            //FileStream fStream;
            //if (File.Exists(SomeArticlePreview.currentArticlePreview.body))
            //{
            //    range = new TextRange(RichTextBox_ArticleDisplay.Document.ContentStart, RichTextBox_ArticleDisplay.Document.ContentEnd);
            //    fStream = new FileStream(SomeArticlePreview.currentArticlePreview.body, FileMode.OpenOrCreate);
            //    range.Load(fStream, DataFormats.Rtf);
            //    fStream.Close();
            //}

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(Someone.currentUser == null)
            {
                this.Hide();
                MainWindow sistema = new MainWindow();
                sistema.ShowDialog();
                this.Close();
            }
            else
            {
                this.Hide();
                MainWindow_User sistema = new MainWindow_User();
                sistema.ShowDialog();
                this.Close();
            }
            
        }
    }
}
