using AppSoundN.Class;
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
    /// Interaction logic for ItemSp.xaml
    /// </summary>
    public partial class ItemSp : UserControl
    {
        public ItemSp()
        {
            InitializeComponent();
        }

        private void btnProduct_Click(object sender, RoutedEventArgs e)
        {
            Button bt = sender as Button;
            SanPham product = bt.DataContext as SanPham;
            MainWindown2 mainWindown2 = (MainWindown2)Window.GetWindow(this);
            mainWindown2.HomeLayout.Children.Clear();
            mainWindown2.HomeLayout.Children.Add(new InfoSanPham(product,mainWindown2.User));
        }

        private void btnHangsx_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
