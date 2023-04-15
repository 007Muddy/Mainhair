using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace WpfApp1.Model
{
    public class Authentication
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public Roles Role { get; set; } 
        

        public Authentication()
        {

        }

        public override string ToString()
        {
            return base.ToString();
        }


    }
}
