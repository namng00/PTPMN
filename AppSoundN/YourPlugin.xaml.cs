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
    /// Interaction logic for YourPlugin.xaml
    /// </summary>
    public partial class YourPlugin : UserControl
    {
        List<SanPham> listSp = new List<SanPham>();
        private User user;
        public YourPlugin(User user1)
        {
            this.user = user1;
            InitializeComponent();
            GetDataToListViewYourPlugin();
            string time = DateTime.Now.ToString();
        }
        private void GetDataToListViewYourPlugin()
        {
            listSp.Clear();
            listSp = Product.GetYourPlugin(user.Email);
            listYourPlugin.ItemsSource = listSp;
        }

    }
}
