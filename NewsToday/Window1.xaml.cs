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

namespace NewsToday
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void TextBox_MouseEnter(object sender, MouseEventArgs e)
        {
            if (Textbox_Nickname.Text == "USERNAME")
            {
                Textbox_Nickname.Text = "";
                Textbox_Nickname.Foreground = Brushes.Black;

            }
        }

        private void TextBox_MouseLeave(object sender, MouseEventArgs e)
        {
            if (Textbox_Nickname.Text == "")
            {
                Textbox_Nickname.Text = "USERNAME";
                Textbox_Nickname.Foreground = Brushes.Black;
            }
        }

        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {
            Button_SignIn.Foreground = Brushes.Red;
        }

        private void Button_MouseLeave(object sender, MouseEventArgs e)
        {
            Button_SignIn.Foreground = Brushes.Black;
        }

       
        private void Button_Register_MouseEnter_1(object sender, MouseEventArgs e)
        {
            Button_Register.Foreground = Brushes.Red;
        }

        private void Button_Register_MouseLeave(object sender, MouseEventArgs e)
        {
            Button_Register.Foreground = Brushes.White;
        }

        private void Button_MouseEnter_1(object sender, MouseEventArgs e)
        {
            Button_Return.Foreground = Brushes.Black;
        }

        private void Button_MouseLeave_1(object sender, MouseEventArgs e)
        {
            Button_Return.Foreground = Brushes.White;
        }

        private void Button_Return_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainWindow sistema = new MainWindow();
            sistema.ShowDialog();
            this.Close();
        }

        private void Button_Register_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Register sistema = new Register();
            sistema.ShowDialog();
            this.Close();
        }

        private void Button_SignIn_Click(object sender, RoutedEventArgs e)
        {
            Someone.currentUser = Login.validateUserGet(Textbox_Nickname.Text);
            bool validU = Login.validationU(Textbox_Nickname.Text, Passwordbox_Password.ToString());
            if (validU)
            {
                this.Hide();
                MainWindow_User sistema = new MainWindow_User();
                sistema.ShowDialog();
                this.Close();
            }

            if(Textbox_Nickname.Text == "" || Textbox_Nickname.Text == "USERNAME" || Passwordbox_Password.Password.Length < 1)
            {
                
                        Label_Incorrect.Content = "-Please fill in the blanks";
                 
            }
            else
            {
                Label_Incorrect.Content = "-Username or password is incorrect!";
            }

        }
    }
}
