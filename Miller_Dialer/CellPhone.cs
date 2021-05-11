using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miller_Dialer
{
    class CellPhone : Phone
    {
        // Pass data to parent class phone:
        public CellPhone(string companyName, string phoneNumber, string phoneType) : base(companyName, phoneNumber, phoneType)
        {

        }

        // Override Dial() for cell phone prepend:
        public override string Dial()
        {
            return CompanyName + " is being dialed using 1+" + PhoneNumber + "...";
        }
    }
}
