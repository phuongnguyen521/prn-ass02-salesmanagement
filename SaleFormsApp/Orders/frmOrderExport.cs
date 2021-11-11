using AutoMapper;
using BusinessObject.Object;
using DataAccess.Repository;
using Microsoft.Office.Interop.Excel;
using SaleFormsApp.Mappers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SaleFormsApp.Orders
{
    public partial class frmOrderExport : Form
    {
        #region Initialized Objects
        private List<OrderDto> orderDtoList = null;
        private IOrderRepository orderRepository = new OrderRepository();
        private IMapper mapper = null;
        private BindingSource source = null;
        #endregion

        #region Events
        public frmOrderExport()
        {
            InitializeComponent();
            var config = new MapperConfiguration(cfg => {
                cfg.AddProfile(new MappingProfile());
            });
            mapper = config.CreateMapper();
        }
        private void LoadOrderList(bool search = false, IEnumerable<Order> SearchResult = null)
        {
            IEnumerable<OrderDto> OrderList = null;
            var list = orderRepository.GetOrders();
            orderDtoList = new List<OrderDto>();
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
                    source = new BindingSource();
                    source.DataSource = null;
                    source.DataSource = OrderList;
                    orderDtoList = OrderList.ToList();

                    dgv_Order.DataSource = null;
                    dgv_Order.DataSource = source;
                    btnExport.Enabled = true;
                    this.Size = new Size { Width = 1641, Height = 995 };
                }
                else
                {
                    btnSearch.Enabled = false;
                    btnExport.Enabled = false;
                    orderDtoList = null;
                    if (search)
                    {
                        MessageBox.Show("There is no result matching with search", "Load searching order list");
                        LoadOrderList();
                    }
                    else
                    {
                        MessageBox.Show("Order list is empty", "Load order list");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load Order List");
            }
        }
        private void frmOrderExport_Load(object sender, EventArgs e)
        => LoadOrderList();
        private void btnSearch_Click(object sender, EventArgs e)
        {
            IEnumerable<Order> SearchResult = null;
            DateTime startDateTime = Convert.ToDateTime(dtpStartDate.Value);
            DateTime endDateTime = Convert.ToDateTime(dtpEndDate.Value);
            if (DateTime.Compare(startDateTime,endDateTime) > 0)
            {
                MessageBox.Show("Start date and end date are invalid to search", "Search Date");
            } else
            {
                SearchResult = orderRepository.GetOrdersByMemberIDAndTime(0, startDateTime, endDateTime);
                if (SearchResult != null)
                    LoadOrderList(true, SearchResult);
                else
                    MessageBox.Show("There is no result matching the search date", "Search Date");
            }
        }
        private void btnExport_Click(object sender, EventArgs e)
        {
            if (orderDtoList != null)
            {
                using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx", ValidateNames = true })
                {
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
                            Workbook wb = app.Workbooks.Add(XlSheetType.xlWorksheet);
                            Worksheet ws = (Worksheet)app.ActiveSheet;
                            app.Visible = false;
                            ws.Cells[1, 1] = "Order ID";
                            ws.Cells[1, 2] = "Member ID";
                            ws.Cells[1, 3] = "Order Date";
                            ws.Cells[1, 4] = "Required Date";
                            ws.Cells[1, 5] = "Shipped Date";
                            ws.Cells[1, 6] = "Freight";
                            ws.Cells[1, 7] = "Order Total";
                            int i = 2;
                            foreach (var temp in orderDtoList)
                            {
                                ws.Cells[i, 1] = temp.OrderId;
                                ws.Cells[i, 2] = temp.MemberID;
                                ws.Cells[i, 3] = temp.OrderDate;
                                ws.Cells[i, 4] = temp.RequiredDate;
                                ws.Cells[i, 5] = temp.ShippedDate;
                                ws.Cells[i, 6] = temp.Freight;
                                ws.Cells[i, 7] = temp.OrderTotal;
                                i++;
                            }
                            wb.SaveAs(sfd.FileName, XlFileFormat.xlWorkbookDefault,
                                Type.Missing, Type.Missing,
                                true, false,
                                XlSaveAsAccessMode.xlNoChange, XlSaveConflictResolution.xlLocalSessionChanges,
                                Type.Missing, Type.Missing);
                            app.Quit();
                            MessageBox.Show("Your data has been successfully exported", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                }
            }
            else
                MessageBox.Show("There is no data in order to export!", "Export Report");
        }
        #endregion
    }
}
