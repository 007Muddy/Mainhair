using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Model
{
    public class CustomerInformation
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Emil { get; set; }
        public CustomerInformation()
        
        {
        
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
