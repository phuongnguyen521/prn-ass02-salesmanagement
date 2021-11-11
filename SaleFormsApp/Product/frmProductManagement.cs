using AutoMapper;
using BusinessObject.Object;
using DataAccess.Errors;
using DataAccess.Repository;
using SaleFormsApp.Mappers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace SaleFormsApp
{
    public partial class frmProductManagement : Form
    {
        #region Initialized Objects
        public MemberDto loginUser { get; set; }
        private IMapper mapper = null;
        IProductRepository productRepository = new ProductRepository();
        private BindingSource source = null;
        private IProductValidationRepository Validation = new ProductValidationRepository();
        private ProductErrors productErrors = null;
        public bool fromProductDetail { get; set; } = false;
        #endregion
        public frmProductManagement()
        {
            InitializeComponent();
            var config = new MapperConfiguration(
                    cfg =>
                    {
                        cfg.AddProfile(new MappingProfile());
                    });
            mapper = config.CreateMapper();
        }

        #region Event
        public void LoadProductList(bool search = false, IEnumerable<Product> SearchResult = null)
        {
            source = null;
            source = new BindingSource();
            var list = productRepository.GetProduct().ToList().OrderBy(temp => temp.ProductId);
            IEnumerable<ProductDto> ProductList = null;
            try
            {
                if (search)
                    ProductList = SearchResult.Select(
                        temp => mapper.Map<Product, ProductDto>(temp));
                else
                    ProductList = list.Select(
                        temp => mapper.Map<Product, ProductDto>(temp));
                if (ProductList != null)
                {
                    source.DataSource = ProductList;
                    txtProductID.DataBindings.Clear();
                    txtCategoryID.DataBindings.Clear();
                    txtProductName.DataBindings.Clear();
                    txtWeight.DataBindings.Clear();
                    txtUnitsInStock.DataBindings.Clear();
                    txtUnitPrice.DataBindings.Clear();
                    if (!search)
                    {
                        txtSearchProductID.Text = String.Empty;
                        txtSearchProductName.Text = String.Empty;
                        txtTo.Text = String.Empty;
                        txtFrom.Text = String.Empty;
                    }
                   
                    txtProductID.DataBindings.Add("Text", source, "ProductID");
                    txtCategoryID.DataBindings.Add("Text", source, "CategoryID");
                    txtProductName.DataBindings.Add("Text", source, "ProductName");
                    txtWeight.DataBindings.Add("Text", source, "Weight");
                    txtUnitsInStock.DataBindings.Add("Text", source, "UnitsInStock");
                    txtUnitPrice.DataBindings.Add("Text", source, "UnitPrice");

                    dgv_Product.DataSource = null;
                    dgv_Product.DataSource = source;
                    btnDelete.Enabled = true;
                    gbSearch.Enabled = true;
                    gbFilter.Enabled = true;

                }
                else
                {
                    btnDelete.Enabled = false;
                    gbSearch.Enabled = false;
                    gbFilter.Enabled = false;
                    if (search)
                    {
                        MessageBox.Show("There is no result matching with search", "Load searching product list");
                        LoadProductList();
                    }
                    else
                    {
                        MessageBox.Show("Product list is empty", "Load product list");
                        ClearText();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load Product List");
            }
        }
        private void ClearText()
        {
            txtProductID.Text = String.Empty;
            txtCategoryID.Text = String.Empty;
            txtProductName.Text = String.Empty;
            txtWeight.Text = String.Empty;
            txtUnitsInStock.Text = String.Empty;
            txtUnitPrice.Text = String.Empty;
            txtSearchProductID.Text = String.Empty;
            txtSearchProductName.Text = String.Empty;
        }

        private ProductDto GetProduct()
        {
            ProductDto product = null;
            try
            {
                product = new ProductDto
                {
                    ProductId = Int32.Parse(txtProductID.Text),
                    CategoryId = Int32.Parse(txtCategoryID.Text),
                    ProductName = txtProductName.Text,
                    UnitPrice = decimal.Parse(txtUnitPrice.Text),
                    UnitsInStock = int.Parse(txtUnitsInStock.Text),
                    Weight = txtWeight.Text
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Get Product");
            }
            return product;
        }

        private void frmProductManagement_Load(object sender, EventArgs e)
        {
            if (fromProductDetail)
                LoadProductList();
            else
            {
                txtProductID.Enabled = false;
                txtCategoryID.Enabled = false;
                txtProductName.Enabled = false;
                txtWeight.Enabled = false;
                txtUnitsInStock.Enabled = false;
                txtUnitPrice.Enabled = false;
                gbSearch.Enabled = false;
                gbFilter.Enabled = false;
                dgv_Product.CellDoubleClick += dgv_Product_CellDoubleClick;
            }
        }
        private void btnLoad_Click(object sender, EventArgs e)
            => LoadProductList();

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string ID = txtSearchProductID.Text;
            string Name = txtSearchProductName.Text;
            bool SearchID = String.IsNullOrEmpty(ID);
            bool SearchName = String.IsNullOrEmpty(Name);
            if (SearchID == true && SearchName == true)
                MessageBox.Show("ID and Name are empty", "Search ID and Name");
            else
            {
                if (SearchID == false && SearchName == true)
                {
                    Product product = productRepository.GetProductByID(Int32.Parse(ID));
                    if (product != null)
                    {
                        IEnumerable<Product> SearchResult = new List<Product>() { product };
                        LoadProductList(true, SearchResult);
                    }
                    else
                        MessageBox.Show("There is no result matching the search ID","Search ID");
                } else if (SearchID == true && SearchName == false)
                {
                    IEnumerable<Product> SearchResult = productRepository.SearchProductByProductName(Name);
                    if (SearchResult != null)
                        LoadProductList(true, SearchResult);
                    else
                        MessageBox.Show("There is no result matching the search Name", "Search Name");
                } else
                {
                    IEnumerable<Product> SearchResult = productRepository.SearchProductByNameAndID(Name, ID);
                    if (SearchResult != null)
                        LoadProductList(true, SearchResult);
                    else
                        MessageBox.Show("There is no result matching the search ID and Name", "Search ID and Name");
                }
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            try
            {
                productErrors = null;
                productErrors = Validation.checkFilterUnitPrice(txtFrom.Text, txtTo.Text);
                if (productErrors == null)
                {
                    decimal From = decimal.Parse(txtFrom.Text);
                    decimal To = decimal.Parse(txtTo.Text);
                    if (rbUnitPrice.Checked)
                    {
                        IEnumerable<Product> SearchResult = productRepository.SearchProductByUnitPrice(From, To);
                        if (SearchResult != null)
                            LoadProductList(true, SearchResult);
                        else
                            MessageBox.Show("There is no result matching with the Filter Unit Price", "Filter Unit Price");
                    }
                    else if (rbUnitsInStock.Checked)
                    {
                        IEnumerable<Product> SearchResult = productRepository.SearchProductByUnitInStock(Int32.Parse(txtFrom.Text), (Int32.Parse(txtTo.Text)));
                        if (SearchResult != null)
                            LoadProductList(true, SearchResult);
                        else
                            MessageBox.Show("There is no result matching with the Filter Units In Stock", "Filter Units In Stock");
                    }
                }
                else
                    MessageBox.Show(productErrors.Display(), "Filter Unit Price");
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Filter");
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            frmProductDetail productDetail = new frmProductDetail
            {
                product = GetProduct(),
                Text = "Create a Product",
                productRepository = productRepository,
                CreateOrUpdate = true //Insert: true, Update: false
            };
            if (productDetail.ShowDialog() == DialogResult.Cancel)
                LoadProductList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ProductDto tempProduct = GetProduct();
            Product product = productRepository.checkDeleteProduct(tempProduct.ProductId);
            try
            {
                if (product == null)
                {
                    DialogResult result = MessageBox.Show($"Do you want to delete {tempProduct.ProductId} - " +
                $"{tempProduct.ProductName}?", "Delete Product", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    // Delete
                    if (result == DialogResult.Yes)
                    {
                        productRepository.DeleteProduct(tempProduct.ProductId);
                        LoadProductList();
                    }
                } else
                    MessageBox.Show("Cannot delete this product!", "Delete Product");
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete Product");
            }
        }

        private void dgv_Product_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmProductDetail productDetail = new frmProductDetail
            {
                product = GetProduct(),
                Text = "Update a Product",
                productRepository = productRepository,
                CreateOrUpdate = false //Insert: true, Update: false
            };
            frmMain demo = new frmMain();
            this.Hide();
            demo.openChildForm(productDetail);
        }
        #endregion
    }
}
