using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Errors
{
    public class MemberErrors
    {
        public string memberidError { get; set; }
        public string emailError { get; set; }
        public string companynameError { get; set; }
        public string cityError { get; set; }
        public string countryError { get; set; }
        public string passwordError { get; set; }

        public bool isEmpty()
        {
            return checkEmpty(memberidError, false) 
                && checkEmpty(emailError, false)
                && checkEmpty(companynameError, false) 
                && checkEmpty(passwordError, false)
                && checkEmpty(cityError, false) 
                && checkEmpty(countryError, false);
        }

        public string Display()
        {
            string message = null;
            if (checkEmpty(memberidError, true))
                message += memberidError + "\n";
            if (checkEmpty(emailError, true))
                message += emailError + "\n";
            if (checkEmpty(companynameError, true))
                message += companynameError + "\n";
            if (checkEmpty(passwordError, true))
                message += passwordError + "\n";
            if (checkEmpty(cityError, true))
                message += cityError + "\n";
            if (checkEmpty(countryError, true))
                message += countryError;
            return message;
        }

        public bool checkEmpty(string name, bool? IsNotEmpty)
        {
            if (IsNotEmpty == true)
            {
                return !String.IsNullOrEmpty(name);
            }
            return String.IsNullOrEmpty(name);
        }
    }
}
