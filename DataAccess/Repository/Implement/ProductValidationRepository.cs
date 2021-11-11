using BusinessObject.Object;
using DataAccess.Errors;
using DataAccess.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class ProductValidationRepository : IProductValidationRepository
    {
        public ProductErrors checkFilterUnit(string from, string to, bool IsInterger)
        => ProductValidation.Instance.checkFilterUnit(from,to,IsInterger);

        public ProductErrors checkFilterUnitPrice(string from, string to)
        => ProductValidation.Instance.checkFilterUnitPrice(from,to);

        public ProductErrors checkFilterUnitsInStock(string from, string to)
        => ProductValidation.Instance.checkFilterUnitsInStock(from,to);

        public ProductErrors checkProduct(Product product)
        => ProductValidation.Instance.checkProduct(product);

        public string checkProductCategoryId(string categoryId, bool? checkProduct)
        => ProductValidation.Instance.checkProductCategoryId(categoryId,checkProduct);

        public string checkProductId(string id, bool? checkProduct)
        => ProductValidation.Instance.checkProductId(id, checkProduct);

        public ProductErrors checkProductIDAndName(Product product)
        => ProductValidation.Instance.checkProductIDAndName(product);

        public string checkProductName(string productName, bool? checkProduct)
        => ProductValidation.Instance.checkProductName(productName,checkProduct);

        public string checkProductUnitPrice(string unitPrice, bool? checkProduct)
        => ProductValidation.Instance.checkProductUnitPrice(unitPrice, checkProduct);

        public string checkProductUnitsInStock(string unitInStock, bool? checkProduct)
        => ProductValidation.Instance.checkProductUnitsInStock(unitInStock, checkProduct);

        public string checkProductWeight(string weight, bool? checkProduct)
        => ProductValidation.Instance.checkProductWeight(weight, checkProduct);
    }
}
