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
    /// Interaction logic for Register.xaml
    /// </summary>
    public partial class Register : Window
    {
        public Register()
        {
            InitializeComponent();
        }

        private void Textbox_Email_MouseEnter(object sender, MouseEventArgs e)
        {
            if (Textbox_Email.Text == "EMAIL")
            {
                Textbox_Email.Text = "";
                Textbox_Email.Foreground = Brushes.Silver;

            }
        }

        private void Textbox_Email_MouseLeave(object sender, MouseEventArgs e)
        {
            if (Textbox_Email.Text == "")
            {
                Textbox_Email.Text = "EMAIL";
                Textbox_Email.Foreground = Brushes.Silver;
            }
        }

        private void Border_MouseEnter(object sender, MouseEventArgs e)
        {
            if (Textbox_Username.Text == "USERNAME")
            {
                Textbox_Username.Text = "";
                Textbox_Username.Foreground = Brushes.Silver;

            }
        }

        private void Border_MouseLeave(object sender, MouseEventArgs e)
        {
            if (Textbox_Username.Text == "")
            {
                Textbox_Username.Text = "USERNAME";
                Textbox_Username.Foreground = Brushes.Silver;
            }
        }

        private void Border_MouseEnter_1(object sender, MouseEventArgs e)
        {
            if (Textbox_State.Text == "STATE")
            {
                Textbox_State.Text = "";
                Textbox_State.Foreground = Brushes.Silver;

            }
        }

        private void Border_MouseLeave_1(object sender, MouseEventArgs e)
        {
            if (Textbox_State.Text == "")
            {
                Textbox_State.Text = "STATE";
                Textbox_State.Foreground = Brushes.Silver;
            }
        }

        private void TextBox_MouseEnter(object sender, MouseEventArgs e)
        {
            if (Textbox_City.Text == "CITY")
            {
                Textbox_City.Text = "";
                Textbox_City.Foreground = Brushes.Silver;

            }
        }


        private void TextBox_MouseLeave(object sender, MouseEventArgs e)
        {
            if (Textbox_City.Text == "")
            {
                Textbox_City.Text = "CITY";
                Textbox_City.Foreground = Brushes.Silver;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Window1 sistema = new Window1();
            sistema.ShowDialog();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {


            if (Textbox_Email.Text == "" || Textbox_Email.Text == "EMAIL" || Textbox_Username.Text == "" || Textbox_Username.Text == "USERNAME" ||
                Passwordbox_First.ToString() == "" || Passwordbox_confirm.ToString() == "" || Combobox_country.Text == "" ||
                Textbox_State.Text == "" || Textbox_State.Text == "STATE" || Textbox_City.Text == "" ||
                Textbox_City.Text == "CITY" || Combobox_Day.Text == "" || Combobox_Month.Text == "" || Textbox_Year.Text =="")
            {
                Label_Incorrect.Content = "-Please, fill in the blanks";
            }
            else
            {
                if(Textbox_Email.Text.Contains("@") & Textbox_Email.Text.Contains("."))
                {

                    if(Passwordbox_First.Password.Length < 8 || Passwordbox_First.Password.Length > 15)
                    {
                        Label_Incorrect.Content = "-Your password is either short or too large!";
                    }
                    else
                    {
                        if(Textbox_Year.Text.Length < 4)
                        {
                            Label_Incorrect.Content = "-The year of your birthday is incorrect!";
                        }
                        else
                        {
                            if(Passwordbox_First.Password != Passwordbox_confirm.Password)
                            {
                                Label_Incorrect.Content = "-Password doesn't match!";
                            }
                            else
                            {
                                bool validNickname = Login.validateJustUser(Textbox_Username.Text);
                                bool validEmail = Login.validateEmail(Textbox_Email.Text);
                                if(validNickname)
                                {
                                    Label_Incorrect.Content = "This username is already in use!";
                                   
                                }
                                else
                                {
                                    if (validEmail)
                                    {
                                        Label_Incorrect.Content = "This email is already in use!";
                                    }
                                    else
                                    {
                                        Birth birthie = new Birth(Combobox_Day.Text, Combobox_Month.Text, Textbox_Year.Text);
                                        Location loc = new Location(Combobox_country.Text, Textbox_State.Text, Textbox_City.Text);
                                        Email email = new Email(Textbox_Email.Text);
                                        User user = new User(Data.getNextID(), Textbox_Username.Text, Passwordbox_First.ToString(), birthie, loc, email);
                                        Data.addUser(user);

                                        this.Hide();
                                        Window1 sistema = new Window1();
                                        sistema.ShowDialog();
                                        this.Close();
                                    }
                                }



                            }
                         
                        }
                        
                         
                    }

                }
                else
                {
                    Label_Incorrect.Content = "-Your email is incomplete!";
                }
                
            }
           
        }
    }
    
}
