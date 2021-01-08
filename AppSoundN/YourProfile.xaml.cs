using AppSoundN.Class;
using AppSoundN.DatabaseApp;
using Microsoft.Win32;
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
    /// Interaction logic for YourProfile.xaml
    /// </summary>
    public partial class YourProfile : Window
    {

        private Profile profile;



        public string Email
        {
            get { return (string )GetValue(EmailProperty); }
            set { SetValue(EmailProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Email.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty EmailProperty =
            DependencyProperty.Register("Email", typeof(string ), typeof(YourProfile));



        public string Ten
        {
            get { return (string)GetValue(TenProperty); }
            set { SetValue(TenProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Ten.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TenProperty =
            DependencyProperty.Register("Ten", typeof(string), typeof(YourProfile));



        public string DiaChi
        {
            get { return (string)GetValue(DiaChiProperty); }
            set { SetValue(DiaChiProperty, value); }
        }

        // Using a DependencyProperty as the backing store for DiaChi.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty DiaChiProperty =
            DependencyProperty.Register("DiaChi", typeof(string), typeof(YourProfile));



        public byte GioiTinh
        {
            get { return (byte)GetValue(GioiTinhProperty); }
            set { SetValue(GioiTinhProperty, value); }
        }

        // Using a DependencyProperty as the backing store for GioiTinh.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty GioiTinhProperty =
            DependencyProperty.Register("GioiTinh", typeof(byte), typeof(YourProfile));



        public string NgaySinh
        {
            get { return (string)GetValue(NgaySinhProperty); }
            set { SetValue(NgaySinhProperty, value); }
        }

        // Using a DependencyProperty as the backing store for NgaySinh.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty NgaySinhProperty =
            DependencyProperty.Register("NgaySinh", typeof(string), typeof(YourProfile));



        public string CauHoiBiMat
        {
            get { return (string)GetValue(CauHoiBiMatProperty); }
            set { SetValue(CauHoiBiMatProperty, value); }
        }

        // Using a DependencyProperty as the backing store for CauHoiBiMat.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CauHoiBiMatProperty =
            DependencyProperty.Register("CauHoiBiMat", typeof(string), typeof(YourProfile));



        public BitmapImage Avater
        {
            get { return (BitmapImage)GetValue(AvaterProperty); }
            set { SetValue(AvaterProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Avater.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty AvaterProperty =
            DependencyProperty.Register("Avater", typeof(BitmapImage), typeof(YourProfile));




        public YourProfile(string email)
        {
            InitializeComponent();
            profile = DatabaseApp.Account.GetTableProfile(email);
            MessageBox.Show(profile.Email);
            InitProfile();
            UpdateAvatar();

        }

        private void InitProfile()
        {
            Email = profile.Email;
            Avater = profile.Avatar;
            CauHoiBiMat = profile.CauHoiBiMat;
            GioiTinh = profile.GioiTinh;
            NgaySinh = profile.NgaySinh;
            DiaChi = profile.DiaChi;
            Ten = profile.Ten;

        }

        private void Button_MouseMove(object sender, MouseEventArgs e)
        {
            btnAvatar.Opacity = 0.5;
        }

        private void Button_MouseLeave(object sender, MouseEventArgs e)
        {
            btnAvatar.Opacity = 0;
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            if (Account.UpdateProfile(txtEmail.Text.Trim(), txtName.Text.Trim(), txtAddress.Text.Trim(), txtDate.Text.Trim()))
            {
                MessageBox.Show("Update");
            }
            else
            {
                MessageBox.Show("Update that bai");
            }
        }
       
        private void UpdateAvatar()
        {
            btnAvatar.Click += delegate (object sender, RoutedEventArgs e)
              {
                  OpenFileDialog dialog = new OpenFileDialog();
                  dialog.Filter = "JPG Files(.jpg,.png)|*.jpg;*.png;*.jpeg|*.gif|All";
                  dialog.Multiselect = false;
                  dialog.Title = "Select Avatar For You";
                  dialog.ValidateNames = true;
                  if (dialog.ShowDialog() == true)
                  {
                      string fileAvatar = dialog.FileName;
                      Avater = new BitmapImage(new Uri(fileAvatar, UriKind.RelativeOrAbsolute));
                  }
              };
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
