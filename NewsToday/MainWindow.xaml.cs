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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections.ObjectModel;
using NewsToday.Database;

namespace NewsToday
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            Helper.loadUsers();
            Helper.loadArticles();
            //Data.articles.Reverse();
            Helper.loadArticlePreview();
            InitializeComponent();
            DatabaseHelper.EstablishConnection();

            hideBar();

        }

        private void hideBar()
        {
            Bar1.Visibility = Visibility.Hidden;
        }

        private void Bar1_MouseLeave(object sender, MouseEventArgs e)
        {
            hideBar();
        }



        private void Button_News_MouseEnter_1(object sender, MouseEventArgs e)
        {
            Button_News.Background = Brushes.Transparent;
            Button_News.Foreground = Brushes.Red;
            Bar1.Visibility = Visibility.Visible;
        }

        private void Button_News_MouseLeave_1(object sender, MouseEventArgs e)
        {
            Button_News.Background = Brushes.Transparent;
            Button_News.Foreground = Brushes.Black;
            if (Bar1.IsMouseOver || Button_News.IsMouseOver)
            {
                Bar1.Visibility = Visibility.Visible;

            }
            else
            {
                hideBar();
            }
        }

        private void Button_Local_MouseEnter(object sender, MouseEventArgs e)
        {
            Button_Local.Background = Brushes.Red;
            Button_Local.Foreground = Brushes.White;
        }

        private void Button_Local_MouseLeave(object sender, MouseEventArgs e)
        {
            BrushConverter reddish = new BrushConverter();
            Button_Local.Background = Brushes.Black;
            Button_Local.Foreground = Brushes.White;
        }

        private void Button_State_MouseEnter(object sender, MouseEventArgs e)
        {
            Button_State.Background = Brushes.Red;
            Button_State.Foreground = Brushes.White;
        }

        private void Button_State_MouseLeave(object sender, MouseEventArgs e)
        {
            BrushConverter reddish = new BrushConverter();
            //Button_State.Background = (Brush)reddish.ConvertFrom("#FF671B1B");
            Button_State.Background = Brushes.Black;
            Button_State.Foreground = Brushes.White;
        }

        private void Button_National_MouseEnter(object sender, MouseEventArgs e)
        {
            Button_National.Background = Brushes.Red;
            Button_National.Foreground = Brushes.White;
        }

        private void Button_National_MouseLeave(object sender, MouseEventArgs e)
        {
            BrushConverter reddish = new BrushConverter();
            Button_National.Background = Brushes.Black;
            Button_National.Foreground = Brushes.White;
        }

        private void Button_World_MouseEnter(object sender, MouseEventArgs e)
        {
            Button_World.Background = Brushes.Red;
            Button_World.Foreground = Brushes.White;
        }

        private void Button_World_MouseLeave(object sender, MouseEventArgs e)
        {
            BrushConverter reddish = new BrushConverter();
            Button_World.Background = (Brush)reddish.ConvertFrom("#FF671B1B");
            Button_World.Foreground = Brushes.White;
        }

        private void Button_SignIn_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Window1 sistema = new Window1();
            sistema.ShowDialog();
            this.Close();
        }

        private void Button_Home_MouseEnter(object sender, MouseEventArgs e)
        {
            Button_Home.Foreground = Brushes.Red;
        }

        private void Button_Home_MouseLeave(object sender, MouseEventArgs e)
        {
            Button_Home.Foreground = Brushes.Black;
        }

        private void Button_Politis_MouseEnter(object sender, MouseEventArgs e)
        {
            Button_Politis.Foreground = Brushes.Red;
        }

        private void Button_Politis_MouseLeave(object sender, MouseEventArgs e)
        {
            Button_Politis.Foreground = Brushes.Black;
        }

        private void Button_Opinion_MouseEnter(object sender, MouseEventArgs e)
        {
            Button_Opinion.Foreground = Brushes.Red;
        }

        private void Button_Opinion_MouseLeave(object sender, MouseEventArgs e)
        {
            Button_Opinion.Foreground = Brushes.Black;
        }

        private void Button_Sports_MouseEnter(object sender, MouseEventArgs e)
        {
            Button_Sports.Foreground = Brushes.Red;
        }

        private void Button_Sports_MouseLeave(object sender, MouseEventArgs e)
        {
            Button_Sports.Foreground = Brushes.Black;
        }

        private void Button_Entertainment_MouseEnter(object sender, MouseEventArgs e)
        {
            Button_Entertainment.Foreground = Brushes.Red;
        }

        private void Button_Entertainment_MouseLeave(object sender, MouseEventArgs e)
        {
            Button_Entertainment.Foreground = Brushes.Black;
        }

        private void Button_Social_MouseEnter(object sender, MouseEventArgs e)
        {
            Button_Social.Foreground = Brushes.Red;
        }

        private void Button_Social_MouseLeave(object sender, MouseEventArgs e)
        {
            Button_Social.Foreground = Brushes.Black;
        }

        private void Button_SignIn_MouseEnter(object sender, MouseEventArgs e)
        {
            Button_SignIn.Foreground = Brushes.Black;
        }

        private void Button_SignIn_MouseLeave(object sender, MouseEventArgs e)
        {
            Button_SignIn.Foreground = Brushes.Red;
        }

        private void listView_Click(object sender, MouseEventArgs e)
        {
            string selectedID;
            Article article = Listbox_articleItems.SelectedItem as Article;
            
            if (article != null)
            {

                selectedID = article.articleID.ToString();
                SomeArticle.currentArticle = Login.validateArticleGet(selectedID);
                SomeBorderColor.currentColor = Data.colorGet(article);

            }

            this.Hide();
            Article_Display sistema = new Article_Display();
            sistema.ShowDialog();
            this.Close();



        }

        
        private void listView_Click2(object sender, MouseEventArgs e)
        {
            string selectedID;
            Article article = Listbox_OneItemFirst.SelectedItem as Article;

            if (article != null)
            {

                selectedID = article.articleID.ToString();
                SomeArticle.currentArticle = Login.validateArticleGet(selectedID);
                SomeBorderColor.currentColor = Data.colorGet(article);

            }

            

            this.Hide();
            Article_Display sistema = new Article_Display();
            sistema.ShowDialog();
            this.Close();
        }

        private void listView_Click3(object sender, MouseEventArgs e)
        {
            string selectedID;
            Article article = Listbox_OneItemSecond.SelectedItem as Article;

            if (article != null)
            {

                selectedID = article.articleID.ToString();
                SomeArticle.currentArticle = Login.validateArticleGet(selectedID);
                SomeBorderColor.currentColor = Data.colorGet(article);

            }

            this.Hide();
            Article_Display sistema = new Article_Display();
            sistema.ShowDialog();
            this.Close();
        }

        private void listView_Click4(object sender, MouseEventArgs e)
        {
            string selectedID;
            Article article = Listbox_OneItemThird.SelectedItem as Article;

            if (article != null)
            {

                selectedID = article.articleID.ToString();
                SomeArticle.currentArticle = Login.validateArticleGet(selectedID);
                SomeBorderColor.currentColor = Data.colorGet(article);

            }

            this.Hide();
            Article_Display sistema = new Article_Display();
            sistema.ShowDialog();
            this.Close();
        }

        private void listView_Click5(object sender, MouseEventArgs e)
        {
            string selectedID;
            Article article = Listbox_OneLiner.SelectedItem as Article;

            if (article != null)
            {

                selectedID = article.articleID.ToString();
                SomeArticle.currentArticle = Login.validateArticleGet(selectedID);
                SomeBorderColor.currentColor = Data.colorGet(article);

            }

            this.Hide();
            Article_Display sistema = new Article_Display();
            sistema.ShowDialog();
            this.Close();
        }

        private void listView_Click6(object sender, MouseEventArgs e)
        {
            string selectedID;
            Article article = Listbox_OneLiner2.SelectedItem as Article;

            if (article != null)
            {

                selectedID = article.articleID.ToString();
                SomeArticle.currentArticle = Login.validateArticleGet(selectedID);
                SomeBorderColor.currentColor = Data.colorGet(article);

            }

            this.Hide();
            Article_Display sistema = new Article_Display();
            sistema.ShowDialog();
            this.Close();
        }

        private void listView_Click7(object sender, MouseEventArgs e)
        {
            string selectedID;
            Article article = Listbox_OneLiner3.SelectedItem as Article;

            if (article != null)
            {

                selectedID = article.articleID.ToString();
                SomeArticle.currentArticle = Login.validateArticleGet(selectedID);
                SomeBorderColor.currentColor = Data.colorGet(article);

            }

            this.Hide();
            Article_Display sistema = new Article_Display();
            sistema.ShowDialog();
            this.Close();
        }

        private void Button_News_Click(object sender, RoutedEventArgs e)
        {
            SomeCategory.currentCategory = "News";
            SomeBorderColor.currentColor = Brushes.Red;
            this.Hide();
            MainWindow_Category sistema = new MainWindow_Category();
            sistema.ShowDialog();
            this.Close();
        }

        private void Button_Politis_Click(object sender, RoutedEventArgs e)
        {
            SomeCategory.currentCategory = "Politics";
            SomeBorderColor.currentColor = Brushes.Blue;

            this.Hide();
            MainWindow_Category sistema = new MainWindow_Category();
            sistema.ShowDialog();
            this.Close();
        }

        private void Button_Opinion_Click(object sender, RoutedEventArgs e)
        {
            SomeCategory.currentCategory = "Opinion";
            SomeBorderColor.currentColor = Brushes.DarkGreen;

            this.Hide();
            MainWindow_Category sistema = new MainWindow_Category();
            sistema.ShowDialog();
            this.Close();
        }

        private void Button_Sports_Click(object sender, RoutedEventArgs e)
        {
            SomeCategory.currentCategory = "Sports";
            SomeBorderColor.currentColor = Brushes.Purple;
           
            this.Hide();
            MainWindow_Category sistema = new MainWindow_Category();
            sistema.ShowDialog();
            this.Close();
        }

        private void Button_Entertainment_Click(object sender, RoutedEventArgs e)
        {
            SomeCategory.currentCategory = "Entertainment";
            SomeBorderColor.currentColor = Brushes.DarkOrange;

            this.Hide();
            MainWindow_Category sistema = new MainWindow_Category();
            sistema.ShowDialog();
            this.Close();
        }

        private void Button_Social_Click(object sender, RoutedEventArgs e)
        {
            SomeCategory.currentCategory = "Social";
            SomeBorderColor.currentColor = Brushes.DeepPink;

            this.Hide();
            MainWindow_Category sistema = new MainWindow_Category();
            sistema.ShowDialog();
            this.Close();
        }
    }
}
