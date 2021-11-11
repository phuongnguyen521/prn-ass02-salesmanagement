using AutoMapper;
using BusinessObject.Object;
using DataAccess.Errors;
using DataAccess.Repository;
using SaleFormsApp.Mappers;
using System;
using System.Windows.Forms;

namespace SaleFormsApp
{
    public partial class frmProductDetail : Form
    {
        #region Initialized Objects
        public bool CreateOrUpdate { get; set; }
        public ProductDto product { get; set; }
        private IMapper mapper = null;
        private ProductErrors productErrors = null;
        private IProductValidationRepository Validation = new ProductValidationRepository();
        public IProductRepository productRepository { get; set; } = new ProductRepository();
        private IMemberValidationRepository validation = null;
        public frmProductDetail()
        {
            InitializeComponent();
            var config = new MapperConfiguration(cfg =>
                {
                    cfg.AddProfile(new MappingProfile());
                });
            mapper = config.CreateMapper();
        }
        #endregion

        #region Events
        private void frmProductDetail_Load(object sender, EventArgs e)
        {
            if (CreateOrUpdate == false) //Update
            {
                txtProductID.Text = Convert.ToString(product.ProductId);
                txtProductName.Text = product.ProductName;
                cbCategoryID.SelectedIndex = cbCategoryID.FindStringExact(Convert.ToString(product.CategoryId));
                nupWeight.Value = decimal.Parse(product.Weight);
                nupUnitPrice.Value = product.UnitPrice;
                nupUnitInStock.Value = product.UnitsInStock;
            } else
                cbCategoryID.SelectedIndex = cbCategoryID.FindStringExact("None");
        }
        private void checkDuplicatedIDorEmpty(string productID)
        {
            Product product = productRepository.GetProductByID(Convert.ToInt32(productID));
            try
            {
                int ID = Convert.ToInt32(productID);
                if (String.IsNullOrEmpty(productID))
                {
                    productErrors = new ProductErrors();
                    productErrors.ProductIdError = "Product ID is empty!";
                }
                else if (product != null)
                {
                    productErrors = new ProductErrors();
                    productErrors.ProductIdError = "Product ID is duplicated!";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Product ID is empty", "check Duplicated or Empty ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void checkRedudantWhiteSpace()
        {
            validation = new MemberValidationRepository();
            txtProductName.Text = validation.checkRedundantWhiteSpace(txtProductName.Text);
        }
        private void btnCancel_Click(object sender, EventArgs e)
        => Close();
        private void btnSave_Click(object sender, EventArgs e)
        {
            string messsage = CreateOrUpdate == true ? "Add new Product" : "Update product";
            checkDuplicatedIDorEmpty(txtProductID.Text);
            try
            {
                bool result = productErrors == null;
                if (result)
                {
                    checkRedudantWhiteSpace();
                    ProductDto product = new ProductDto
                    {
                        ProductId = Int32.Parse(txtProductID.Text),
                        CategoryId = Int32.Parse(cbCategoryID.SelectedItem.ToString()),
                        ProductName = txtProductName.Text,
                        UnitPrice = nupUnitPrice.Value,
                        UnitsInStock = Convert.ToInt32(nupUnitInStock.Value),
                        Weight = Convert.ToString(nupWeight.Value)
                    };
                    Product TempProduct = mapper.Map<ProductDto, Product>(product);
                    productErrors = Validation.checkProduct(TempProduct);
                    result = productErrors == null;
                    if (result)
                    {
                        //Insert
                        if (CreateOrUpdate)
                            productRepository.InsertProduct(TempProduct);
                        // Update 
                        else
                            productRepository.UpdateProduct(TempProduct);
                        MessageBox.Show($"{messsage} Successfully!", messsage, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show(productErrors.Display(), messsage, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                    MessageBox.Show(productErrors.Display(), messsage, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, messsage, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

        #region Mouse Hover
        private void txtProductID_MouseHover(object sender, EventArgs e)
        => statusProductDetail.Text = "Product ID shall be number";

        private void txtProductName_MouseHover(object sender, EventArgs e)
        => statusProductDetail.Text = "Product Name shall be only characters";

        private void nupWeight_Click(object sender, EventArgs e)
        => statusProductDetail.Text = "Weight shall be larger than 0";

        private void cbCategoryID_Click(object sender, EventArgs e)
        => statusProductDetail.Text = "Category ID must be choosen";

        private void nupUnitPrice_Click(object sender, EventArgs e)
        => statusProductDetail.Text = "Price shall be larger than 0";

        private void nupUnitInStock_Click(object sender, EventArgs e)
        => statusProductDetail.Text = "Unit In Stock shall be larger than 0";
        private void frmProductDetail_MouseHover(object sender, EventArgs e)
        => statusProductDetail.Text = String.Empty;
        #endregion
    }
}
