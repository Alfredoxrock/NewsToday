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

namespace NewsToday
{
    /// <summary>
    /// Interaction logic for MainWindow_User.xaml
    /// </summary>
    public partial class MainWindow_User : Window
    {
        
        public MainWindow_User()
        {
            System.Windows.Threading.DispatcherTimer dispatcherTimer = new System.Windows.Threading.DispatcherTimer(); dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);
            //dispatcherTimer.Interval = new TimeSpan(0, 0, 1); This code is for a countdown.
            dispatcherTimer.Start();
            Helper.loadUsers();
            Helper.loadArticles();
            //Data.articles.Reverse();
            Helper.loadArticlePreview();
            InitializeComponent();
            Label_Username.Content = Someone.currentUser.nickname;

        }

        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            // code goes here
            Label_Time.Content = DateTime.Now.ToLongTimeString();
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

        private void Button_Post_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            User_ArticleInterface sistema = new User_ArticleInterface();
            sistema.ShowDialog();
            this.Close();
        }

        private void Button_News_Click(object sender, RoutedEventArgs e)
        {
            SomeCategory.currentCategory = "News";
            SomeBorderColor.currentColor = Brushes.Red;
            this.Hide();
            MainWindow_Category_User sistema = new MainWindow_Category_User();
            sistema.ShowDialog();
            this.Close();
        }

        private void Button_Politis_Click(object sender, RoutedEventArgs e)
        {
            SomeCategory.currentCategory = "Politics";
            SomeBorderColor.currentColor = Brushes.Blue;

            this.Hide();
            MainWindow_Category_User sistema = new MainWindow_Category_User();
            sistema.ShowDialog();
            this.Close();
        }

        private void Button_Opinion_Click(object sender, RoutedEventArgs e)
        {
            SomeCategory.currentCategory = "Opinion";
            SomeBorderColor.currentColor = Brushes.DarkGreen;

            this.Hide();
            MainWindow_Category_User sistema = new MainWindow_Category_User();
            sistema.ShowDialog();
            this.Close();
        }

        private void Button_Sports_Click(object sender, RoutedEventArgs e)
        {
            SomeCategory.currentCategory = "Sports";
            SomeBorderColor.currentColor = Brushes.Purple;

            this.Hide();
            MainWindow_Category_User sistema = new MainWindow_Category_User();
            sistema.ShowDialog();
            this.Close();
        }

        private void Button_Entertainment_Click(object sender, RoutedEventArgs e)
        {
            SomeCategory.currentCategory = "Entertainment";
            SomeBorderColor.currentColor = Brushes.DarkOrange;

            this.Hide();
            MainWindow_Category_User sistema = new MainWindow_Category_User();
            sistema.ShowDialog();
            this.Close();
        }

        private void Button_Social_Click(object sender, RoutedEventArgs e)
        {
            SomeCategory.currentCategory = "Social";
            SomeBorderColor.currentColor = Brushes.DeepPink;

            this.Hide();
            MainWindow_Category_User sistema = new MainWindow_Category_User();
            sistema.ShowDialog();
            this.Close();
        }

        private void Button_Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainWindow sistema = new MainWindow();
            sistema.ShowDialog();
            this.Close();
        }
    }
}
