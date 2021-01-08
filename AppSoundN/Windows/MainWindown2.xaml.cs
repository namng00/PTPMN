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
using System.Windows.Shapes;

namespace AppSoundN
{
    /// <summary>
    /// Interaction logic for MainWindown2.xaml
    /// </summary>
    public partial class MainWindown2 : Window
    {
        private User user;
        private Profile profile;
        private List<SanPham> listInstruments;
        public User User { get => user; set => user = value; }

        public MainWindown2(User u1)
        {
            InitializeComponent();
            ShowBrower();
            this.User = u1;
        }
        private void Browse_Click(object sender, RoutedEventArgs e)
        {
            ShowBrower();
            
        }
        private void btnFreePlugin_Click(object sender, RoutedEventArgs e)
        {
            ShowFreePlugin();
            
        }
        private void YourPlugin_Click(object sender, RoutedEventArgs e)
        {
            ShowYourPlugin();
            
        }
        private void btnAllPlugin_Click(object sender, RoutedEventArgs e)
        {
            ShowAllPlugin();
            
        }
        private void btnDaw_Click(object sender, RoutedEventArgs e)
        {
            ShowDAW();
            
        }
        private void btnInstruments_Click(object sender, RoutedEventArgs e)
        {
            ShowInstruments();
            
        }
        private void btnEffects_Click(object sender, RoutedEventArgs e)
        {
            ShowEffects();
            
        }
        private void btnForSale_Click(object sender, RoutedEventArgs e)
        {
            ShowForSale();
            
        }
        private void ShowBrower()
        {
            HomeLayout.Children.Clear();
            HomeLayout.VerticalAlignment = VerticalAlignment.Center;
            HomeLayout.HorizontalAlignment = HorizontalAlignment.Center;
            Brower brower = new Brower(User);
            HomeLayout.Children.Add(brower);
        }
        private void ShowYourPlugin()
        {
            HomeLayout.Children.Clear();
            HomeLayout.VerticalAlignment = VerticalAlignment.Center;
            HomeLayout.HorizontalAlignment = HorizontalAlignment.Center;
            YourPlugin yourPlugin = new YourPlugin(User);
            HomeLayout.Children.Add(yourPlugin);
        }
        private void ShowAllPlugin()
        {
            HomeLayout.Children.Clear();
            HomeLayout.VerticalAlignment = VerticalAlignment.Center;
            HomeLayout.HorizontalAlignment = HorizontalAlignment.Center;
            ItemBig itemBig = new ItemBig("AllPlugin",User);
            HomeLayout.Children.Add(itemBig);
        }
        private void ShowDAW()
        {
            HomeLayout.Children.Clear();
            HomeLayout.VerticalAlignment = VerticalAlignment.Center;
            HomeLayout.HorizontalAlignment = HorizontalAlignment.Center;
            ItemBig itemBig = new ItemBig("DAW",User);
            HomeLayout.Children.Add(itemBig);
        }
        private void ShowInstruments()
        {
            HomeLayout.Children.Clear();
            HomeLayout.VerticalAlignment = VerticalAlignment.Center;
            HomeLayout.HorizontalAlignment = HorizontalAlignment.Center;
            ItemBig itemBig = new ItemBig("Instruments",User);
            HomeLayout.Children.Add(itemBig);
        }
        private void ShowEffects()
        {
            HomeLayout.Children.Clear();
            HomeLayout.VerticalAlignment = VerticalAlignment.Center;
            HomeLayout.HorizontalAlignment = HorizontalAlignment.Center;
            ItemBig itemBig = new ItemBig("Effects",User);
            HomeLayout.Children.Add(itemBig);
        }

        
        private void ShowForSale()
        {
            HomeLayout.Children.Clear();
            HomeLayout.VerticalAlignment = VerticalAlignment.Center;
            HomeLayout.HorizontalAlignment = HorizontalAlignment.Center;
            ItemBig itemBig = new ItemBig("Sale",User);
            HomeLayout.Children.Add(itemBig);
        }

        
        private void ShowFreePlugin ()
        {
            HomeLayout.Children.Clear();
            HomeLayout.VerticalAlignment = VerticalAlignment.Center;
            HomeLayout.HorizontalAlignment = HorizontalAlignment.Center;
            ItemBig itemBig = new ItemBig("Free",User);
            HomeLayout.Children.Add(itemBig);
        }

        private void Browse_MouseMove(object sender, MouseEventArgs e)
        {

            Browse.Foreground = Brushes.Black;
        }

        private void Browse_MouseLeave(object sender, MouseEventArgs e)
        {
            Browse.Foreground = Brushes.Gray;
        }

        private void YourPlugin_MouseLeave(object sender, MouseEventArgs e)
        {
            YourPlugin.Foreground = Brushes.Gray;
        }

        private void YourPlugin_MouseMove(object sender, MouseEventArgs e)
        {
            YourPlugin.Foreground = Brushes.Black;
        }

        private void btnDaw_MouseMove(object sender, MouseEventArgs e)
        {
            btnDaw.Foreground = Brushes.Black;
        }

        private void btnDaw_MouseLeave(object sender, MouseEventArgs e)
        {
            btnDaw.Foreground = Brushes.Gray;
        }

        private void btnInstruments_MouseMove(object sender, MouseEventArgs e)
        {
            btnInstruments.Foreground = Brushes.Black;
        }

        private void btnInstruments_MouseLeave(object sender, MouseEventArgs e)
        {
            btnInstruments.Foreground = Brushes.Gray;
        }

        private void btnEffects_MouseMove(object sender, MouseEventArgs e)
        {
            btnEffects.Foreground = Brushes.Black;
        }

        private void btnEffects_MouseLeave(object sender, MouseEventArgs e)
        {
            btnEffects.Foreground = Brushes.Gray;
        }

        private void btnAllPlugin_MouseMove(object sender, MouseEventArgs e)
        {
            btnAllPlugin.Foreground = Brushes.Black;
        }

        private void btnAllPlugin_MouseLeave(object sender, MouseEventArgs e)
        {
            btnAllPlugin.Foreground = Brushes.Gray;
        }

        private void btnForSale_MouseMove(object sender, MouseEventArgs e)
        {
            btnForSale.Foreground = Brushes.Black;
        }

        private void btnForSale_MouseLeave(object sender, MouseEventArgs e)
        {
            btnForSale.Foreground = Brushes.Gray;
        }

        private void btnFreePlugin_MouseMove(object sender, MouseEventArgs e)
        {
            btnFreePlugin.Foreground = Brushes.Black;
        }

        private void btnFreePlugin_MouseLeave(object sender, MouseEventArgs e)
        {
            btnFreePlugin.Foreground = Brushes.Gray;
        }

        private void btnProfile_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            YourProfile f = new YourProfile(user.Email) ;
            f.Show();

        }

        private void btnSignOut_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainWindow m = new MainWindow();
            m.Show();
        }

        private void tbSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
           
        }

        private void TopManufacturers_MouseLeave(object sender, MouseEventArgs e)
        {
            btnFreePlugin.Foreground = Brushes.Gray;
        }

        private void TopManufacturers_MouseMove(object sender, MouseEventArgs e)
        {
            btnForSale.Foreground = Brushes.Black;
        }
    }
}
