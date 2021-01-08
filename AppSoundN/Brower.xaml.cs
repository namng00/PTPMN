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
    /// Interaction logic for Brower.xaml
    /// </summary>
    public partial class Brower : UserControl
    {
        private List<SanPham> listInstruments1 = new List<SanPham>();
        private List<SanPham> listEffect1 = new List<SanPham>();
        private List<SanPham> listDaw1 = new List<SanPham>();
        private List<SanPham> listFree1 = new List<SanPham>();
        private List<SanPham> listSale1 = new List<SanPham>();
        private List<SanPham> listAll = new List<SanPham>();
        private User user;
        public Brower(User user)
        {
            InitializeComponent();
            GetInstrument();
            GetDaw();
            Free();
            GetInstrument();
            GetEffect();
            ForSale();
        }
        
        private void GetInstrument()
        {   
            string i ="Instruments";
            listInstruments1 = DatabaseApp.Product.GetDataTableSanPhamTheLoai(i);
            listInstrument.ItemsSource = listInstruments1;
        }
        private void GetDaw()
        {
           
            string i = "DAW";
            listDaw1 = DatabaseApp.Product.GetDataTableSanPhamTheLoai(i);
            listDAW.ItemsSource = listDaw1;
            

        }
        private void ForSale()
        {
            listSale1 = DatabaseApp.Product.GetDataTableSanPhamSale();
            listSale.ItemsSource = listSale1;


        }
        private void Free()
        {
            listFree1 = DatabaseApp.Product.GetDataTableSanPhamFree();
            listFree.ItemsSource = listFree1;


        }
        private void GetEffect()
        {
            string i = "Effects";
            listEffect1 = DatabaseApp.Product.GetDataTableSanPhamTheLoai(i);
            listEffect.ItemsSource = listEffect1;
        }

        private void btnViewAll1_Click(object sender, RoutedEventArgs e)
        {
            layoutBrower.Children.Clear();
            layoutBrower.VerticalAlignment = VerticalAlignment.Center;
            layoutBrower.HorizontalAlignment = HorizontalAlignment.Center;
            ItemBig itemBig = new ItemBig("AllPlugin",user);
            layoutBrower.Children.Add(itemBig);
        }
    }
}