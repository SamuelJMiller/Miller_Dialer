using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miller_Dialer
{
    class HomePhone : Phone
    {
        // Pass data to parent class Phone:
        public HomePhone(string companyName, string phoneNumber, string phoneType) : base(companyName, phoneNumber, phoneType)
        {
            
        }
    }
}
