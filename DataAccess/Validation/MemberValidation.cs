using BusinessObject.Object;
using DataAccess.Errors;
using System;
using System.Text.RegularExpressions;

namespace DataAccess.Validation
{
    public class MemberValidation
    {
        #region Initialized Parameter
        private ValidationData validation = null;
        private MemberErrors memberErrors = null;
        private static MemberValidation instance = null;
        private static readonly object instanceLock = new object();
        private MemberValidation() { }
        public static MemberValidation Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new MemberValidation();
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

        #region User
        /*--------------------------------------------------------------------------------*/
        //Checking Member's id
        //Specification: Integer number

        public string checkMemberId(string id, bool? checkUser)
        {
            validation = new ValidationData();
            string error = validation.CheckNumber("Member Id", id, 1, int.MaxValue, true, true);
            if (checkUser == true && error != null)
                memberErrors.memberidError = error;
            return error;
        }

        /*--------------------------------------------------------------------------------*/
        //For Member
        //Checking Member's Password
        //Including checking both the length and regex as well
        //Specification: No whitespace, from 1 to 30 characters
        public string checkMemberPassword(string password, bool? checkUser)
        {
            validation = new ValidationData();
            string error = validation.CheckStringType("password", password, true, 3, 30, @"^[^\s]+$");
            if (checkUser == true && error != null)
                memberErrors.passwordError = error;
            return error;
        }

        /*--------------------------------------------------------------------------------*/
        //For Member
        //Checking Member's City
        //Including checking both the length and regex as well
        //Specification: No special character and number, from 1 to 15 characters

        public string checkMemberCity(string city, bool? checkUser)
        {
            validation = new ValidationData();
            string error = validation.CheckStringType("City", city, true, 1, 15, @"^[a-zA-Z\s]{1,15}$");
            if (checkUser == true && error != null)
                memberErrors.cityError = error;
            return error;
        }

        /*--------------------------------------------------------------------------------*/
        //For Member
        //Checking Member's Country
        //Including checking both the length and regex as well
        //Specification: No special character and number, from 1 to 15 characters

        public string checkMemberCountry(string country, bool? checkUser)
        {
            validation = new ValidationData();
            string error = validation.CheckStringType("Country", country, true, 1, 15, @"^[a-zA-Z\s]{1,15}$");
            if (checkUser == true && error != null)
                memberErrors.countryError = error;
            return error;
        }
        /*--------------------------------------------------------------------------------*/
        //For Member
        //Checking Member's Company Name
        //Including checking both the length and regex as well
        //Specification: No special character, from 1 to 40 characters

        public string checkMemberCompanyName(string companyname, bool? checkUser)
        {
            validation = new ValidationData();
            string error = validation.CheckStringType("Company Name", companyname, true, 1, 40, @"^[a-zA-Z0-9\s]{1,40}$");
            if (checkUser == true && error != null)
                memberErrors.countryError = error;
            return error;
        }

        /*--------------------------------------------------------------------------------*/
        //For Member
        //Checking Member's Email
        //Including checking both the length and regex as well
        //Specification: Follow this format abc@xyz.t(.v) with anything in () is optional
        public string checkMemberEmail(string email, bool? checkUser)
        {
            validation = new ValidationData();
            string error = validation.CheckStringType("email", email, true, null, 100, @"^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,3})+$");
            if (checkUser == true && error != null)
                memberErrors.emailError = error;
            return error;
        }

        /*--------------------------------------------------------------------------------*/
        //For Member Overall
        public MemberErrors checkMember(Member member)
        {
            memberErrors = null;
            memberErrors = new MemberErrors();
            checkMemberId(Convert.ToString(member.MemberId), true);
            checkMemberCompanyName(member.CompanyName,true);
            checkMemberEmail(member.Email, true);
            checkMemberCity(member.City, true);
            checkMemberCountry(member.Country, true);
            checkMemberPassword(member.Password, true);
            if (memberErrors.isEmpty())
                memberErrors = null;
            return memberErrors;
        }

