using BusinessObject.Object;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess
{
    public class ProductDAO
    {
        #region Intialized Objects
        // Using Singleton Pattern
        private static ProductDAO instance = null;
        private static readonly object instanceLock = new object();
        private ProductDAO() { }
        public static ProductDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new ProductDAO();
                    }
                }
                return instance;
            }
        }
        #endregion

        #region Function
        public IEnumerable<Product> GetProductList()
        {
            IEnumerable<Product> products = null;
            try
            {
                using var context = new SaleManagementContext();
                products = context.Products.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return products;
        }

        public IEnumerable<Product> GetProductListForOrder()
        {
            IEnumerable<Product> products = null;
            try
            {
                using var context = new SaleManagementContext();
                products = context.Products.ToList();
                if (products != null)
                    products = products.Where(temp => temp.UnitsInStock > 0);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return products;
        }

        public Product GetProductByID(int ProductID)
        {
            Product product = null;
            try
            {
                using var context = new SaleManagementContext();
                product = context.Products.SingleOrDefault(temp => temp.ProductId == ProductID);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return product;
        }

        public void UpdateProductOrder(int productID, int unitsInStock)
        {
            try
            {
                Product product = GetProductByID(productID);
                if (product != null)
                {
                    product.UnitsInStock += unitsInStock;
                    UpdateProduct(product);
                } else
                    throw new Exception("Product does not exist");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public string GetProductNameByID(int ProductID)
        {
            Product product = null;
            String ProductName = null;
            try
            {
                using var context = new SaleManagementContext();
                product = context.Products.SingleOrDefault(temp => temp.ProductId == ProductID);
                if (product != null)
                    ProductName = product.ProductName;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return ProductName;
        }

        public void AddProduct(Product product)
        {
            try
            {
                Product _product = GetProductByID(product.ProductId);
                if (_product == null)
                {
                    using var context = new SaleManagementContext();
                    context.Products.Add(product);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Product exists!");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void UpdateProduct(Product product)
        {
            try
            {
                Product _product = GetProductByID(product.ProductId);
                if (_product != null)
                {
                    using var context = new SaleManagementContext();
                    context.Products.Update(product);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Product does not exist");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void DeleteProduct(int ProductID)
        {
            try
            {
                Product product = GetProductByID(ProductID);
                if (product != null)
                {
                    using var context = new SaleManagementContext();
                    context.Products.Remove(product);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Product does not exist");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion

        #region Consideration
        public Product checkDeleteProduct(int productID)
        {
            Product product = null;
            try
            {
                using var context = new SaleManagementContext();
                IQueryable<Product> products = context.Products.Include(c => c.OrderDetails);
                products = products.Where(temp => temp.OrderDetails.Count > 0);
                product = products.SingleOrDefault(temp => temp.ProductId == productID);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return product;
        }

        public IEnumerable<Product> SearchProductByProductName(string productName)
        {
            IEnumerable<Product> searchResult = null;
            try
            {
                using var context = new SaleManagementContext();
                List <Product> list = context.Products.ToList();
                List<Product> tempList = new List<Product>();
                foreach(var product in list)
                {
                    if (product.ProductName.ToLower().Trim().Contains(productName.ToLower().Trim()))
                        tempList.Add(product);
                }
                if (tempList.Any())
                    searchResult = tempList;
            }catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return searchResult;
        }

        public IEnumerable<Product> SearchProductByUnitPrice(decimal FromUnitPrice, decimal ToUnitPrice)
        {
            IEnumerable<Product> searchResult = null;
            try
            {
                if (FromUnitPrice > 0 && ToUnitPrice > 0)
                {
                    using var context = new SaleManagementContext();
                    List<Product> list = context.Products.ToList();
                    List<Product> tempList = new List<Product>();
                    foreach(var product in list)
                    {
                        if (product.UnitPrice >= FromUnitPrice && product.UnitPrice <= ToUnitPrice)
                            tempList.Add(product);
                    }
                    if (tempList.Any())
                        searchResult = tempList;
                } else
                {
                    throw new Exception("Unit Price shall be larger than 0");
                }
            } catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return searchResult;
        }

        public IEnumerable<Product> SearchProductByUnitInStock(int FromUnitInStock, int ToUnitInStock)
        {
            IEnumerable<Product> searchResult = null;
            try
            {
                if (FromUnitInStock > 0 && ToUnitInStock > 0)
                {
                    using var context = new SaleManagementContext();
                    List<Product> list = context.Products.ToList();
                    List<Product> tempList = new List<Product>();
                    foreach (var product in list)
                    {
                        if (product.UnitsInStock >= FromUnitInStock && product.UnitsInStock <= ToUnitInStock)
                            tempList.Add(product);
                    }
                    if (tempList.Any())
                        searchResult = tempList;
                }
                else
                {
                    throw new Exception("Unit In Stock shall be larger than 0");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return searchResult;
        }

        public IEnumerable<Product> SearchProductByNameAndID(string productName, string id)
        {
            IEnumerable<Product> searchResult = null;
            int ProductId = Int32.Parse(id);
            try
            {
                using var context = new SaleManagementContext();
                List<Product> list = context.Products.ToList();
                List<Product> TempList = new List<Product>();
                foreach (var product in list)
                {
                    if (product.ProductId == ProductId 
                        && product.ProductName.ToLower().Trim()
                        .Contains(productName.Trim().ToLower()))
                        TempList.Add(product);
                }
                if (TempList.Any())
                    searchResult = TempList;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return searchResult;
        }
        #endregion
    }
}
