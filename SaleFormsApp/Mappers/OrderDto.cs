using BusinessObject.Object;
using System;
using System.ComponentModel;

namespace SaleFormsApp.Mappers
{
    public class OrderDto
    {
        [DisplayName("Order ID")]
        public int OrderId { get; set; }
        [DisplayName("Member ID")]
        public int MemberID { get; set; }
        [DisplayName("Order Date")]
        public DateTime OrderDate { get; set; }
        [DisplayName("Required Date")]
        public DateTime RequiredDate { get; set; }
        [DisplayName("Shipped Date")]
        public DateTime ShippedDate { get; set; }
        [DisplayName("Freight")]
        public decimal? Freight { get; set; }
        [DisplayName("Order Total")]
        public decimal OrderTotal { get; set; }
    }
}
