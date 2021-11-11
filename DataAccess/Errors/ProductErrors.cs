using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Errors
{
    public class ProductErrors
    {
        public string ProductIdError { get; set; }
        public string ProductCategoryIdError { get; set; }
        public string ProductNameError { get; set; }
        public string ProductWeightError { get; set; }
        public string ProductUnitsInStockError { get; set; }
        public string ProductUnitPriceError { get; set; }

        public bool isEmpty()
        {
            return checkEmpty(ProductIdError, false)
                && checkEmpty(ProductCategoryIdError, false)
                && checkEmpty(ProductNameError, false)
                && checkEmpty(ProductWeightError, false)
                && checkEmpty(ProductUnitsInStockError, false)
                && checkEmpty(ProductUnitPriceError, false);
        }

        public string Display()
        {
            string message = null;
            if (checkEmpty(ProductIdError, true))
                message += ProductIdError + "\n";
            if (checkEmpty(ProductCategoryIdError, true))
                message += ProductCategoryIdError + "\n";
            if (checkEmpty(ProductNameError, true))
                message += ProductNameError + "\n";
            if (checkEmpty(ProductWeightError, true))
                message += ProductWeightError + "\n";
            if (checkEmpty(ProductUnitsInStockError, true))
                message += ProductUnitsInStockError + "\n";
            if (checkEmpty(ProductUnitPriceError, true))
                message += ProductUnitPriceError;
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