        #endregion

        #region Product
        private ProductErrors productErrors = null;
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
            string error = validation.CheckNumber("Weight",weight, 1, int.MaxValue, true,false);
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
            } else
            {
                if (Convert.ToDecimal(from) > Convert.ToDecimal(from))
                    productErrors.ProductUnitPriceError = "Value of from is larger than value of To";
            }
            return productErrors;
        }

        #endregion

        #region Order
        OrderErrors orderErrors = null;
        /*--------------------------------------------------------------------------------*/
        //Checking Order's Id
        //Specification: Integer number

        public string checkOrderId(string id, bool? checkOrder)
        {
            validation = new ValidationData();
            string error = validation.CheckNumber("Order Id", id, 1, int.MaxValue, true, true);
            if (checkOrder == true && error != null)
                orderErrors.OrderIdError = error;
            return error;
        }
        /*--------------------------------------------------------------------------------*/
        //Checking Member's id
        //Specification: Integer number

        public string checkOrderMemberId(string id, bool? checkUser)
        {
            validation = new ValidationData();
            string error = validation.CheckNumber("Member Id", id, 1, int.MaxValue, true, true);
            if (checkUser == true && error != null)
                orderErrors.OrderMemberIdError = error;
            return error;
        }

        /*--------------------------------------------------------------------------------*/
        //Checking Order's Required Date
        //Specification: YYYY/MM/DD
        public string checkOrderDate(string requiredDate, bool? checkOrder)
        {
            validation = new ValidationData();
            string error = validation.checkDate("Order Date", requiredDate, true);
            if (checkOrder == true && error != null)
                orderErrors.OrderDateError = error;
            return error;
        }

        /*--------------------------------------------------------------------------------*/
        //Checking Order's Required Date
        //Specification: YYYY/MM/DD
        public string checkOrderRequiredDate(string requiredDate, bool? checkOrder)
        {
            validation = new ValidationData();
            string error = validation.checkDate("Required Date", requiredDate, false);
            if (checkOrder == true && error != null)
                orderErrors.OrderRequiredDateError = error;
            return error;
        }

        /*--------------------------------------------------------------------------------*/
        //Checking Order's Shipped Date
        //Specification: YYYY/MM/DD
        public string checkOrderShippedDate(string shippedDate, bool? checkOrder)
        {
            validation = new ValidationData();
            string error = validation.checkDate("Shipped Date", shippedDate, false);
            if (checkOrder == true && error != null)
                orderErrors.OrderRequiredDateError = error;
            return error;
        }

        /*--------------------------------------------------------------------------------*/
        //Checking Product's Unit Price
        //Specification: Decimal number
        public string checkOrderFreight(string freight, bool? checkOrder)
        {
            validation = new ValidationData();
            string error = validation.CheckNumber("Unit Price", freight, 1, int.MaxValue, false, false);
            if (checkOrder == true && error != null)
               orderErrors.OrderFreightError = error;
            return error;
        }

        /*--------------------------------------------------------------------------------*/
        // Order Overall
        public OrderErrors checkOrder(Order order)
        {
            orderErrors = null;
            orderErrors = new OrderErrors();
            checkOrderId(Convert.ToString(order.OrderId),true);
            checkOrderMemberId(Convert.ToString(order.MemberId), true);
            if (order.RequiredDate != null)
            {
                int comparision = DateTime.Compare(Convert.ToDateTime(order.RequiredDate), order.OrderDate);
                if (comparision <= 0)
                    orderErrors.OrderRequiredDateError = "Required Date is ealier than order date";
            }
            if (order.ShippedDate != null) 
            {
                int comparision = DateTime.Compare(Convert.ToDateTime(order.ShippedDate), order.OrderDate);
                if (comparision <= 0)
                    orderErrors.OrderShippedDateError = "Shipeed Date is earlier than order date";
            }
            if (order.Freight != null)
                checkOrderFreight(Convert.ToString(order.Freight), true);
            if (orderErrors.isEmpty())
                orderErrors = null;
            return orderErrors;
        }

        public OrderErrors checkOrderDate (Order order)
        {
            orderErrors = new OrderErrors();
            int comparision = DateTime.Compare(Convert.ToDateTime(order.RequiredDate), order.OrderDate);
            if (comparision <= 0)
                orderErrors.OrderRequiredDateError = "Required Date is ealier than order date";
            comparision = DateTime.Compare(Convert.ToDateTime(order.ShippedDate), order.OrderDate);
            if (comparision <= 0)
                orderErrors.OrderShippedDateError = "Shipeed Date is earlier than order date";
            if (orderErrors.isEmpty())
                orderErrors = null;
            return orderErrors;
        }

        #endregion

        #region OrderDetail
        OrderDetailErrors orderDetailErrors = null;
        /*--------------------------------------------------------------------------------*/
        //Checking Order's Id
        //Specification: Integer number
        public string checkOrderDetailOrderId(string id, bool? checkOrderDetail)
        {
            validation = new ValidationData();
            string error = validation.CheckNumber("Order Id", id, 1, int.MaxValue, true, true);
            if (checkOrderDetail == true && error != null)
                orderDetailErrors.OrderIdError = error;
            return error;
        }

        /*--------------------------------------------------------------------------------*/
        //Checking Product's id
        //Specification: Integer number
        public string checkOrderDetailProductId(string id, bool? checkOrderDetail)
        {
            validation = new ValidationData();
            string error = validation.CheckNumber("Order Id", id, 1, int.MaxValue, true, true);
            if (checkOrderDetail == true && error != null)
               orderDetailErrors.OrderProductIdError  = error;
            return error;
        }

        /*--------------------------------------------------------------------------------*/
        //Checking Product's Unit Price
        //Specification: Decimal number

        public string checkOrderDetailProductUnitPrice(string unitPrice, bool? checkOrderDetail)
        {
            validation = new ValidationData();
            string error = validation.CheckNumber("Unit Price", unitPrice, 1, int.MaxValue, true, false);
            if (checkOrderDetail == true && error != null)
                orderDetailErrors.OrderUnitPriceError = error;
            return error;
        }

        /*--------------------------------------------------------------------------------*/
        //Checking Order Detail Quantity
        //Specification: Integer number
        public string checkOrderDetailQuantity(string quantity, bool? checkOrderDetail)
        {
            validation = new ValidationData();
            string error = validation.CheckNumber("Quantity", quantity, 1, int.MaxValue, true, true);
            if (checkOrderDetail == true && error != null)
                orderDetailErrors.OrderQuantityError = error;
            return error;
        }

        /*--------------------------------------------------------------------------------*/
        //Checking Order Detail Quantity
        //Specification: Integer number
        public string checkOrderDetailDiscount(string discount, bool? checkOrderDetail)
        {
            validation = new ValidationData();
            string error = validation.CheckNumber("Discount", discount, 1, int.MaxValue, true, false);
            if (checkOrderDetail == true && error != null)
                orderDetailErrors.OrderDiscountError = error;
            return error;
        }

        /*--------------------------------------------------------------------------------*/
        // Order Overall
        public OrderDetailErrors checkOrderDetail(OrderDetail orderDetail)
        {
            orderDetailErrors = null;
            orderDetailErrors = new OrderDetailErrors();
            checkOrderDetailOrderId(Convert.ToString(orderDetail.OrderId), true);
            checkOrderDetailProductId(Convert.ToString(orderDetail.ProductId), true);
            checkOrderDetailProductUnitPrice(Convert.ToString(orderDetail.UnitPrice), true);
            checkOrderDetailQuantity(Convert.ToString(orderDetail.Quantity), true);
            checkOrderDetailDiscount(Convert.ToString(orderDetail.Discount), true);            
            if (memberErrors.isEmpty())
                memberErrors = null;
            return orderDetailErrors;
        }

        #endregion
    }
}
