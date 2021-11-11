using System.ComponentModel;

namespace SaleFormsApp.Mappers
{
    public class OrderDetailDto
    {
        [DisplayName("No")]
        public int No { get; set; }
        [DisplayName("Order ID")]
        public int OrderId { get; set; }
        [DisplayName("Product ID")]
        public int ProductId { get; set; }
        [DisplayName("Product Name")]
        public string ProductName { get; set; }
        [DisplayName("Unit Price")]
        public decimal UnitPrice { get; set; }
        [DisplayName("Quantity")]
        public int Quantity { get; set; }
        [DisplayName("Discount")]
        public double Discount { get; set; }
    }
}
