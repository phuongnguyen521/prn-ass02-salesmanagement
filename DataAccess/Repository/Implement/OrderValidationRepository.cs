using BusinessObject.Object;
using DataAccess.Errors;
using DataAccess.Validation;
using System;

namespace DataAccess.Repository
{
    public class OrderValidationRepository : IOrderValidationRepository
    {
        #region Order
        public OrderErrors checkOrder(Order order)
        => OrderValidation.Instance.checkOrder(order);

        public string checkOrderDate(string requiredDate, bool? checkOrder)
        => OrderValidation.Instance.checkOrderDate(requiredDate,checkOrder);

        public OrderErrors checkOrderDate(Order order)
        => OrderValidation.Instance.checkOrderDate(order);

        public string checkOrderFreight(string freight, bool? checkOrder)
        => OrderValidation.Instance.checkOrderFreight(freight, checkOrder);

        public string checkOrderMemberId(string id, bool? checkUser)
        => OrderValidation.Instance.checkOrderMemberId(id, checkUser);

        public string checkOrderRequiredDate(string requiredDate, bool? checkOrder)
        => OrderValidation.Instance.checkOrderRequiredDate(requiredDate, checkOrder);

        public string checkOrderShippedDate(string shippedDate, bool? checkOrder)
        => OrderValidation.Instance.checkOrderShippedDate(shippedDate, checkOrder);
        #endregion

        #region Order Detail
        public string checkOrderDetailDiscount(string discount, bool? checkOrderDetail)
        => OrderValidation.Instance.checkOrderDetailDiscount(discount, checkOrderDetail);

        public string checkOrderDetailOrderId(string id, bool? checkOrderDetail)
        => OrderValidation.Instance.checkOrderDetailOrderId(id, checkOrderDetail);

        public string checkOrderDetailProductId(string id, bool? checkOrderDetail)
        => OrderValidation.Instance.checkOrderDetailProductId(id, checkOrderDetail);

        public string checkOrderDetailProductUnitPrice(string unitPrice, bool? checkOrderDetail)
        => OrderValidation.Instance.checkOrderDetailProductUnitPrice(unitPrice,checkOrderDetail);

        public string checkOrderDetailQuantity(string quantity, bool? checkOrderDetail)
        => OrderValidation.Instance.checkOrderDetailQuantity(quantity,checkOrderDetail);
        public OrderDetailErrors checkOrderDetail(OrderDetail orderDetail)
        => OrderValidation.Instance.checkOrderDetail(orderDetail);
        #endregion
    }
}
