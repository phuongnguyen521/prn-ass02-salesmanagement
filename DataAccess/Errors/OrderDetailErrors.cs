using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Errors
{
    public class OrderDetailErrors
    {
        public string OrderIdError { get; set; }
        public string OrderProductIdError { get; set; }
        public string OrderUnitPriceError { get; set; }
        public string OrderQuantityError { get; set; }
        public string OrderDiscountError { get; set; }

        public bool isEmpty()
        {
            return checkEmpty(OrderIdError, false)
                && checkEmpty(OrderProductIdError, false)
                && checkEmpty(OrderUnitPriceError, false)
                && checkEmpty(OrderQuantityError, false)
                && checkEmpty(OrderDiscountError, false);
        }

        public string Display()
        {
            string message = null;
            if (checkEmpty(OrderIdError, true))
                message += OrderIdError + "\n";
            if (checkEmpty(OrderProductIdError, true))
                message += OrderProductIdError + "\n";
            if (checkEmpty(OrderUnitPriceError, true))
                message += OrderUnitPriceError + "\n";
            if (checkEmpty(OrderQuantityError, true))
                message += OrderQuantityError + "\n";
            if (checkEmpty(OrderDiscountError, true))
                message += OrderDiscountError + "\n";
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
