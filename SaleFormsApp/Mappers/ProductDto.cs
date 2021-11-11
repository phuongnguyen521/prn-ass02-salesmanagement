using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace SaleFormsApp.Mappers
{
    public class ProductDto
    {
        [DisplayName("Product ID")]
        public int ProductId { get; set; }

        [DisplayName("Category ID")]
        public int CategoryId { get; set; }

        [DisplayName("Product Name")]
        public string ProductName { get; set; }

        [DisplayName("Weight")]
        public string Weight { get; set; }

        [DisplayName("Unit Price")]
        public decimal UnitPrice { get; set; }

        [DisplayName("Units In Stock")]
        public int UnitsInStock { get; set; }
    }
}
