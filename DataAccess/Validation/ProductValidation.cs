using BusinessObject.Object;
using DataAccess.Errors;
using System;
using System.Text.RegularExpressions;

namespace DataAccess.Validation
{
    public class ProductValidation
    {
        #region Initialized Parameter
        private ValidationData validation = null;
        private ProductErrors productErrors = null;
        private static ProductValidation instance = null;
        private static readonly object instanceLock = new object();
        private ProductValidation() { }
        public static ProductValidation Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new ProductValidation();
                    }
                }
                return instance;
            }
        }
        #endregion

        #region Common
        //Check if the text field is redundant whitespace
        public string checkRedundantWhiteSpace(string obj)
        {
            Regex trimmer = new Regex(@"\\s\\s+");
            return obj = trimmer.Replace(obj.Trim(), " ");
        }
        #endregion

        #region Product
        /*--------------------------------------------------------------------------------*/
        //Checking Product's id
        //Specification: Integer number
        public string checkProductId(string id, bool? checkProduct)
        {
            validation = new ValidationData();
            string error = validation.CheckNumber("Order Id", id, 1, int.MaxValue, true, true);
            if (checkProduct == true && error != null)
                productErrors.ProductIdError = error;
            return error;
        }

        /*--------------------------------------------------------------------------------*/
        //Checking Product's id
        //Specification: Integer number
        public string checkProductCategoryId(string categoryId, bool? checkProduct)
        {
            if (categoryId.Equals("None"))
                return "Select Category ID";
            validation = new ValidationData();
            string error = validation.CheckNumber("Category Id", categoryId, 1, int.MaxValue, true, true);
            if (checkProduct == true && error != null)
                productErrors.ProductCategoryIdError = error;
            return error;
        }
        /*--------------------------------------------------------------------------------*/
        //For Product's Name
        //Including checking both the length and regex as well
        //Specification: No special character and number, from 2 to 40 characters

        public string checkProductName(string productName, bool? checkProduct)
        {
            validation = new ValidationData();
            string error = validation.CheckStringType("Product Name", productName, true, 2, 40, @"^[a-zA-Z\s]{2,40}$");
            if (checkProduct == true && error != null)
                productErrors.ProductNameError = error;
            return error;
        }

        /*--------------------------------------------------------------------------------*/
        //Checking Product's Weight
        //Specification: Decimal number

        public string checkProductWeight(string weight, bool? checkProduct)
        {
            validation = new ValidationData();
            string error = validation.CheckNumber("Weight", weight, 1, int.MaxValue, true, false);
            if (checkProduct == true && error != null)
                productErrors.ProductWeightError = error;
            return error;
        }

        /*--------------------------------------------------------------------------------*/
        //Checking Product's Unit Price
        //Specification: Decimal number

        public string checkProductUnitPrice(string unitPrice, bool? checkProduct)
        {
            validation = new ValidationData();
            string error = validation.CheckNumber("Unit Price", unitPrice, 1, int.MaxValue, true, false);
            if (checkProduct == true && error != null)
                productErrors.ProductUnitPriceError = error;
            return error;
        }

        /*--------------------------------------------------------------------------------*/
        //Checking Product's Units In Stock
        //Specification: Integer number
        public string checkProductUnitsInStock(string unitInStock, bool? checkProduct)
        {
            validation = new ValidationData();
            string error = validation.CheckNumber("Units In Stock", unitInStock, 1, int.MaxValue, true, true);
            if (checkProduct == true && error != null)
                productErrors.ProductUnitsInStockError = error;
            return error;
        }

        /*--------------------------------------------------------------------------------*/
        //Checking Product Overall
        public ProductErrors checkProduct(Product product)
        {
            productErrors = null;
            productErrors = new ProductErrors();
            checkProductId(Convert.ToString(product.ProductId), true);
            checkProductCategoryId(Convert.ToString(product.CategoryId), true);
            checkProductName(product.ProductName, true);
            checkProductWeight(Convert.ToString(product.Weight), true);
            checkProductUnitPrice(Convert.ToString(product.UnitPrice), true);
            checkProductUnitsInStock(Convert.ToString(product.UnitsInStock), true);
            if (productErrors.isEmpty())
                productErrors = null;
            return productErrors;
        }

        public ProductErrors checkProductIDAndName(Product product)
        {
            productErrors = null;
            productErrors = new ProductErrors();
            checkProductId(Convert.ToString(product.ProductId), true);
            checkProductName(product.ProductName, true);
            if (productErrors.isEmpty())
                productErrors = null;
            return productErrors;
        }

        public ProductErrors checkFilterUnitsInStock(string from, string to)
        {
            productErrors = null;
            productErrors = new ProductErrors();
            productErrors.ProductUnitsInStockError = checkProductUnitsInStock(from, false);
            string temp = checkProductUnitsInStock(to, false);
            if (productErrors.ProductUnitsInStockError == null)
                productErrors.ProductUnitsInStockError = temp;
            else
                productErrors.ProductUnitsInStockError += "\n" + temp;
            if (productErrors.isEmpty())
                productErrors = checkFilterUnit(from, to, true);
            return productErrors;
        }

        public ProductErrors checkFilterUnitPrice(string from, string to)
        {
            productErrors = null;
            productErrors = new ProductErrors();
            productErrors.ProductUnitPriceError = checkProductUnitPrice(from, false);
            string temp = checkProductUnitPrice(to, false);
            if (productErrors.ProductUnitPriceError == null)
                productErrors.ProductUnitPriceError = temp;
            else
                productErrors.ProductUnitPriceError += "\n" + temp;
            if (productErrors.isEmpty())
                productErrors = checkFilterUnit(from, to, false);
            return productErrors;
        }

        public ProductErrors checkFilterUnit(string from, string to, bool IsInterger)
        {
            productErrors = null;
            if (IsInterger)
            {
                if (Convert.ToInt32(from) > Convert.ToInt32(from))
                    productErrors.ProductUnitsInStockError = "Value of from is larger than value of To";
            }
            else
            {
                if (Convert.ToDecimal(from) > Convert.ToDecimal(from))
                    productErrors.ProductUnitPriceError = "Value of from is larger than value of To";
            }
            return productErrors;
        }

        #endregion
    }
}
