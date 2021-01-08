using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace AppSoundN.Class
{
    public class SanPham
    {
        private int _id;
        private string _tensp;
        private string _theloai;
        private string _thongtinsp;
        private double _gia;
        private string _tenhang;
        private BitmapImage _image;
        private BitmapImage _imageinfo;
        private string _linkdown;
        private double _sale;
        private int _count;
        private string date;

        public int Id { get => _id; set => _id = value; }
        public string Tensp { get => _tensp; set => _tensp = value; }
        public string Theloai { get => _theloai; set => _theloai = value; }
        public string Thongtinsp { get => _thongtinsp; set => _thongtinsp = value;}
        public double Gia { get => _gia; set => _gia = value; }
        public string Tenhang { get => _tenhang; set => _tenhang = value; }
        public BitmapImage Image { get => _image; set => _image = value; }
        public double Sale { get => _sale; set => _sale = value; }
        public string Linkdown { get => _linkdown; set => _linkdown = value; }
        public BitmapImage Imageinfo { get => _imageinfo; set => _imageinfo = value; }
        public string Date { get => date; set => date = value; }

        public SanPham()
        {

        }

        public SanPham(int id, string tensp, string theloai, string thongtinsp, double gia, string tenhang, BitmapImage image, double sale, string linkdown, BitmapImage imageinfo, string date)
        {
            Id = id;
            Tensp = tensp;
            Theloai = theloai;
            Thongtinsp = thongtinsp;
            Gia = gia;
            Tenhang = tenhang;
            Image = image;
            Sale = sale;
            Linkdown = linkdown;
            Imageinfo = imageinfo;
            Date = date;
        }
    }
}
