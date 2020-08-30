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
    /// Interaction logic for MainWindow_Category.xaml
    /// </summary>
    public partial class MainWindow_Category : Window
    {
        
        public MainWindow_Category()
        {
           
            Helper.loadUsers();
            Helper.loadArticles();
            //Data.articles.Reverse();
            Helper.loadArticlePreview();
            InitializeComponent();
            Border_Background.Background = SomeBorderColor.currentColor;
            Label_Category.Content = SomeCategory.currentCategory;

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
                
            }

            this.Hide();
            Article_Display sistema = new Article_Display();
            sistema.ShowDialog();
            this.Close();



        }

        private void Button_News_Click(object sender, RoutedEventArgs e)
        {
            Label_Category.Content = "News";
            SomeCategory.currentCategory = Label_Category.Content.ToString();
            SomeBorderColor.currentColor = Brushes.Red;

            this.Hide();
            MainWindow_Category sistema = new MainWindow_Category();
            sistema.ShowDialog();
            this.Close();
        }

        private void Button_Home_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainWindow sistema = new MainWindow();
            sistema.ShowDialog();
            this.Close();

        }

        private void Button_Politis_Click(object sender, RoutedEventArgs e)
        {
            Label_Category.Content = "Politics";
            SomeCategory.currentCategory = "Politics";
            SomeBorderColor.currentColor = Brushes.Blue;

            this.Hide();
            MainWindow_Category sistema = new MainWindow_Category();
            sistema.ShowDialog();
            this.Close();
        }

        private void Button_Opinion_Click(object sender, RoutedEventArgs e)
        {
            Label_Category.Content = "Opinion";
            SomeCategory.currentCategory = "Opinion";
            SomeBorderColor.currentColor = Brushes.DarkGreen;
            this.Hide();
            MainWindow_Category sistema = new MainWindow_Category();
            sistema.ShowDialog();
            this.Close();
        }

        private void Button_Sports_Click(object sender, RoutedEventArgs e)
        {
            Label_Category.Content = "Sports";
            SomeCategory.currentCategory = "Sports";
            SomeBorderColor.currentColor = Brushes.Purple;

            this.Hide();
            MainWindow_Category sistema = new MainWindow_Category();
            sistema.ShowDialog();
            this.Close();
        }

        private void Button_Entertainment_Click(object sender, RoutedEventArgs e)
        {
            Label_Category.Content = "Entertainment";
            SomeCategory.currentCategory = "Entertainment";
            SomeBorderColor.currentColor = Brushes.DarkOrange;

            this.Hide();
            MainWindow_Category sistema = new MainWindow_Category();
            sistema.ShowDialog();
            this.Close();
        }

        private void Button_Social_Click(object sender, RoutedEventArgs e)
        {
            Label_Category.Content = "Social";
            SomeCategory.currentCategory = "Social";
            SomeBorderColor.currentColor = Brushes.DeepPink;

            this.Hide();
            MainWindow_Category sistema = new MainWindow_Category();
            sistema.ShowDialog();
            this.Close();
        }
    }
}
