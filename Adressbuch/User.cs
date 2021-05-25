using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adressbuch
{
    public class User
    {
        public String name { get; set; }
        public String email { get; set; }
        public String tel { get; set; }
        public String anschrift { get; set; }

        public User() { }

        public User(String name, String email, String tel, String anschrift)
        {
            this.name = name;
            this.email = email;
            this.tel = tel;
            this.anschrift = anschrift;
        }
    }
}
