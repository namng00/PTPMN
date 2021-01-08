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
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : UserControl
    {
        public Login()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            
           User user = new User(tbEmail.Text.Trim(), tbPassword.Password.Trim(),false);
           User admin = new User(tbEmail.Text.Trim(), tbPassword.Password.Trim(), true);
           if(Account.CheckAccountDatabase(admin.Email, admin.Password,admin.Permisstion))
           {
               MessageBox.Show("dang nhap thanh cong tk admin");
           }
           else if(Account.CheckAccountDatabase(user.Email, user.Password, user.Permisstion))
           {    
                
                MainWindown2 windows2 = new MainWindown2(user);
                windows2.Show();
                Window.GetWindow(this).Hide();
            
           }
           else
           {
                MessageBox.Show("a");
           }   
            
        }

        
    }
}
