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
    /// Interaction logic for InfoHangSx.xaml
    /// </summary>
    public partial class InfoHangSx : UserControl
    {
        private HangSx hangSx;
        public string Tenhang
        {
            get { return (string)GetValue(TenhangProperty); }
            set { SetValue(TenhangProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Tenhang.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TenhangProperty =
            DependencyProperty.Register("Tenhang", typeof(string), typeof(InfoHangSx));


        public string Thongtinhang
        {
            get { return (string)GetValue(ThongtinhangProperty); }
            set { SetValue(ThongtinhangProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Thongtinhang.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ThongtinhangProperty =
            DependencyProperty.Register("Thongtinhang", typeof(string), typeof(InfoHangSx));




        public BitmapImage ImageHang
        {   
            get { return (BitmapImage)GetValue(ImageHangProperty); }
            set { SetValue(ImageHangProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ImageHang.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ImageHangProperty =
            DependencyProperty.Register("ImageHang", typeof(BitmapImage), typeof(InfoHangSx));




        public InfoHangSx()
        {
            InitializeComponent();
            
        }
    }
}
