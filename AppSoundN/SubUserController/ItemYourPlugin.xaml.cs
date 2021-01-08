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
    /// Interaction logic for ItemYourPlugin.xaml
    /// </summary>
    public partial class ItemYourPlugin : UserControl
    {
        private SanPham product;



        

        public string Tensp
        {
            get { return (string )GetValue(TenspProperty); }
            set { SetValue(TenspProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Tensp.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TenspProperty =
            DependencyProperty.Register("Tensp", typeof(string ), typeof(ItemYourPlugin));




        public string Tenhang
        {
            get { return (string)GetValue(TenhangProperty); }
            set { SetValue(TenhangProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Tenhang.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TenhangProperty =
            DependencyProperty.Register("Tenhang", typeof(string), typeof(ItemYourPlugin));



        public BitmapImage Image
        {
            get { return (BitmapImage)GetValue(ImageProperty); }
            set { SetValue(ImageProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Image.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ImageProperty =
            DependencyProperty.Register("Image", typeof(BitmapImage), typeof(ItemYourPlugin));



        public string Date
        {
            get { return (string)GetValue(DateProperty); }
            set { SetValue(DateProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Date.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty DateProperty =
            DependencyProperty.Register("Date", typeof(string), typeof(ItemYourPlugin));



        public string Linkdown
        {
            get { return (string)GetValue(LinkdownProperty); }
            set { SetValue(LinkdownProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Linkdown.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty LinkdownProperty =
            DependencyProperty.Register("Linkdown", typeof(string), typeof(ItemYourPlugin));




        public ItemYourPlugin(SanPham product)
        {
            InitializeComponent();
            this.product = product;
            Tenhang = product.Tenhang;
            Tensp = product.Tensp;
            Image = product.Image;
            Date = product.Date;
            
            
        }
        public ItemYourPlugin()
        {
            InitializeComponent();
            
        }

        private void btnDownload_Click(object sender, RoutedEventArgs e)
        {
            WebBrowser webBrowser = new WebBrowser();
            Button button = sender as Button;
            SanPham product = button.DataContext as SanPham;
            webBrowser.Navigate(Product.GetLinkDown(product.Id));

        }
    }
}
