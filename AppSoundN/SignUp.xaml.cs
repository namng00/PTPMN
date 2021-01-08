using AppSoundN.DatabaseApp;
using AppSoundN.Utils;
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

namespace AppSoundN
{
    /// <summary>
    /// Interaction logic for SignUp.xaml
    /// </summary>
    public partial class SignUp : UserControl
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, RoutedEventArgs e)
        {

            if (IsValidAccount(tbEmailSignUp.Text.Trim(), tbPasswordSignUp.Password, tbConfirmPassword.Password, cbAgreed))
            {
                if (tbPasswordSignUp.Password == tbConfirmPassword.Password)
                {
                    if (cbAgreed.IsChecked == true)
                    {
                        if (Account.InsertTableAccout(tbEmailSignUp.Text.Trim(), tbPasswordSignUp.Password) && Account.InsertEmail(tbEmailSignUp.Text.Trim()))
                        {
                            MessageBox.Show("Dang ki thanh cong");
                        }
                        else
                        {
                            MessageBox.Show("Dang ki That bai");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mời bạn chấp nhận điều khoản");
                    }

                }
                else
                {
                    MessageBox.Show("Xác nhận lại mật khẩu");
                }
            }
        }

        private bool IsValidAccount(string email, string password, string confirmpass, CheckBox cb)
        {
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmpass))
            {
                Helpers.MakeErrorMessage(Window.GetWindow(this), "Please fill in the form", "Error");
                return false;
            }
            else
            {
                if (!password.Equals(confirmpass))

                {
                    Helpers.MakeErrorMessage(Window.GetWindow(this), "Password is not matched with the confirmed password", "Error");
                    return false;
                }
                else
                {
                    if (!Helpers.isValidEmail(email))
                    {
                        Helpers.MakeErrorMessage(Window.GetWindow(this), "Email error~", "Error");
                        return false;
                    }
                    else
                    {
                        if (cb.IsChecked == false)
                        {
                            Helpers.MakeErrorMessage(Window.GetWindow(this), "Please agree with the term", "Error");
                            return false;
                        }
                    }
                }
                return true;
            }
        }
    }
}
