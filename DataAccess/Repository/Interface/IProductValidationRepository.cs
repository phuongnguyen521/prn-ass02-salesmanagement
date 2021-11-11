using BusinessObject.Object;
using DataAccess.Errors;

namespace DataAccess.Repository
{
    public interface IProductValidationRepository
    {
        #region product
        public string checkProductId(string id, bool? checkProduct);
        public string checkProductCategoryId(string categoryId, bool? checkProduct);
        public string checkProductName(string productName, bool? checkProduct);
        public string checkProductWeight(string weight, bool? checkProduct);
        public string checkProductUnitPrice(string unitPrice, bool? checkProduct);
        public string checkProductUnitsInStock(string unitInStock, bool? checkProduct);
        public ProductErrors checkProduct(Product product);
        public ProductErrors checkProductIDAndName(Product product);
        public ProductErrors checkFilterUnitsInStock(string from, string to);
        public ProductErrors checkFilterUnitPrice(string from, string to);
        public ProductErrors checkFilterUnit(string from, string to, bool IsInterger);
        #endregion
    }
}
