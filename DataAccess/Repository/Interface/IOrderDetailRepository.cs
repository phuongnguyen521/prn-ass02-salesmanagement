using BusinessObject.Object;
using System.Collections.Generic;

namespace DataAccess.Repository
{
    public interface IOrderDetailRepository
    {
        public IEnumerable<OrderDetail> GetOrderDetailListByOrderID(int orderId);
        public IEnumerable<OrderDetail> GetOrderDetailListByProductID(int productId);
        void AddOrderDetail(OrderDetail order);
        void DeleteOrderDetailByProductID(int productID);
        void DeleteOrderDetailByOrderID(int orderId);
        decimal GetTotalOrder(Order order);
    }
}
