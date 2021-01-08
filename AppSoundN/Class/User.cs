using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSoundN.Class
{
    public class User
    {
        public User()
        {
        }

        public User(string _email,string _password,bool _permission)
        {
            this.Email = _email;
            this.Password = _password;
            this.Permisstion = _permission;

        }
        
        public String Email { get; set; }
        public String Password { get; set; }
        public bool Permisstion { get; set; }
    }
}
