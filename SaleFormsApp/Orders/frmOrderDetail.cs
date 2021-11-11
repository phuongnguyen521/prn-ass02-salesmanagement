using AutoMapper;
using BusinessObject.Object;
using DataAccess.Errors;
using DataAccess.Repository;
using SaleFormsApp.Mappers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaleFormsApp
{
    public partial class frmOrderDetail : Form
    {
        #region Initialized Objects
        private IOrderRepository orderRepository = new OrderRepository();
        private IProductRepository productRepository = new ProductRepository();
        private IOrderDetailRepository orderDetailRepository = new OrderDetailRepository();
        private IMemberRepository memberRepository = new MemberRepository();
        public bool CreateOrUpdate { get; set; } //Insert: true, Update: false
        public Order UpdateOrder { get; set; }
        private List<Product> productList { get; set; }
        private List<OrderDetailDto> orderDetailList = null;
        IMapper mapper = null;
        private IOrderValidationRepository Validation = new OrderValidationRepository();
        DataGridViewCellEventArgs EventOfdvgOrderDetailList = null;
        private OrderErrors orderErrors = null;
        private Order order = null;
        private DateTime orderDate = DateTime.Now;
        private int unitsInStock = 0;
        public frmOrderDetail()
        {
            InitializeComponent();
            var config = new MapperConfiguration(cfg => {
                cfg.AddProfile(new MappingProfile());
            });
            mapper = config.CreateMapper();
        }

        #endregion

        #region Order
        private void frmOrderDetail_Load(object sender, EventArgs e)
        {
            UpdateOrderProperties();
            LoadOrders();
            LoadProducts();
        }
        private void UpdateOrderProperties()
        {
            this.Size = new Size { Width = 449, Height = 477 };
            //Insert
            if (CreateOrUpdate)
            {
                this.Size = new Size { Width = 449, Height = 477 };
                pnProductID.Enabled = false;
                pnUnitPrice.Enabled = false;
                pnTotalOrder.Enabled = false;
                pnOrderDetailInformation1.Enabled = true;
                pnOrderDetailInformation2.Enabled = true;
                flpOrderDetailButtons.Visible = true;
            }
            // Update
            else
            {
                pnOrderID.Enabled = false;
                pnMemberID.Enabled = false;
                pnFreight.Enabled = false;
                pnOrderDetailInformation1.Enabled = false;
                pnOrderDetailInformation2.Enabled = false;
                flpOrderDetailButtons.Visible = false;
                txtOrderID.Text = Convert.ToString(UpdateOrder.OrderId);
                cboMemberID.SelectedItem = cboMemberID.FindStringExact(Convert.ToString(UpdateOrder.MemberId));
                dtpRequiredDate.Value = Convert.ToDateTime(UpdateOrder.RequiredDate);
                dtpShippingDate.Value = Convert.ToDateTime(UpdateOrder.ShippedDate);
                nupFreight.Value = Convert.ToDecimal(UpdateOrder.Freight);
            }
        }
        private void checkDuplicatedOrderID(int orderID)
        {
            Order order = orderRepository.GetOrdersByOrderID(orderID);
            if (order != null)
            {
                orderErrors = new OrderErrors();
                orderErrors.OrderIdError = "Order ID is duplicated";
            }
        }
        private void InsertOrder(String message)
        {
            try
            {
                checkDuplicatedOrderID(Convert.ToInt32(txtOrderID.Text));
                if (orderErrors != null && orderErrors.isEmpty() == false)
                    MessageBox.Show(orderErrors.Display(), message, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    orderErrors = new OrderErrors();
                    Order tempOrder = new Order
                    {
                        OrderId = Convert.ToInt32(txtOrderID.Text),
                        MemberId = Convert.ToInt32(cboMemberID.SelectedItem.ToString()),
                        OrderDate = orderDate,
                        RequiredDate = dtpRequiredDate.Value,
                        ShippedDate = dtpShippingDate.Value,
                        Freight = nupFreight.Value > 0 ? nupFreight.Value : null
                    };
                    orderErrors = Validation.checkOrder(tempOrder);
                    bool result = orderErrors == null;
                    if (result)
                    {
                        order = new Order();
                        order = tempOrder;
                        this.Size = new Size { Width = 1301, Height = 653 };
                        gbOrderInformation.Enabled = false;
                        gbOrderButton.Visible = false;
                        gbOrderDetailInformation.Enabled = true;
                        btnRemove.Enabled = orderDetailList != null;
                        btnCheckOut.Enabled = orderDetailList != null;
                    }
                    else
                        MessageBox.Show(orderErrors.Display(), message, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, message);
            }
        }
        private void UpdateExistentOrder (String message)
        {
            try
            {
                orderErrors = new OrderErrors();
                Order tempOrder = new Order
                {
                    OrderDate = UpdateOrder.OrderDate,
                    RequiredDate = dtpRequiredDate.Value,
                    ShippedDate = dtpShippingDate.Value
                };
                orderErrors = Validation.checkOrderDate(tempOrder);
                bool result = orderErrors == null;
                if (result)
                {
                    tempOrder.OrderId = UpdateOrder.OrderId;
                    tempOrder.MemberId = UpdateOrder.MemberId;
                    tempOrder.Freight = UpdateOrder.Freight;
                    orderRepository.UpdateOrder(tempOrder);
                    MessageBox.Show("Update Order Successfully!", message);
                }
                else
                    MessageBox.Show(orderErrors.Display(), message, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, message);
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            orderErrors = null;
            orderErrors = new OrderErrors();
            String message = CreateOrUpdate == true ? "Insert an order" : "Update an order";
            //Insert
            if (CreateOrUpdate)
                InsertOrder(message);
            //Update
            else
                UpdateExistentOrder(message);
            
        }
        private void btnClose_Click(object sender, EventArgs e)
        => Close();
        private void LoadProducts()
        {
            productList = null;
            try
            {
                productList = productRepository.GetProductListForOrder().ToList();
                if (productList != null)
                {
                    IEnumerable<String> productNamesList = productList
                        .Select(temp => temp.ProductName)
                        .OrderBy(temp => temp);
                    BindingSource productNameSource = new BindingSource();
                    productNameSource.DataSource = productNamesList;
                    cboProductName.DataSource = null;
                    cboProductName.DataSource = productNameSource;
                } else
                    MessageBox.Show("", "Load Product List to Order Detail");
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Load Product List to Order Detail");
            }
        }
        private void LoadOrders()
        {
            IEnumerable<Member> members = memberRepository.GetMember();
            try
            {
                if (members != null)
                {
                    IEnumerable<int> memberIDs = members
                        .Select(temp => temp.MemberId)
                        .OrderBy(temp => temp);
                    BindingSource memberIDsSource = new BindingSource();
                    memberIDsSource.DataSource = memberIDs;
                    cboMemberID.DataSource = null;
                    cboMemberID.DataSource = memberIDsSource;
                }
                else
                    MessageBox.Show("There is no member", "Load Order Properties");
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Load Order Properties");
            }
        }
        #endregion

        #region Order Detail
        private void GetOrderDetail(ref int NoOrderDetail, ref OrderDetailDto orderDetail)
        {
            orderDetail = null;
            int index = 0;
            if (EventOfdvgOrderDetailList != null)
            {
                try
                {
                    index = EventOfdvgOrderDetailList.RowIndex;
                    NoOrderDetail = index;
                    DataGridViewRow selectRow = dgv_OrderDetail.Rows[index];
                    orderDetail = new OrderDetailDto
                    {
                        No = Convert.ToInt32(selectRow.Cells[0].Value.ToString()),
                        OrderId = Convert.ToInt32(txtOrderID.Text),
                        ProductId = Convert.ToInt32(selectRow.Cells[2].Value.ToString()),
                        UnitPrice = Convert.ToDecimal(selectRow.Cells[3].Value.ToString()),
                        Quantity = Convert.ToInt32(selectRow.Cells[4].Value.ToString()),
                        Discount = Convert.ToDouble(selectRow.Cells[5].Value.ToString())
                    };
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Get Order Detail");
                }
            }
        }
        private void LoadOrderDetail()
        {
            try
            {
                bool result = orderDetailList.Count > 0;
                if (result)
                {
                    DataTable table = setColumnNameOfTable();
                    foreach (var orderDetails in orderDetailList)
                        table.Rows.Add(
                            orderDetails.No,
                            orderDetails.OrderId,
                            orderDetails.ProductId,
                            orderDetails.UnitPrice,
                            orderDetails.Quantity,
                            orderDetails.Discount);
                    dgv_OrderDetail.DataSource = null;
                    dgv_OrderDetail.DataSource = table;
                }
                else
                dgv_OrderDetail.DataSource = null;
                btnRemove.Enabled = result;
                btnCheckOut.Enabled = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load Order Detail");
            }
        }
        private decimal DisplayTotalOrder()
        {
            decimal total = 0;
            OrderDetailDto orderDetail = null;
            int NoOrderDetail = 0;
            if (EventOfdvgOrderDetailList != null)
            {
                GetOrderDetail(ref NoOrderDetail, ref orderDetail);
                if (orderDetail != null)
                {
                    total = orderDetail.UnitPrice * orderDetail.Quantity * (1 - Convert.ToDecimal(orderDetail.Discount / 100));
                }
                else
                    MessageBox.Show("Cannot retrieve data order detail item");
            }
            Thread.Sleep(5000);
            return total;
        }
        private int CalculateLeftQuantity()
        {
            int quantity = 0;
            try
            {
                Thread.Sleep(6000);
                if (unitsInStock > 0)
                    quantity = unitsInStock - Convert.ToInt32(nupQuantity.Value);
                Thread.Sleep(1000);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Total Order Detail", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return quantity;
        }
        private async void dgv_OrderDetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            EventOfdvgOrderDetailList = e;
            bool result = dgv_OrderDetail.RowCount > 0;
            if (result)
            {
                Task<decimal> task = new Task<decimal>(DisplayTotalOrder);
                task.Start();
                decimal total = await task;
                txtTotalOrder.Text = Convert.ToString(total);
            }
            btnRemove.Enabled = result;
            btnCheckOut.Enabled = result;
        }

        private void cboProductName_SelectedIndexChanged(object sender, EventArgs e)
        {
            string productName = cboProductName.SelectedItem.ToString();
            if (String.IsNullOrEmpty(productName) == false 
                && String.IsNullOrEmpty(txtOrderID.Text) == false)
            {
                Product product = productList.SingleOrDefault(temp => temp.ProductName.Equals(productName));
                if (product != null)
                {
                    txtProductID.Text = Convert.ToString(product.ProductId);
                    txtUnitPrice.Text = Convert.ToString(Math.Round(product.UnitPrice, 2));
                    unitsInStock = product.UnitsInStock;
                    lbLeftQuantity.Text = "Left Quantity: " + Convert.ToString(unitsInStock);
                    nupQuantity.Maximum = unitsInStock;
                }
                else
                {
                    txtProductID.Text = String.Empty;
                    txtUnitPrice.Text = String.Empty;
                    unitsInStock = 0;
                    lbLeftQuantity.Text = String.Empty;
                    nupQuantity.Maximum = 100;
                }
            }
        }

        private async void nupQuantity_ValueChanged(object sender, EventArgs e)
        {
            Task<int> taskQuantity = new Task<int>(CalculateLeftQuantity);
            if (unitsInStock > 0)
            {
                taskQuantity.Start();
                int quantity = await taskQuantity;
                lbLeftQuantity.Text = "Left Quantity: " + Convert.ToString(quantity);
                if (nupQuantity.Value > 0)
                {
                    decimal total = 0;
                    if (nupDiscount.Value > 0 && nupQuantity.Value > 0)
                        total = Convert.ToDecimal(txtUnitPrice.Text) * nupQuantity.Value * (1 - nupDiscount.Value / 100);
                    else
                        total = Convert.ToDecimal(txtUnitPrice.Text) * nupQuantity.Value;
                    txtTotalOrder.Text = Convert.ToString(total);
                }
                else
                    txtTotalOrder.Text = String.Empty;
            } else
                lbLeftQuantity.Text = String.Empty;
        }

        private async void nupDiscount_ValueChanged(object sender, EventArgs e)
        {
            Task<decimal> task = new Task<decimal>(DisplayTotalOrder);
            if (nupQuantity.Value > 0 && nupDiscount.Value > 0)
            {
                task.Start();
                decimal total = await task;
                txtTotalOrder.Text = Convert.ToString(total);
            }
            else
                txtTotalOrder.Text = String.Empty;
        }

        public DataTable setColumnNameOfTable(DataTable table = null)
        {
            table = new DataTable();
            table.Columns.Add("No.", typeof(int));
            table.Columns.Add("Order ID", typeof(int));
            table.Columns.Add("ProductId", typeof(int));
            table.Columns.Add("Unit Price", typeof(decimal));
            table.Columns.Add("Quantity", typeof(int));
            table.Columns.Add("Discount", typeof(decimal));
            return table;
        }

        private void UpdateProductUnitsInStock(OrderDetail orderDetail = null, bool AddProduct = true)
        {
            try
            {
                if (orderDetail != null)
                {
                    foreach (var product in productList)
                    {
                        if (product.ProductId == orderDetail.ProductId)
                        {
                            if (AddProduct)
                                product.UnitsInStock -= orderDetail.Quantity;
                            else
                                product.UnitsInStock += orderDetail.Quantity;
                            break;
                        }
                    }
                }
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Update Unit In Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int count = 0;
            if (orderDetailList is null)
                orderDetailList = new List<OrderDetailDto>();
            else
                count = orderDetailList.Count();
            try
            {
                OrderDetailDto orderDetailDto = new OrderDetailDto
                {
                    No = orderDetailList.Count(),
                    OrderId = Convert.ToInt32(txtOrderID.Text),
                    ProductId = Convert.ToInt32(txtProductID.Text),
                    UnitPrice = Convert.ToDecimal(txtUnitPrice.Text),
                    Quantity = Convert.ToInt32(nupQuantity.Value),
                    Discount = Convert.ToDouble(nupDiscount.Value)
                };
                OrderDetail orderDetail = mapper.Map<OrderDetailDto, OrderDetail>(orderDetailDto);
                orderDetailList.Add(orderDetailDto);
                UpdateProductUnitsInStock(orderDetail);
                LoadOrderDetail();
                txtProductID.Text = String.Empty;
                txtUnitPrice.Text = String.Empty;
                nupDiscount.Value = 0;
                nupQuantity.Value = 0;
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Add Order Detail");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            gbOrderDetailInformation.Enabled = false;
            gbOrderInformation.Enabled = true;
            gbOrderButton.Visible = true;
            if (CreateOrUpdate == true && order != null)
                txtOrderID.Enabled = false;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            OrderDetailDto orderDetail = null;
            int NoOrderDetail = 0;
            GetOrderDetail(ref NoOrderDetail,ref orderDetail);
            try
            {
                if (orderDetail != null)
                {
                    DialogResult result = MessageBox
                        .Show("Do you want to remove this order?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        if (orderDetailList.Count() == 1)
                            orderDetailList.Clear();
                        else
                        {
                            List<OrderDetailDto> tempOrderDetail = new List<OrderDetailDto>();
                            foreach (var temp in orderDetailList)
                            {
                                if (temp.No != NoOrderDetail)
                                    tempOrderDetail.Add(temp);
                            }
                            orderDetailList = null;
                            orderDetailList = tempOrderDetail;
                        }
                        OrderDetail TempOrderDetail = mapper.Map<OrderDetailDto, OrderDetail>(orderDetail);
                        UpdateProductUnitsInStock(TempOrderDetail, false);
                        LoadOrderDetail();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Remove Order Detail");
            }
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            try
            {
                Order _order = orderRepository.GetOrdersByOrderID(order.OrderId);
                if (_order == null)
                {
                    foreach (var product in productList)
                        productRepository.UpdateProduct(product);
                    orderRepository.AddOrder(order);
                    foreach (var temp in orderDetailList)
                    {
                        OrderDetail TempOrderDetail = mapper.Map<OrderDetailDto, OrderDetail>(temp);
                        orderDetailRepository.AddOrderDetail(TempOrderDetail);
                    }
                    MessageBox.Show("Add new Order Successfully", "Add new Order");

                } else
                    MessageBox.Show("Duplicated Order ID", "Check Out Order", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Check Out Order");
            }
        }
        #endregion

        #region Mouse Over
        private void txtOrderID_MouseHover(object sender, EventArgs e)
        => StatusOrderProperties.Text = "Order ID shall be number";

        private void cboMemberID_MouseHover(object sender, EventArgs e)
        => StatusOrderProperties.Text = "Choose 1 member in the list of members";

        private void nupFreight_Click(object sender, EventArgs e)
        => StatusOrderProperties.Text = "Freight shall be number";

        private void frmOrderDetail_MouseHover(object sender, EventArgs e)
        => StatusOrderProperties.Text = String.Empty;

        private void dtpRequiredDate_DropDown(object sender, EventArgs e)
        => StatusOrderProperties.Text = "Required Date shall be after order date";

        private void dtpShippingDate_DropDown(object sender, EventArgs e)
        => StatusOrderProperties.Text = "Shipped Date shall be after order date";
        #endregion

        #region Key Down

        private void btnSave_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnSave_Click(sender, e);
        }

        private void btnClose_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                btnClose_Click(sender, e);
        }
        #endregion
    }
}
