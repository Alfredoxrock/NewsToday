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

namespace NewsToday
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindowUser : Window
    {
        public MainWindowUser()
        {
            System.Windows.Threading.DispatcherTimer dispatcherTimer = new System.Windows.Threading.DispatcherTimer(); dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);
            //dispatcherTimer.Interval = new TimeSpan(0, 0, 1); This code is for a countdown.
            dispatcherTimer.Start();

            InitializeComponent();
            Helper.loadUsers();
            hideBar();
            Label_Username.Content = Someone.currentUser.nickname;
            
            
        }

        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            // code goes here
            Label_Time.Content = DateTime.Now.ToLongTimeString();
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
            Button_Local.Background = (Brush)reddish.ConvertFrom("#FF671B1B");
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
            Button_State.Background = (Brush)reddish.ConvertFrom("#FF671B1B");
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
            Button_National.Background = (Brush)reddish.ConvertFrom("#FF671B1B");
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

        private void Button_Post_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            User_ArticleInterface sistema = new User_ArticleInterface();
            sistema.ShowDialog();
            this.Close();
        }
    }
}
