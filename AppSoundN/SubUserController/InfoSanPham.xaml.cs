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
    /// Interaction logic for InfoSanPham.xaml
    /// </summary>
    public partial class InfoSanPham : UserControl
    {
        private SanPham product;




        public BitmapImage Imageinfo
        {
            get { return (BitmapImage)GetValue(ImageinfoProperty); }
            set { SetValue(ImageinfoProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Imageinfo.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ImageinfoProperty =
            DependencyProperty.Register("Imageinfo", typeof(BitmapImage), typeof(InfoSanPham));







        public string Tenhang
        {
            get { return (string)GetValue(TenhangProperty); }
            set { SetValue(TenhangProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Tenhang.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TenhangProperty =
            DependencyProperty.Register("Tenhang", typeof(string), typeof(InfoSanPham));



        public string Tensp
        {
            get { return (string)GetValue(TenspProperty); }
            set { SetValue(TenspProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Tensp.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TenspProperty =
            DependencyProperty.Register("Tensp", typeof(string), typeof(InfoSanPham));



        public string Thongtinsp
        {
            get { return (string)GetValue(ThongtinspProperty); }
            set { SetValue(ThongtinspProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Thongtinsp.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ThongtinspProperty =
            DependencyProperty.Register("Thongtinsp", typeof(string), typeof(InfoSanPham));



        private int id;
        private string email;
        private User userBuy;

        public InfoSanPham(SanPham product,User user)
        {
            this.product = product;
            this.userBuy =user;
            InitializeComponent();
            initProduct();
           
            btnBuy.Click += delegate (object sender, RoutedEventArgs e)
            {
                
                if (Product.InsertTableUserBuy(userBuy.Email, product.Id))
                {
                    MessageBox.Show("Mua hang thanh cong");
                }
            };
            if(Product.CheckSpDaMua(userBuy.Email,product.Id)==true)
            {
                btnBuy.Background = Brushes.White;
                btnBuy.Content = "Owner";
                btnBuy.Foreground = Brushes.Black;
                btnBuy.IsEnabled = false;
            }

        }

        private void initProduct()
        {

            Tenhang = product.Tenhang;
            Tensp = product.Tensp;
            Thongtinsp = product.Thongtinsp;
            Imageinfo = product.Imageinfo;
        }


    }
}
