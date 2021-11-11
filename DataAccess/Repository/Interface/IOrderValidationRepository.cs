using BusinessObject.Object;
using DataAccess.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IOrderValidationRepository
    {
        #region Order
        public string checkOrderMemberId(string id, bool? checkUser);
        public string checkOrderDate(string requiredDate, bool? checkOrder);
        public string checkOrderRequiredDate(string requiredDate, bool? checkOrder);

        public string checkOrderShippedDate(string shippedDate, bool? checkOrder);
        public string checkOrderFreight(string freight, bool? checkOrder);
        public OrderErrors checkOrder(Order order);
        public OrderErrors checkOrderDate(Order order);
        #endregion

        #region Order Detail
        public string checkOrderDetailOrderId(string id, bool? checkOrderDetail);
        public string checkOrderDetailProductId(string id, bool? checkOrderDetail);
        public string checkOrderDetailProductUnitPrice(string unitPrice, bool? checkOrderDetail);
        public string checkOrderDetailQuantity(string quantity, bool? checkOrderDetail);
        public string checkOrderDetailDiscount(string discount, bool? checkOrderDetail);
        public OrderDetailErrors checkOrderDetail(OrderDetail orderDetail);
        #endregion
    }
}
