using AppSoundN.Class;
using AppSoundN.DatabaseApp;
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
    /// Interaction logic for ForgetPassWord.xaml
    /// </summary>
    public partial class ForgetPassWord : UserControl
    {
        public ForgetPassWord()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            Profile profile = new Profile();
            User user = new User();
            if(Account.CheckQueri(tbCauHoiBiMat.Text.Trim(),tbEmailReset.Text.Trim()))
            {
                if(tbNewPassWordReset.Password==tbConfirmPasswordReset.Password)
                {
                    if (Account.UpdatePassWord(tbNewPassWordReset.Password,tbEmailReset.Text.Trim()))
                    {
                        MessageBox.Show("Reset mk thanh cong");
                    }
                }    
                else
                {
                    MessageBox.Show("Nhap lai pass");
                }    
            }   
            else
            {
                MessageBox.Show("av");
            }
        }
    }
}
