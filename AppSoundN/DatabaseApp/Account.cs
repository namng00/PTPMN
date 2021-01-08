using AppSoundN.Class;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Imaging;

namespace AppSoundN.DatabaseApp
{
    class Account 
    {
        public static bool CheckAccountDatabase(string email,string password, bool permisson)
        {
            string sql = $"select count(*) from Account where Email=@Email and Password=@Password and Permisson=@Permisson";
            try
            {
                ConnectStatus.OpenConnect();
                Database.command.CommandType = CommandType.Text ;
                Database.command.CommandText = sql;
                Database.command.Parameters.Clear();
                Database.command.Parameters.AddWithValue("@Email", email);
                Database.command.Parameters.AddWithValue("@Password", password);
                Database.command.Parameters.AddWithValue("@Permisson", permisson);
                int count = Convert.ToInt32(Database.command.ExecuteScalar().ToString());
                if (count != 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch(Exception e)
            {
                return false;
            }
            finally
            {
                ConnectStatus.CloseConnect();

            }
        }

        

        public static bool InsertTableAccout(string email, string password)
        {
            String sql=$"insert into Account values(@Email,@Password,0);";
            
            try
            {
                ConnectStatus.OpenConnect();
                Database.command.CommandType = CommandType.Text;
                Database.command.CommandText = sql;
                Database.command.Parameters.Clear();
                Database.command.Parameters.AddWithValue("@Email", email);
                Database.command.Parameters.AddWithValue("@Password", password);
                Database.command.ExecuteScalar();
                return true;

            }
            catch(Exception e)
            {
                return false;   
            }
            finally
            {
                ConnectStatus.CloseConnect();
            }
        }
        public static Profile GetTableProfile(string email)
        {
            String sql = $"select * from Profile where Email=@Email";
            Profile profile1 = new Profile();
            try
            {
                ConnectStatus.OpenConnect();
                Database.command.CommandType = CommandType.Text;
                Database.command.CommandText = sql;
                Database.command.Parameters.Clear();
                Database.command.Parameters.AddWithValue("@Email", email);
                Database.reader = Database.command.ExecuteReader();
                if (Database.reader.Read())
                {
                    
                    string email1 = Database.reader.GetValue(0).ToString();
                    string ten = Database.reader.GetString(1);
                    string diachi = Database.reader.GetString(2);
                    string gioitinh = Database.reader.GetString(3);
                    string ngaysinh = Database.reader.GetString(4);
                    BitmapImage image;
                    try
                    {
                        image = Utils.Helpers.ConvertByteToImageBitmap((byte[])Database.reader.GetValue(5));
                    }
                    catch(Exception exception)
                    {
                        image = new BitmapImage(new Uri($"../../Image/icon.ico", UriKind.RelativeOrAbsolute));
                    }
                    profile1.Avatar = image;
                    string cauhoi = Database.reader.GetString(6);
                    profile1.Email = email1;
                    profile1.Ten = ten;
                    profile1.DiaChi = diachi;
                    
                    profile1.NgaySinh = ngaysinh;
                    profile1.CauHoiBiMat = cauhoi;
                    
                    return profile1;
                   


                }
                
                    

            }
            catch (Exception e)
            {
                MessageBox.Show("Loi: " + e.Message);
            }
            finally
            {
                Database.reader.Close();
                ConnectStatus.CloseConnect();
            }
            return profile1;

        }
        public static bool UpdatePassWord(string password, string email)
        {
            String sql = $"update Account set Password=@Password where Email=@Email";
            try
            {
                ConnectStatus.OpenConnect();
                Database.command.CommandType = CommandType.Text;
                Database.command.CommandText = sql;
                Database.command.Parameters.Clear();
                Database.command.Parameters.AddWithValue("@Email", email);
                Database.command.Parameters.AddWithValue("Password", password);
                Database.command.ExecuteScalar();
                return true;
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
        public static bool CheckQueri(string cauhoi,string email)
        {
            String sql = $"select count(*) from Account acc, Profile profile  where acc.Email=profile.Email and acc.Email=@Email  and profile.Email=@Email  and profile.Cauhoibimat=@Cauhoibimat";
            try
            {
                ConnectStatus.OpenConnect();
                Database.command.CommandType = CommandType.Text;
                Database.command.CommandText = sql;
                Database.command.Parameters.Clear();
                Database.command.Parameters.AddWithValue("@Cauhoibimat", cauhoi);
                Database.command.Parameters.AddWithValue("@Email", email);
                Database.command.ExecuteScalar();
                int count = Convert.ToInt32(Database.command.ExecuteScalar().ToString());
                if (count != 0)
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
        public static bool UpdateProfile(string email,string ten,string diachi,string ngaysinh)
        {
            String sql = $"update Profile SET Ten=@Ten, Diachi=@Diachi, NgaySinh=@NgaySinh where Email=@Email;";
            try
            {
                ConnectStatus.OpenConnect();
                Database.command.CommandType = CommandType.Text;
                Database.command.CommandText = sql;
                Database.command.Parameters.Clear();
                Database.command.Parameters.AddWithValue("@Email", email);
                Database.command.Parameters.AddWithValue("@Ten", ten);
                Database.command.Parameters.AddWithValue("@DiaChi", diachi);
                
                Database.command.Parameters.AddWithValue("@NgaySinh", ngaysinh);
                Database.command.ExecuteScalar();
                return true;
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
        public static bool InsertEmail(string email)
        {
            String sql = $"insert into Profile(Email) values(@Email);";
            try
            {
                ConnectStatus.OpenConnect();
                Database.command.CommandType = CommandType.Text;
                Database.command.CommandText = sql;
                Database.command.Parameters.Clear();
                Database.command.Parameters.AddWithValue("@Email", email);
                Database.command.ExecuteScalar();
                return true;
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

    }
}


