using AppSoundN.Class;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace AppSoundN.DatabaseApp
{
    class Product
    {
        public static void InsertToTableProfile(string email, string ten, string diaChi, string gioiTinh, string ngaySinh, byte[] avatar, string cauHoiBiMat)
        {
            string sql = $"select count(*) from Account where Email=@Email and Password=@Password and Permisson=@Permisson";
            try
            {
                ConnectStatus.OpenConnect();
                Database.command.CommandType = CommandType.Text;
                Database.command.CommandText = sql;
                Database.command.Parameters.Clear();
                Database.command.Parameters.AddWithValue("@Email", email);
                Database.command.Parameters.AddWithValue("@Ten", ten);
                Database.command.Parameters.AddWithValue("@DiaChi", diaChi);
                Database.command.Parameters.AddWithValue("@GioiTinh", gioiTinh);
                Database.command.Parameters.AddWithValue("@NgaySinh", ngaySinh);
                Database.command.Parameters.AddWithValue("@Avatar", avatar);
                Database.command.Parameters.AddWithValue("@CauHoiBiMat", cauHoiBiMat);
                Database.command.ExecuteScalar();

            }
            catch (Exception e)
            {

            }
            finally
            {
                ConnectStatus.CloseConnect();
            }
        }
        public static List<Class.SanPham> GetDataTableSanPham()
        {
            string sql = $"select * from SanPham" ;
            List<Class.SanPham> listSanPham = new List<Class.SanPham>();
            try
            {
                ConnectStatus.OpenConnect();
                Database.command.CommandType = CommandType.Text;
                Database.command.CommandText = sql;
                Database.command.Parameters.Clear();
                
                Database.reader=Database.command.ExecuteReader();
               
                while (Database.reader.Read())
                {
                    Class.SanPham sp = new Class.SanPham();
                    int id1 = Database.reader.GetInt32(0);
                    string tenSp = Database.reader.GetString(1);
                    string theLoai = Database.reader.GetString(2);

                    double gia = Convert.ToDouble(Database.reader.GetValue(3).ToString()); 
                    double sale = Convert.ToDouble(Database.reader.GetValue(4).ToString()); 
                  
                    byte[] image= (byte[])Database.reader.GetValue(5);
                    sp.Image = Utils.Helpers.ConvertByteToImageBitmap(image);
                    byte[] image2 = (byte[])Database.reader.GetValue(5);
                    sp.Imageinfo = Utils.Helpers.ConvertByteToImageBitmap(image2);
                    string linkdown = Database.reader.GetString(6);
                    string tenhang = Database.reader.GetString(7);
                    string infosp = Database.reader.GetString(8);
                    sp.Id = id1;
                    sp.Tensp = tenSp;
                    sp.Theloai = theLoai;
                    sp.Gia = gia;
                    sp.Sale = sale;
                    sp.Linkdown = linkdown;
                    sp.Tenhang = tenhang;
                    sp.Thongtinsp = infosp;
                    listSanPham.Add(sp);
                }
                


            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                ConnectStatus.CloseConnect();
            }
            return listSanPham;
        }
        public static List<Class.SanPham> GetDataTableSanPhamTheLoai(string theloai)
        {
            string sql = $"select * from SanPham where Theloai=@Theloai";
            List<Class.SanPham> listSanPham = new List<Class.SanPham>();
            try
            {
                ConnectStatus.OpenConnect();
                Database.command.CommandType = CommandType.Text;
                Database.command.CommandText = sql;
                Database.command.Parameters.Clear();
                Database.command.Parameters.AddWithValue("@Theloai", theloai);
                Database.reader = Database.command.ExecuteReader();

                while (Database.reader.Read())
                {
                    Class.SanPham sp = new Class.SanPham();
                    int id1 = Database.reader.GetInt32(0);
                    string tenSp = Database.reader.GetString(1);
                    string theLoai = Database.reader.GetString(2);
                    double gia = Convert.ToDouble(Database.reader.GetValue(3).ToString());
                    double sale = Convert.ToDouble(Database.reader.GetValue(4).ToString());
                    byte[] image = (byte[])Database.reader.GetValue(5);
                    sp.Image = Utils.Helpers.ConvertByteToImageBitmap(image);
                    byte[] image2 = (byte[])Database.reader.GetValue(9);
                    sp.Imageinfo = Utils.Helpers.ConvertByteToImageBitmap(image2);
                    string linkdown = Database.reader.GetString(6);
                    string tenhang = Database.reader.GetString(7);
                    string infosp = Database.reader.GetString(8);
                    sp.Id = id1;
                    sp.Tensp = tenSp;
                    sp.Theloai = theLoai;
                    sp.Gia = gia;
                    sp.Sale = sale;
                    sp.Linkdown = linkdown;
                    sp.Tenhang = tenhang;
                    sp.Thongtinsp = infosp;
                    listSanPham.Add(sp);
                    
                }
            }
            catch (Exception e)
            {
                
                MessageBox.Show(e.Message);
            }
            finally
            {
                Database.reader.Close();
                ConnectStatus.CloseConnect();
            }
            return listSanPham;
        }
        public static List<Class.SanPham> GetDataTableSanPhamSale()
        {
            string sql = $"select * from SanPham where Sale<>100";
            List<Class.SanPham> listSanPham2 = new List<Class.SanPham>();
            try
            {
                ConnectStatus.OpenConnect();
                Database.command.CommandType = CommandType.Text;
                Database.command.CommandText = sql;
                Database.command.Parameters.Clear();
                Database.reader = Database.command.ExecuteReader();

                while (Database.reader.Read())
                {
                    Class.SanPham sp = new Class.SanPham();
                    int id1 = Database.reader.GetInt32(0);
                    string tenSp = Database.reader.GetString(1);
                    string theLoai = Database.reader.GetString(2);

                    double gia = Convert.ToDouble(Database.reader.GetValue(3).ToString());
                    double sale1 = Convert.ToDouble(Database.reader.GetValue(4).ToString());

                    byte[] image = (byte[])Database.reader.GetValue(5);
                    sp.Image = Utils.Helpers.ConvertByteToImageBitmap(image);
                    byte[] image2 = (byte[])Database.reader.GetValue(9);
                    sp.Imageinfo = Utils.Helpers.ConvertByteToImageBitmap(image2);
                    string linkdown = Database.reader.GetString(6);
                    string tenhang = Database.reader.GetString(7);
                    string infosp = Database.reader.GetString(8);
                    sp.Id = id1;
                    sp.Tensp = tenSp;
                    sp.Theloai = theLoai;
                    sp.Gia = gia;
                    sp.Sale = sale1;
                    sp.Linkdown = linkdown;
                    sp.Tenhang = tenhang;
                    sp.Thongtinsp = infosp;
                    listSanPham2.Add(sp);
                }



            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                Database.reader.Close();
                ConnectStatus.CloseConnect();
            }
            return listSanPham2;
        }
        public static List<Class.SanPham> GetDataTableSanPhamFree()
        {
            string sql = $"select * from SanPham where Sale=100";
            List<Class.SanPham> listSanPham3 = new List<Class.SanPham>();
            try
            {
                ConnectStatus.OpenConnect();
                Database.command.CommandType = CommandType.Text;
                Database.command.CommandText = sql;
                Database.command.Parameters.Clear();
                Database.reader = Database.command.ExecuteReader();

                while (Database.reader.Read())
                {
                    Class.SanPham sp = new Class.SanPham();
                    int id1 = Database.reader.GetInt32(0);
                    string tenSp = Database.reader.GetString(1);
                    string theLoai = Database.reader.GetString(2);

                    double gia = Convert.ToDouble(Database.reader.GetValue(3).ToString());
                    double sale1 = Convert.ToDouble(Database.reader.GetValue(4).ToString());

                    byte[] image = (byte[])Database.reader.GetValue(5);
                    sp.Image = Utils.Helpers.ConvertByteToImageBitmap(image);
                    byte[] image2 = (byte[])Database.reader.GetValue(9);
                    sp.Imageinfo = Utils.Helpers.ConvertByteToImageBitmap(image2);
                    string linkdown = Database.reader.GetString(6);
                    string tenhang = Database.reader.GetString(7);
                    string infosp = Database.reader.GetString(8);
                    sp.Id = id1;
                    sp.Tensp = tenSp;
                    sp.Theloai = theLoai;
                    sp.Gia = gia;
                    sp.Sale = sale1;
                    sp.Linkdown = linkdown;
                    sp.Tenhang = tenhang;
                    sp.Thongtinsp = infosp;
                    listSanPham3.Add(sp);
                }



            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                Database.reader.Close();
                ConnectStatus.CloseConnect();
            }
            return listSanPham3;
        }
        public static List<Class.SanPham> GetInfoSanPhamSale()
        {
            string sql = $"select * from SanPham where Sale<>100";
            List<Class.SanPham> listSanPham3 = new List<Class.SanPham>();
            try
            {
                ConnectStatus.OpenConnect();
                Database.command.CommandType = CommandType.Text;
                Database.command.CommandText = sql;
                Database.command.Parameters.Clear();
                Database.reader = Database.command.ExecuteReader();

                while (Database.reader.Read())
                {
                    Class.SanPham sp = new Class.SanPham();
                    int id1 = Database.reader.GetInt32(0);
                    string tenSp = Database.reader.GetString(1);
                    string theLoai = Database.reader.GetString(2);

                    double gia = Convert.ToDouble(Database.reader.GetValue(3).ToString());
                    double sale1 = Convert.ToDouble(Database.reader.GetValue(4).ToString());

                    byte[] image = (byte[])Database.reader.GetValue(5);
                    sp.Image = Utils.Helpers.ConvertByteToImageBitmap(image);
                    byte[] image2 = (byte[])Database.reader.GetValue(9);
                    sp.Imageinfo = Utils.Helpers.ConvertByteToImageBitmap(image2);
                    string linkdown = Database.reader.GetString(6);
                    string tenhang = Database.reader.GetString(7);
                    string infosp = Database.reader.GetString(8);
                    sp.Id = id1;
                    sp.Tensp = tenSp;
                    sp.Theloai = theLoai;
                    sp.Gia = gia;
                    sp.Sale = sale1;
                    sp.Linkdown = linkdown;
                    sp.Tenhang = tenhang;
                    sp.Thongtinsp = infosp;
                    listSanPham3.Add(sp);
                }



            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                Database.reader.Close();
                ConnectStatus.CloseConnect();
            }
            return listSanPham3;
        }
        public static List<Class.SanPham> GetSanPhamTheLoaiSale(string theloai)
        {
            string sql = $"select * from SanPham where Theloai=@Theloai and Sale<>100";
            List<Class.SanPham> listSanPham3 = new List<Class.SanPham>();
            try
            {
                ConnectStatus.OpenConnect();
                Database.command.CommandType = CommandType.Text;
                Database.command.CommandText = sql;
                Database.command.Parameters.Clear();
                Database.command.Parameters.AddWithValue("@Theloai", theloai);
                Database.reader = Database.command.ExecuteReader();

                while (Database.reader.Read())
                {
                    Class.SanPham sp = new Class.SanPham();
                    int id1 = Database.reader.GetInt32(0);
                    string tenSp = Database.reader.GetString(1);
                    string theLoai = Database.reader.GetString(2);

                    double gia = Convert.ToDouble(Database.reader.GetValue(3).ToString());
                    double sale1 = Convert.ToDouble(Database.reader.GetValue(4).ToString());

                    byte[] image = (byte[])Database.reader.GetValue(5);
                    sp.Image = Utils.Helpers.ConvertByteToImageBitmap(image);
                    byte[] image2 = (byte[])Database.reader.GetValue(5);
                    sp.Imageinfo = Utils.Helpers.ConvertByteToImageBitmap(image2);
                    string linkdown = Database.reader.GetString(6);
                    string tenhang = Database.reader.GetString(7);
                    string infosp = Database.reader.GetString(8);
                    sp.Id = id1;
                    sp.Tensp = tenSp;
                    sp.Theloai = theLoai;
                    sp.Gia = gia;
                    sp.Sale = sale1;
                    sp.Linkdown = linkdown;
                    sp.Tenhang = tenhang;
                    sp.Thongtinsp = infosp;
                    listSanPham3.Add(sp);
                }



            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                Database.reader.Close();
                ConnectStatus.CloseConnect();
            }
            return listSanPham3;
        }
        public static List<Class.SanPham> GetSanPhamTheLoaiFree(string theloai)
        {
            string sql = $"select * from SanPham where Theloai=@Theloai and Sale=100";
            List<Class.SanPham> listSanPham3 = new List<Class.SanPham>();
            try
            {
                ConnectStatus.OpenConnect();
                Database.command.CommandType = CommandType.Text;
                Database.command.CommandText = sql;
                Database.command.Parameters.Clear();
                Database.command.Parameters.AddWithValue("@Theloai", theloai);
                Database.reader = Database.command.ExecuteReader();

                while (Database.reader.Read())
                {
                    Class.SanPham sp = new Class.SanPham();
                    int id1 = Database.reader.GetInt32(0);
                    string tenSp = Database.reader.GetString(1);
                    string theLoai = Database.reader.GetString(2);

                    double gia = Convert.ToDouble(Database.reader.GetValue(3).ToString());
                    double sale1 = Convert.ToDouble(Database.reader.GetValue(4).ToString());

                    byte[] image = (byte[])Database.reader.GetValue(5);
                    sp.Image = Utils.Helpers.ConvertByteToImageBitmap(image);
                    byte[] image2 = (byte[])Database.reader.GetValue(9);
                    sp.Imageinfo = Utils.Helpers.ConvertByteToImageBitmap(image2);
                    string linkdown = Database.reader.GetString(6);
                    string tenhang = Database.reader.GetString(7);
                    string infosp = Database.reader.GetString(8);
                    sp.Id = id1;
                    sp.Tensp = tenSp;
                    sp.Theloai = theLoai;
                    sp.Gia = gia;
                    sp.Sale = sale1;
                    sp.Linkdown = linkdown;
                    sp.Tenhang = tenhang;
                    sp.Thongtinsp = infosp;
                    listSanPham3.Add(sp);
                }



            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                Database.reader.Close();
                ConnectStatus.CloseConnect();
            }
            return listSanPham3;
        }
        public static List<Class.SanPham> GetAllSanPham()
        {
            string sql = $"select * from SanPham ";
            List<Class.SanPham> listSanPham3 = new List<Class.SanPham>();
            try
            {
                ConnectStatus.OpenConnect();
                Database.command.CommandType = CommandType.Text;
                Database.command.CommandText = sql;
                Database.command.Parameters.Clear();
                Database.reader = Database.command.ExecuteReader();

                while (Database.reader.Read())
                {
                    Class.SanPham sp = new Class.SanPham();
                    int id1 = Database.reader.GetInt32(0);
                    string tenSp = Database.reader.GetString(1);
                    string theLoai = Database.reader.GetString(2);

                    double gia = Convert.ToDouble(Database.reader.GetValue(3).ToString());
                    double sale1 = Convert.ToDouble(Database.reader.GetValue(4).ToString());

                    byte[] image = (byte[])Database.reader.GetValue(5);
                    sp.Image = Utils.Helpers.ConvertByteToImageBitmap(image);
                    byte[] image2 = (byte[])Database.reader.GetValue(9);
                    sp.Imageinfo = Utils.Helpers.ConvertByteToImageBitmap(image2);
                    string linkdown = Database.reader.GetString(6);
                    string tenhang = Database.reader.GetString(7);
                    string infosp = Database.reader.GetString(8);
                    sp.Id = id1;
                    sp.Tensp = tenSp;
                    sp.Theloai = theLoai;
                    sp.Gia = gia;
                    sp.Sale = sale1;
                    sp.Linkdown = linkdown;
                    sp.Tenhang = tenhang;
                    sp.Thongtinsp = infosp;
                    listSanPham3.Add(sp);
                }



            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                Database.reader.Close();
                ConnectStatus.CloseConnect();
            }
            return listSanPham3;
        }
        public static int GetCountSp(string theloai)
        {
            int count = 0;
            string sql = $"select count(*) from SanPham where Theloai=@Theloai";
            try
            {
                ConnectStatus.OpenConnect();
                Database.command.CommandType = CommandType.Text;
                Database.command.CommandText = sql;
                Database.command.Parameters.Clear();
                Database.command.Parameters.AddWithValue("@Theloai", theloai);
                count = Convert.ToInt32(Database.command.ExecuteScalar().ToString());
                
        }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                ConnectStatus.CloseConnect();
            }
            return count;

        }
        public static int GetCountAllSp()
        {
            int count = 0;
            string sql = $"select count(*) from SanPham";
            try
            {
                ConnectStatus.OpenConnect();
                Database.command.CommandType = CommandType.Text;
                Database.command.CommandText = sql;
                Database.command.Parameters.Clear();
                count = Convert.ToInt32(Database.command.ExecuteScalar().ToString());

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                ConnectStatus.CloseConnect();
            }
            return count;

        }
        public static int GetCountSale()
        {
            int count = 0;
            string sql = $"select count(*) from SanPham where Sale<>100";
            try
            {
                ConnectStatus.OpenConnect();
                Database.command.CommandType = CommandType.Text;
                Database.command.CommandText = sql;
                Database.command.Parameters.Clear();
                count = Convert.ToInt32(Database.command.ExecuteScalar().ToString());

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                ConnectStatus.CloseConnect();
            }
            return count;

        }
        public static int GetCountFree()
        {
            int count = 0;
            string sql = $"select count(*) from SanPham where Sale=100";
            try
            {
                ConnectStatus.OpenConnect();
                Database.command.CommandType = CommandType.Text;
                Database.command.CommandText = sql;
                Database.command.Parameters.Clear();
                count = Convert.ToInt32(Database.command.ExecuteScalar().ToString());

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                ConnectStatus.CloseConnect();
            }
            return count;

        }
        public static int GetCountTheloaiFree(string theloai)
        {
            int count = 0;
            string sql = $"select count(*) from SanPham where Theloai=@Theloai and Sale=100";
            try
            {
                ConnectStatus.OpenConnect();
                Database.command.CommandType = CommandType.Text;
                Database.command.CommandText = sql;
                Database.command.Parameters.Clear();
                Database.command.Parameters.AddWithValue("@Theloai", theloai);
                count = Convert.ToInt32(Database.command.ExecuteScalar().ToString());

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                ConnectStatus.CloseConnect();
            }
            return count;

        }
        public static int GetCountTheloaiSale(string theloai)
        {
            int count = 0;
            string sql = $"select count(*) from SanPham where Theloai=@Theloai and Sale<>100";
            try
            {
                ConnectStatus.OpenConnect();
                Database.command.CommandType = CommandType.Text;
                Database.command.CommandText = sql;
                Database.command.Parameters.Clear();
                Database.command.Parameters.AddWithValue("@Theloai", theloai);
                count = Convert.ToInt32(Database.command.ExecuteScalar().ToString());

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                ConnectStatus.CloseConnect();
            }
            return count;

        }
        public static List<SanPham> GetYourPlugin(string email)
        {   List<SanPham> list = new List<SanPham>();
            string sql = $"Select * from SanPham sp, UserBuy us where us.Email_user=@Email and us.ID_sp=sp.ID";
            try
            {
                ConnectStatus.OpenConnect();
                Database.command.CommandType = CommandType.Text;
                Database.command.CommandText = sql;
                Database.command.Parameters.Clear();
                Database.command.Parameters.AddWithValue("@Email", email);
                Database.reader=Database.command.ExecuteReader();
                while (Database.reader.Read())
                {
                    Class.SanPham sp = new Class.SanPham();
                    int id = Database.reader.GetInt32(0);
                    string tensp = Database.reader.GetString(1);
                    string theloai = Database.reader.GetString(2);
                    double gia = Convert.ToDouble(Database.reader.GetValue(3).ToString());
                    double sale = Convert.ToDouble(Database.reader.GetValue(4).ToString());
                    
                    byte[] image = (byte[])Database.reader.GetValue(5);
                    sp.Image = Utils.Helpers.ConvertByteToImageBitmap(image);
                    string linkdown = Database.reader.GetString(6);
                    string Tenhang = Database.reader.GetString(7);
                    string infosp = Database.reader.GetString(8);
                    byte[] image2 = (byte[])Database.reader.GetValue(9);
                    sp.Image = Utils.Helpers.ConvertByteToImageBitmap(image2);
                    string email_user = Database.reader.GetString(10);
                    int id_sp = Database.reader.GetInt32(11);
                    string ngayMua = Database.reader.GetDateTime(12).ToString();  
                    sp.Id = id;
                    sp.Tensp = tensp;
                    sp.Theloai = theloai;
                    sp.Gia = gia;
                    sp.Sale = sale;
                    sp.Linkdown = linkdown;
                    sp.Tenhang = Tenhang;
                    sp.Thongtinsp = infosp;
                    sp.Date = ngayMua;
                    list.Add(sp);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                Database.reader.Close();
                ConnectStatus.CloseConnect();
            }
            return list;

        }

        public static bool InsertTableUserBuy(string email, int id)
        {
            string sql = $"insert into UserBuy (Email_user,ID_sp) values(@Email,@ID)";
            try
            {
                ConnectStatus.OpenConnect();
                Database.command.CommandType = CommandType.Text;
                Database.command.CommandText = sql;
                Database.command.Parameters.Clear();
                Database.command.Parameters.AddWithValue("@Email", email);
                Database.command.Parameters.AddWithValue("@ID", id);
                Database.command.ExecuteScalar();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                ConnectStatus.CloseConnect();
            }
            return false;

        }
        public static bool CheckProductBuy(string email)
        {
            string sql = $"Select * from SanPham sp, UserBuy us where us.Email_user=@Email and us.ID_sp=sp.ID";
            try
            {
                ConnectStatus.OpenConnect();
                Database.command.CommandType = CommandType.Text;
                Database.command.CommandText = sql;
                Database.command.Parameters.Clear();
                Database.command.Parameters.AddWithValue("@Email", email) ;
                Database.command.ExecuteScalar();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                ConnectStatus.CloseConnect();
            }
            return false;

        }

        public static bool CheckSpDaMua(string email, int id)
        {
            string sql = $"Select count(*) from UserBuy where Email_user=@Email and ID_sp=@ID";
            try
            {
                ConnectStatus.OpenConnect();
                Database.command.CommandType = CommandType.Text;
                Database.command.CommandText = sql;
                Database.command.Parameters.Clear();
                Database.command.Parameters.AddWithValue("@Email", email);
                Database.command.Parameters.AddWithValue("ID", id);
                int count = Convert.ToInt32(Database.command.ExecuteScalar().ToString());
                if(count==1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                return false;
            }
            finally
            {
                ConnectStatus.CloseConnect();
            }
            

        }
        public static string GetLinkDown(int id)
        {
            string sql = $"Select Linkdown from SanPham where ID=@ID";
            try
            {
                ConnectStatus.OpenConnect();
                Database.command.CommandType = CommandType.Text;
                Database.command.CommandText = sql;
                Database.command.Parameters.Clear();
                Database.command.Parameters.AddWithValue("ID", id);
                Database.reader = Database.command.ExecuteReader();
                if(Database.reader.Read())
                {
                    string link = Database.reader.GetString(0);
                    return link;

                }    
            }
            catch (Exception e)
            {
                string linkerrr = "https://www.google.com/";
                return linkerrr;
            }
            finally
            {
                Database.reader.Close();
                ConnectStatus.CloseConnect();
            }

            string linkerrr2 = "https://www.google.com/";
            return linkerrr2;
        }



    }
}
