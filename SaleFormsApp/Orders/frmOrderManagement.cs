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
using System.Windows.Forms;
using SaleFormsApp.Orders;

namespace SaleFormsApp
{
    public partial class frmOrderManagement : Form
    {
        #region Initialized Objects
        public MemberDto loginUser { get; set; }
        private IOrderRepository orderRepository = new OrderRepository();
        private IMemberRepository memberRepository = new MemberRepository();
        private IOrderDetailRepository orderDetailRepository = new OrderDetailRepository();
        private IProductRepository productRepository = new ProductRepository();
        private IMapper mapper = null;
        private BindingSource sourceOrder = null;
        private BindingSource sourceOrderDetail = null;
        private IMemberValidationRepository Validation = new MemberValidationRepository();
        private OrderErrors orderErrors = null;
        private OrderDetailErrors orderDetailErrors = null;
        private IEnumerable<OrderDto> orderDtoList = null;
        #endregion
        public frmOrderManagement()
        {
            InitializeComponent();
            var config = new MapperConfiguration(cfg => {
                cfg.AddProfile(new MappingProfile());
            });
            mapper = config.CreateMapper();
        }

        #region Get and Check
        private void LoadOrderList(bool search = false, IEnumerable<Order> SearchResult = null)
        {
            sourceOrder = null;
            sourceOrder = new BindingSource();
            IEnumerable<OrderDto> OrderList = null;
            var list = orderRepository.GetOrders();
            try
            {
                if (search)
                    OrderList = SearchResult.Select(temp
                            => mapper.Map<Order, OrderDto>(temp));
                else
                    OrderList = list.Select(temp
                            => mapper.Map<Order, OrderDto>(temp));
                if (OrderList != null)
                {
                    sourceOrder.DataSource = null;
                    sourceOrder.DataSource = OrderList;
                    orderDtoList = OrderList;
                    txtOrderID.DataBindings.Clear();
                    txtMemberID.DataBindings.Clear();
                    txtOrderDate.DataBindings.Clear();
                    txtRequiredDate.DataBindings.Clear();
                    txtShippedDate.DataBindings.Clear();
                    txtFreight.DataBindings.Clear();
                    txtTotal.DataBindings.Clear();

                    txtOrderID.DataBindings.Add("Text",sourceOrder, "OrderId");
                    txtMemberID.DataBindings.Add("Text", sourceOrder, "MemberID");
                    txtOrderDate.DataBindings.Add("Text", sourceOrder, "OrderDate");
                    txtRequiredDate.DataBindings.Add("Text", sourceOrder, "RequiredDate");
                    txtShippedDate.DataBindings.Add("Text", sourceOrder, "ShippedDate");
                    txtFreight.DataBindings.Add("Text", sourceOrder, "Freight");
                    txtTotal.DataBindings.Add("Text", sourceOrder, "OrderTotal");

                    dgv_Order.DataSource = null;
                    dgv_Order.DataSource = sourceOrder;

                    pnInformation1.Enabled = true;
                    pnInformation2.Enabled = true;
                    gbSearch.Enabled = true;
                    btnDelete.Enabled = true;
                    btnExport.Enabled = true;
                    this.Size = new Size { Width = 1641, Height = 995 };
                } else
                {
                    pnInformation1.Enabled = false;
                    pnInformation2.Enabled = false;
                    gbSearch.Enabled = false;
                    btnDelete.Enabled = false;
                    btnExport.Enabled = false;
                    orderDtoList = null;
                    if (search)
                    {
                        MessageBox.Show("There is no result matching with search", "Load searching order list");
                        LoadOrderList();
                    } else
                    {
                        MessageBox.Show("Order list is empty", "Load order list");
                        ClearText();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Load Order List");
            }
        }
        public DataTable setColumnNameOfTable(DataTable table = null)
        {
            table = new DataTable();
            table.Columns.Add("Order ID", typeof(int));
            table.Columns.Add("ProductId", typeof(int));
            table.Columns.Add("Unit Price", typeof(decimal));
            table.Columns.Add("Quantity", typeof(int));
            table.Columns.Add("Discount", typeof(decimal));
            return table;
        }
        private void LoadOrderDetailList(int orderID)
        {
            sourceOrderDetail = null;
            sourceOrderDetail = new BindingSource();
            IEnumerable<OrderDetailDto> OrderDetailList = null;
            var list = orderDetailRepository.GetOrderDetailListByOrderID(orderID);
            try
            {
                OrderDetailList = list.Select(temp
                        => mapper.Map<OrderDetail, OrderDetailDto>(temp));
                if (OrderDetailList != null)
                {
                    sourceOrderDetail.DataSource = null;
                    sourceOrderDetail.DataSource = OrderDetailList;
                    txtProductID.DataBindings.Clear();
                    txtProductName.DataBindings.Clear();
                    txtUnitPrice.DataBindings.Clear();
                    txtQuantity.DataBindings.Clear();
                    txtDiscount.DataBindings.Clear();

                    txtProductID.DataBindings.Add("Text", sourceOrderDetail, "ProductId");
                    txtProductName.DataBindings.Add("Text", sourceOrderDetail, "ProductName");
                    txtUnitPrice.DataBindings.Add("Text", sourceOrderDetail, "UnitPrice");
                    txtQuantity.DataBindings.Add("Text", sourceOrderDetail, "Quantity");
                    txtDiscount.DataBindings.Add("Text", sourceOrderDetail, "Discount");

                    dgv_OrderDetail.DataSource = null;
                    dgv_OrderDetail.DataSource = sourceOrderDetail;

                    pnInformation3.Enabled = true;
                    pnInformation4.Enabled = true;
                    this.Size = new Size { Width = 1641, Height = 995 };
                }
                else
                {
                    pnInformation3.Enabled = false;
                    pnInformation4.Enabled = false;
                    MessageBox.Show("Order Detail list is empty", "Load order list");
                    ClearText();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load Order Detail List");
            }
        }
        private void LoadOrderListByMemberID(bool search = false, IEnumerable<Order> SearchResult = null)
        {
            sourceOrder = null;
            sourceOrder = new BindingSource();
            IEnumerable<OrderDto> OrderList = null;
            var list = orderRepository.GetOrdersByMemberID(loginUser.MemberId);
            try
            {
                if (search)
                    OrderList = SearchResult.Select(temp
                        => mapper.Map<Order, OrderDto>(temp));
                else
                    OrderList = list.Select(temp
                        => mapper.Map<Order, OrderDto>(temp));
                if (OrderList != null)
                {
                    sourceOrder.DataSource = null;
                    sourceOrder.DataSource = OrderList;
                    txtOrderID.DataBindings.Clear();
                    txtMemberID.DataBindings.Clear();
                    txtOrderDate.DataBindings.Clear();
                    txtRequiredDate.DataBindings.Clear();
                    txtShippedDate.DataBindings.Clear();
                    txtFreight.DataBindings.Clear();
                    txtTotal.DataBindings.Clear();

                    txtOrderID.DataBindings.Add("Text", sourceOrder, "OrderId");
                    txtMemberID.DataBindings.Add("Text", sourceOrder, "MemberID");
                    txtOrderDate.DataBindings.Add("Text", sourceOrder, "OrderDate");
                    txtRequiredDate.DataBindings.Add("Text", sourceOrder, "RequiredDate");
                    txtShippedDate.DataBindings.Add("Text", sourceOrder, "ShippedDate");
                    txtFreight.DataBindings.Add("Text", sourceOrder, "Freight");
                    txtTotal.DataBindings.Add("Text", sourceOrder, "OrderTotal");

                    dgv_Order.DataSource = null;
                    dgv_Order.DataSource = sourceOrder;

                    pnInformation1.Enabled = true;
                    pnInformation2.Enabled = true;
                    gbSearch.Enabled = true;
                    this.Size = new Size { Width = 1641, Height = 995 };
                }
                else
                {
                    pnInformation1.Enabled = false;
                    pnInformation2.Enabled = false;
                    gbSearch.Enabled = false;
                    if (search)
                    {
                        MessageBox.Show("There is no result matching with search", "Load searching order list");
                        LoadOrderList();
                    }
                    else
                    {
                        MessageBox.Show("Order list is empty", "Load order list");
                        ClearText();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load Order List");
            }
        }
        private void ClearText()
        {
            txtOrderID.Text = String.Empty;
            txtMemberID.Text = String.Empty;
            txtOrderDate.Text = String.Empty;
            txtRequiredDate.Text = String.Empty;
            txtShippedDate.Text = String.Empty;
            txtFreight.Text = String.Empty;
            txtTotal.Text = String.Empty;
            txtProductID.Text = String.Empty;
            txtProductName.Text = String.Empty;
            txtUnitPrice.Text = String.Empty;
            txtQuantity.Text = String.Empty;
            txtDiscount.Text = String.Empty;
        }
        private bool IsAdmin()
        {
            bool result = false;
            if (loginUser.Email.Equals("admin@fstore.com") && loginUser.Password.Equals("admin@@"))
                result = true;
            return result;
        }
        private Order GetOrder()
        {
            Order order = null;
            try
            {
                order = new Order
                {
                    OrderId = Convert.ToInt32(txtOrderID.Text),
                    MemberId = Convert.ToInt32(txtMemberID.Text),
                    OrderDate = Convert.ToDateTime(txtOrderDate.Text),
                    RequiredDate = Convert.ToDateTime(txtRequiredDate.Text),
                    ShippedDate = Convert.ToDateTime(txtShippedDate.Text)
                };
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get Order");
            }
            return order;
        }
        private void frmOrderManagement_Load(object sender, EventArgs e)
        {
            pnInformation1.Enabled = false;
            pnInformation2.Enabled = false;
            gbSearch.Enabled = false;
            btnDelete.Enabled = false;
            dgv_OrderDetail.ReadOnly = true;
            btnExport.Enabled = false;
            this.Size = new Size { Width = 882, Height = 995 };
            if (IsAdmin() == false)
            {
                pnOrderButton.Visible = false;
                gbInformation.Size = new Size { Width = 831, Height = 449};
                dgv_Order.Location = new Point(6, 469);
                dgv_Order.Size = new Size { Width = 831, Height = 400};
                LoadOrderListByMemberID();
            }
            dgv_Order.CellDoubleClick += dgv_Order_CellDoubleClick;
        }
        private void txtOrderID_TextChanged(object sender, EventArgs e)
        => LoadOrderDetailList(Convert.ToInt32(txtOrderID.Text));
        #endregion

        #region CRUD
        private void btnLoad_Click(object sender, EventArgs e)
        => LoadOrderList();
        private void btnCreate_Click(object sender, EventArgs e)
        {
            frmOrderDetail orderDetail = new frmOrderDetail
            {
                CreateOrUpdate = true //Insert: true; Update: false
            };
            if (orderDetail.ShowDialog() == DialogResult.Cancel)
                LoadOrderList();
        }
        private void btnExport_Click(object sender, EventArgs e)
        {
            frmOrderExport export = new frmOrderExport();
            this.Hide();
            export.ShowDialog();
            this.Show();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int orderID = Convert.ToInt32(txtOrderID.Text);
                int memberID = Convert.ToInt32(txtMemberID.Text);
                Order tempOrder = orderRepository.checkDeleteOrderByOrderDetail(orderID);
                Member member = memberRepository.checkDeleteMember(memberID);
                if (tempOrder == null && member == null)
                {
                    DialogResult result = MessageBox.Show($"Do you want to delete this order id {orderID}",
                    "Delete Order", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        orderDetailRepository.DeleteOrderDetailByOrderID(orderID);
                        orderRepository.DeleteOrderByOrderID(orderID);
                        MessageBox.Show("Delete the order successfully!", "Delete order");
                        LoadOrderList();
                    }
                } else
                    MessageBox.Show("Cannot Delete this order!", "Delete order");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete Order");
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            int memberID = loginUser.MemberId;
            if (IsAdmin()) 
                memberID = 0;
            IEnumerable<Order> SearchResult = null;
            DateTime startDateTime = Convert.ToDateTime(dtpStartDate.Value);
            DateTime endDateTime = Convert.ToDateTime(dtpEndDate.Value);
            if (DateTime.Compare(startDateTime,endDateTime) > 0)
            {
                MessageBox.Show("Start date and end date are invalid to search", "Search Date");
            } else
            {
                SearchResult = orderRepository.GetOrdersByMemberIDAndTime(memberID, startDateTime, endDateTime);
                if (SearchResult != null)
                {
                    if (IsAdmin())
                        LoadOrderList(true, SearchResult);
                    else
                        LoadOrderListByMemberID(true, SearchResult);
                } else
                    MessageBox.Show("There is no result matching the search date", "Search Date");
            }
        }
        private void dgv_Order_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmOrderDetail orderDetail = new frmOrderDetail
            {
                CreateOrUpdate = false, //Insert: true; Update: false
                UpdateOrder = GetOrder()
            };
            if (orderDetail.ShowDialog() == DialogResult.Cancel)
                LoadOrderList();
        }
        #endregion
    }
}
