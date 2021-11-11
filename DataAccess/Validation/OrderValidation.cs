using BusinessObject.Object;
using DataAccess.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DataAccess.Validation
{
    public class OrderValidation
    {
        #region Initialized Parameter
        private ValidationData validation = null;
        private static OrderValidation instance = null;
        private OrderDetailErrors orderDetailErrors = null;
        private OrderErrors orderErrors = null;
        private static readonly object instanceLock = new object();
        private OrderValidation() { }
        public static OrderValidation Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new OrderValidation();
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

        #region Order
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
            checkOrderId(Convert.ToString(order.OrderId), true);
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

        public OrderErrors checkOrderDate(Order order)
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
                orderDetailErrors.OrderProductIdError = error;
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
            if (orderDetailErrors.isEmpty())
                orderDetailErrors = null;
            return orderDetailErrors;
        }

        #endregion
    }
}
