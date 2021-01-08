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
    /// Interaction logic for ItemBig.xaml
    /// </summary>
    public partial class ItemBig : UserControl
    {
        private List<SanPham> listInstruments2 = new List<SanPham>();
        private List<SanPham> listEffect2 = new List<SanPham>();
        private List<SanPham> listDaw2 = new List<SanPham>();
        private List<SanPham> listFree2 = new List<SanPham>();
        private List<SanPham> listSale2 = new List<SanPham>();


        public int Count
        {
            get { return (int)GetValue(CountProperty); }
            set { SetValue(CountProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Count.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CountProperty =
            DependencyProperty.Register("Count", typeof(int), typeof(ItemBig));





        public string Theloai
        {
            get { return (string)GetValue(TheloaiProperty); }
            set { SetValue(TheloaiProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Theloai.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TheloaiProperty =
            DependencyProperty.Register("Theloai", typeof(string), typeof(ItemBig));


        private User user;
        public ItemBig(string x,User user)
        {
            InitializeComponent();
            
            if (x == "AllPlugin")
            {
                AllPlugin();
                Count = Product.GetCountAllSp();
            }
            else if (x == "Instruments")
            {
                SetColorButtonInstruments();
                CheckButtonInstruments = true;
                Count = Product.GetCountSp("Instruments");
                CheckButtonInstruments = true;
                CheckButtonDAW = false;
                CheckButtonEffect = false;
                SetColorButtonInstruments();
                if (CheckButtonInstruments == true && !CheckButtonEffect && !CheckButtonDAW && !CheckButtonSale && !CheckButtonFree)
                {
                    GetInstrument();
                }
                if (CheckButtonSale == true)
                {
                    Count = Product.GetCountTheloaiSale("Instruments");
                    listInstruments2 = Product.GetSanPhamTheLoaiSale("Instruments");
                    listCustom.ItemsSource = listInstruments2;
                }
                else if (CheckButtonFree == true)
                {
                    Count = Product.GetCountTheloaiFree("Intruments");
                    listInstruments2 = Product.GetSanPhamTheLoaiFree("Instruments");
                    listCustom.ItemsSource = listInstruments2;
                }


            }
            else if (x == "Effects")
            {
                SetColorButtonEffects();
                CheckButtonDAW = false;
                CheckButtonInstruments = false;
                CheckButtonEffect = true;
                if (CheckButtonEffect == true && !CheckButtonDAW && !CheckButtonInstruments && !CheckButtonSale && !CheckButtonFree)
                {
                    GetEffect();
                }
                if (CheckButtonSale == true)
                {
                    Count = Product.GetCountTheloaiSale("Effects");
                    listInstruments2 = Product.GetSanPhamTheLoaiSale("Effects");
                    listCustom.ItemsSource = listInstruments2;
                }
                else if (CheckButtonFree == true)
                {
                    Count = Product.GetCountTheloaiFree("Effects");
                    listInstruments2 = Product.GetSanPhamTheLoaiFree("Effects");
                    listCustom.ItemsSource = listInstruments2;
                }
            }
            else if (x == "Free")
            {
                SetColorButtonFree();
                CheckButtonFree = true;
                CheckButtonSale = false;
                if (CheckButtonFree == true && !CheckButtonEffect && !CheckButtonInstruments && !CheckButtonSale && !CheckButtonDAW)
                {
                    Free();
                }
                if (CheckButtonInstruments == true)
                {
                    
                    listInstruments2 = Product.GetSanPhamTheLoaiFree("Instruments");
                    listCustom.ItemsSource = listInstruments2;
                    
                    Count = Product.GetCountTheloaiFree("Instruments");
                    
                }
                else if (CheckButtonDAW == true)
                {
                    
                    listInstruments2 = Product.GetSanPhamTheLoaiFree("DAW");
                    listCustom.ItemsSource = listInstruments2;
                    Count = Product.GetCountTheloaiFree("DAW");
                    
                }
                else if (CheckButtonEffect == true)
                {
                    
                    listInstruments2 = Product.GetSanPhamTheLoaiFree("Effects");
                    listCustom.ItemsSource = listInstruments2;
                    Count = Product.GetCountTheloaiFree("Effects");
                    
                }

            }
            else if (x == "Sale")
            {
                CheckButtonSale = true;
                CheckButtonFree = false;
                SetColorButtonSale();
                if (CheckButtonSale == true && !CheckButtonEffect && !CheckButtonInstruments && !CheckButtonDAW && !CheckButtonFree)
                {
                    ForSale();
                }
                if (CheckButtonEffect == true)
                {

                    listInstruments2 = Product.GetSanPhamTheLoaiSale("Effects");
                    listCustom.ItemsSource = listInstruments2;
                    Count = Product.GetCountTheloaiSale("Effects");
                }
                else if (CheckButtonInstruments == true)
                {
                    listInstruments2 = Product.GetSanPhamTheLoaiSale("Instruments");
                    listCustom.ItemsSource = listInstruments2;
                    Count = Product.GetCountTheloaiSale("Instruments");
                }
                else if (CheckButtonDAW == true)
                {
                    listInstruments2 = Product.GetSanPhamTheLoaiSale("DAW");
                    listCustom.ItemsSource = listInstruments2;
                    Count = Product.GetCountTheloaiSale("DAW");
                }
            }
            else if (x == "DAW")
            {
                SetColorButtonDaw();
                SetColorButtonDaw();
                CheckButtonDAW = true;
                CheckButtonEffect = false;
                CheckButtonInstruments = false;
                if (CheckButtonDAW == true && !CheckButtonEffect && !CheckButtonInstruments && !CheckButtonSale && !CheckButtonFree)
                {

                    GetDaw();
                }
                if (CheckButtonSale == true)
                {

                    Count = Product.GetCountTheloaiSale("DAW");
                    listInstruments2 = Product.GetSanPhamTheLoaiSale("DAW");
                    listCustom.ItemsSource = listInstruments2;
                }
                else if (CheckButtonFree == true)
                {
                    Count = Product.GetCountTheloaiFree("DAW");
                    listInstruments2 = Product.GetSanPhamTheLoaiFree("DAW");
                    listCustom.ItemsSource = listInstruments2;
                }
            }
        }

        private void GetDaw()
        {
            
            string i = "DAW";
            listDaw2 = DatabaseApp.Product.GetDataTableSanPhamTheLoai(i);
            listCustom.ItemsSource = listDaw2;
            Count = Product.GetCountSp("DAW");

        }

        private void GetInstrument()
        {
            string i = "Instruments";
            listInstruments2 = DatabaseApp.Product.GetDataTableSanPhamTheLoai(i);
            listCustom.ItemsSource = listInstruments2;
            Count = Product.GetCountSp("Instruments");
        }
        private void ForSale()
        {
            listSale2 = DatabaseApp.Product.GetDataTableSanPhamSale();
            listCustom.ItemsSource = listSale2;
            Count = Product.GetCountSale();


        }
        private void Free()
        {
            listFree2 = DatabaseApp.Product.GetDataTableSanPhamFree();
            listCustom.ItemsSource = listFree2;
            Count = Product.GetCountFree();

        }
        private void AllPlugin()
        {
            listFree2 = DatabaseApp.Product.GetAllSanPham();
            listCustom.ItemsSource = listFree2;


        }
        private void GetEffect()
        {
            string i = "Effects";
            listEffect2 = DatabaseApp.Product.GetDataTableSanPhamTheLoai(i);
            listCustom.ItemsSource = listEffect2;
            Count = Product.GetCountSp("Effects");
        }

        private void btnDaw_Click(object sender, RoutedEventArgs e)
        {

            SetColorButtonDaw();
            CheckButtonDAW = true;
            CheckButtonEffect = false;
            CheckButtonInstruments = false;
            
            if (CheckButtonDAW == true && !CheckButtonEffect && !CheckButtonInstruments && !CheckButtonSale && !CheckButtonFree)
            {

                GetDaw();
            }
            if (CheckButtonSale == true)
            {

                Count = Product.GetCountTheloaiSale("DAW");
                listInstruments2 = Product.GetSanPhamTheLoaiSale("DAW");
                listCustom.ItemsSource = listInstruments2;
            }
            else if (CheckButtonFree == true)
            {
                Count = Product.GetCountTheloaiFree("DAW");
                listInstruments2 = Product.GetSanPhamTheLoaiFree("DAW");
                listCustom.ItemsSource = listInstruments2;
            }
        }

        private void btnInstruments_Click(object sender, RoutedEventArgs e)
        {
            CheckButtonInstruments = true;
            CheckButtonDAW = false;
            CheckButtonEffect = false;
            
            SetColorButtonInstruments();
            if (CheckButtonInstruments == true && !CheckButtonEffect && !CheckButtonDAW && !CheckButtonSale && !CheckButtonFree)
            {
                GetInstrument();
            }
            else if (CheckButtonSale == true)
            {
                Count = Product.GetCountTheloaiSale("Instruments");
                listInstruments2 = Product.GetSanPhamTheLoaiSale("Instruments");
                listCustom.ItemsSource = listInstruments2;
            }
            else if (CheckButtonFree == true)
            {
                Count = Product.GetCountTheloaiFree("Instruments");
                
                listInstruments2 = Product.GetSanPhamTheLoaiFree("Instruments");
                listCustom.ItemsSource = listInstruments2;
            }

        }

        private void btnEffects_Click(object sender, RoutedEventArgs e)
        {
            SetColorButtonEffects();
            CheckButtonDAW = false;
            CheckButtonInstruments = false;
            CheckButtonEffect = true;
            
            if (CheckButtonEffect == true && !CheckButtonDAW && !CheckButtonInstruments && !CheckButtonSale && !CheckButtonFree)
            {
                GetEffect();
            }
            if (CheckButtonSale == true)
            {
                Count = Product.GetCountTheloaiSale("Effects");
                listInstruments2 = Product.GetSanPhamTheLoaiSale("Effects");
                listCustom.ItemsSource = listInstruments2;

            }
            else if (CheckButtonFree == true)
            {
                Count = Product.GetCountTheloaiFree("Effects");
                listInstruments2 = Product.GetSanPhamTheLoaiFree("Effects");
                listCustom.ItemsSource = listInstruments2;
            }
        }

        private void btnFree_Click(object sender, RoutedEventArgs e)
        {
            SetColorButtonFree();
            CheckButtonFree = true;
            CheckButtonSale = false;
            
            if (CheckButtonFree == true && !CheckButtonEffect && !CheckButtonInstruments && !CheckButtonSale && !CheckButtonDAW)
            {
                Free();
            }
            if (CheckButtonInstruments == true)
            {
                listInstruments2 = Product.GetSanPhamTheLoaiFree("Instruments");
                listCustom.ItemsSource = listInstruments2;
                Count = Product.GetCountTheloaiFree("Instruments");
                MessageBox.Show(Product.GetCountTheloaiFree("Instruments").ToString());
            }
            else if (CheckButtonDAW == true)
            {
                Count = Product.GetCountTheloaiFree("DAW");
                listInstruments2 = Product.GetSanPhamTheLoaiFree("DAW");
                listCustom.ItemsSource = listInstruments2;
                MessageBox.Show(Product.GetCountTheloaiFree("DAW").ToString());
            }
            else if (CheckButtonEffect == true)
            {
                Count =  Product.GetCountTheloaiFree("Effects");
                listInstruments2 = Product.GetSanPhamTheLoaiFree("Effects");
                listCustom.ItemsSource = listInstruments2;
                MessageBox.Show(Product.GetCountTheloaiFree("Effects").ToString());
            }
        }

        private void btnSale_Click(object sender, RoutedEventArgs e)
        {
            CheckButtonSale = true;
            CheckButtonFree = false;
            
            SetColorButtonSale();
            if (CheckButtonSale == true && !CheckButtonEffect && !CheckButtonInstruments && !CheckButtonDAW && !CheckButtonFree)
            {
                ForSale();
            }
            if (CheckButtonEffect == true)
            {
                
                listInstruments2 = Product.GetSanPhamTheLoaiSale("Effects");
                listCustom.ItemsSource = listInstruments2;
                Count = Product.GetCountTheloaiSale("Effects");
                
            }
            else if (CheckButtonInstruments == true)
            {
                listInstruments2 = Product.GetSanPhamTheLoaiSale("Instruments");
                listCustom.ItemsSource = listInstruments2;
                Count = Product.GetCountTheloaiSale("Instruments");

            }
            else if (CheckButtonDAW == true)
            {
                listInstruments2 = Product.GetSanPhamTheLoaiSale("DAW");
                listCustom.ItemsSource = listInstruments2;
                Count = Product.GetCountTheloaiSale("DAW");
            }



        }
        private void SetColorButtonDaw()
        {
            btnDaw.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#0033FF"));
            btnDaw.Foreground = Brushes.White;
            btnInstruments.Background = Brushes.White;
            btnInstruments.Foreground = Brushes.Gray;
            btnEffects.Background = Brushes.White;
            btnEffects.Foreground = Brushes.Gray;
        }
        private void SetColorButtonInstruments()
        {
            btnInstruments.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#0033FF"));
            btnInstruments.Foreground = Brushes.White;
            btnDaw.Background = Brushes.White;
            btnDaw.Foreground = Brushes.Gray;
            btnEffects.Background = Brushes.White;
            btnEffects.Foreground = Brushes.Gray;
        }
        private void SetColorButtonEffects()
        {
            btnEffects.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#0033FF"));
            btnEffects.Foreground = Brushes.White;
            btnInstruments.Background = Brushes.White;
            btnInstruments.Foreground = Brushes.Gray;
            btnDaw.Background = Brushes.White;
            btnDaw.Foreground = Brushes.Gray;
        }
        private void SetColorButtonFree()
        {
            btnFree.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#0033FF"));
            btnFree.Foreground = Brushes.White;
            btnSale.Background = Brushes.White;
            btnSale.Foreground = Brushes.Gray;

        }
        private void SetColorButtonSale()
        {
            btnSale.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#0033FF"));
            btnSale.Foreground = Brushes.White;
            btnFree.Background = Brushes.White;
            btnFree.Foreground = Brushes.Gray;
}
        private bool CheckButtonInstruments = false;
        private bool CheckButtonEffect = false;
        private bool CheckButtonDAW = false;
        private bool CheckButtonSale = false;
        private bool CheckButtonFree = false;
    }
}
