using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSoundN.Class
{
    class NguoiMua
    {
        private string _email_user;
        private int _id_sp;
        private string date;

        public string Email_user { get => _email_user; set => _email_user = value; }
        public int Id_sp { get => _id_sp; set => _id_sp = value; }
        public string Date { get => date; set => date = value; }

        public NguoiMua()
        {

        }
        public NguoiMua(string email_user, int id_sp, string date)
        {
            Email_user = email_user;
            Id_sp = id_sp;
            Date = date;
        }
    }
}
