using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Errors
{
    public class OrderErrors
    {
        public string OrderIdError { get; set; }
        public string OrderMemberIdError { get; set; }
        public string OrderDateError { get; set; }
        public string OrderRequiredDateError { get; set; }
        public string OrderShippedDateError { get; set; }
        public string OrderFreightError { get; set; }

        public bool isEmpty()
        {
            return checkEmpty(OrderIdError, false)
                && checkEmpty(OrderMemberIdError, false)
                && checkEmpty(OrderDateError, false)
                && checkEmpty(OrderRequiredDateError, false)
                && checkEmpty(OrderShippedDateError, false)
                && checkEmpty(OrderFreightError, false);
        }

        public string Display()
        {
            string message = null;
            if (checkEmpty(OrderIdError, true))
                message += OrderIdError + "\n";
            if (checkEmpty(OrderMemberIdError, true))
                message += OrderMemberIdError + "\n";
            if (checkEmpty(OrderDateError, true))
                message += OrderDateError + "\n";
            if (checkEmpty(OrderRequiredDateError, true))
                message += OrderRequiredDateError + "\n";
            if (checkEmpty(OrderShippedDateError, true))
                message += OrderShippedDateError + "\n";
            if (checkEmpty(OrderFreightError, true))
                message += OrderFreightError + "\n";
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
