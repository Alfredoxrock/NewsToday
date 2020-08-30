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
    public partial class Article_Preview : Window
    {
        public Article_Preview()
        {
            InitializeComponent();
            Label_Category.Content = SomeArticlePreview.currentArticlePreview.category;
            Textblock_Headline.Text = SomeArticlePreview.currentArticlePreview.title;
            Textbox_Byline.Text = SomeArticlePreview.currentArticlePreview.byline;
            Textbox_AuthorAndTime.Text = "BY " + SomeArticlePreview.currentArticlePreview.author.ToUpper() + "\n" +
            SomeArticlePreview.currentArticlePreview.dateTime + "" +
            "\n";

            System.Windows.Media.ImageSource imageSource = new ImageSourceConverter().ConvertFromString(SomeArticlePreview.currentArticlePreview.coverImage) as ImageSource;
            Image_ArticleCover.Source = imageSource;
            

            RichTextBox_ArticleDisplay.Selection.Load(new FileStream(SomeArticlePreview.currentArticlePreview.body, FileMode.Open), DataFormats.Rtf);
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

            var id = SomeArticlePreview.currentArticlePreview.articleID.ToString();
            SomeArticlePreview.currentArticlePreview = Login.validateArticlePreviewGet(id);

            this.Hide();
            User_ArticleInterface sistema = new User_ArticleInterface();
            sistema.ShowDialog();
            this.Close();
        }
    }
}
