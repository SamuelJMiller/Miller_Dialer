using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miller_Dialer
{
    class Phone
    {
        string _company_name;
        string _phone_number;
        string _phone_type;

        public Phone(string companyName, string phoneNumber, string phoneType)
        {
            _company_name = companyName;
            _phone_number = phoneNumber;
            _phone_type = phoneType;
        }

        public string CompanyName
        {
            get { return _company_name; }
            set { _company_name = value; }
        }

        public string PhoneNumber
        {
            get { return _phone_number; }
            set { _phone_number = value; }
        }

        public string PhoneType
        {
            get { return _phone_type; }
            set { _phone_type = value; }
        }


        public virtual string Dial()
        {
            return CompanyName + " is being dialed using " + PhoneNumber + "...";
        }
    }
}
