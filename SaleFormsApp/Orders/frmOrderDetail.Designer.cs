
namespace SaleFormsApp
{
    partial class frmOrderDetail
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbOrderInformation = new System.Windows.Forms.GroupBox();
            this.statusOrder = new System.Windows.Forms.StatusStrip();
            this.StatusOrderProperties = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnFreight = new System.Windows.Forms.Panel();
            this.nupFreight = new System.Windows.Forms.NumericUpDown();
            this.lbFreight = new System.Windows.Forms.Label();
            this.pnRequiredDate = new System.Windows.Forms.Panel();
            this.dtpRequiredDate = new System.Windows.Forms.DateTimePicker();
            this.lbRequiredDate = new System.Windows.Forms.Label();
            this.pnShippingDate = new System.Windows.Forms.Panel();
            this.dtpShippingDate = new System.Windows.Forms.DateTimePicker();
            this.lbShippingDate = new System.Windows.Forms.Label();
            this.pnOrderID = new System.Windows.Forms.Panel();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.lbOrderID = new System.Windows.Forms.Label();
            this.pnMemberID = new System.Windows.Forms.Panel();
            this.cboMemberID = new System.Windows.Forms.ComboBox();
            this.lbMemberID = new System.Windows.Forms.Label();
            this.gbOrderButton = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.gbOrderDetailInformation = new System.Windows.Forms.GroupBox();
            this.flpOrderDetailButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnRemove = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnEdit = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.dgv_OrderDetail = new System.Windows.Forms.DataGridView();
            this.pnOrderDetailInformation2 = new System.Windows.Forms.Panel();
            this.lbLeftQuantity = new System.Windows.Forms.Label();
            this.pnTotalOrder = new System.Windows.Forms.Panel();
            this.txtTotalOrder = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnQuantity = new System.Windows.Forms.Panel();
            this.nupQuantity = new System.Windows.Forms.NumericUpDown();
            this.lbQuantity = new System.Windows.Forms.Label();
            this.pnDiscount = new System.Windows.Forms.Panel();
            this.nupDiscount = new System.Windows.Forms.NumericUpDown();
            this.lbDiscount = new System.Windows.Forms.Label();
            this.pnOrderDetailInformation1 = new System.Windows.Forms.Panel();
            this.pnProductID = new System.Windows.Forms.Panel();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.lbProductID = new System.Windows.Forms.Label();
            this.pnProductName = new System.Windows.Forms.Panel();
            this.cboProductName = new System.Windows.Forms.ComboBox();
            this.lbProductName = new System.Windows.Forms.Label();
            this.pnUnitPrice = new System.Windows.Forms.Panel();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.lbUnitPrice = new System.Windows.Forms.Label();
            this.gbOrderInformation.SuspendLayout();
            this.statusOrder.SuspendLayout();
            this.pnFreight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupFreight)).BeginInit();
            this.pnRequiredDate.SuspendLayout();
            this.pnShippingDate.SuspendLayout();
            this.pnOrderID.SuspendLayout();
            this.pnMemberID.SuspendLayout();
            this.gbOrderButton.SuspendLayout();
            this.gbOrderDetailInformation.SuspendLayout();
            this.flpOrderDetailButtons.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_OrderDetail)).BeginInit();
            this.pnOrderDetailInformation2.SuspendLayout();
            this.pnTotalOrder.SuspendLayout();
            this.pnQuantity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupQuantity)).BeginInit();
            this.pnDiscount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupDiscount)).BeginInit();
            this.pnOrderDetailInformation1.SuspendLayout();
            this.pnProductID.SuspendLayout();
            this.pnProductName.SuspendLayout();
            this.pnUnitPrice.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbOrderInformation
            // 
            this.gbOrderInformation.Controls.Add(this.statusOrder);
            this.gbOrderInformation.Controls.Add(this.pnFreight);
            this.gbOrderInformation.Controls.Add(this.pnRequiredDate);
            this.gbOrderInformation.Controls.Add(this.pnShippingDate);
            this.gbOrderInformation.Controls.Add(this.pnOrderID);
            this.gbOrderInformation.Controls.Add(this.pnMemberID);
            this.gbOrderInformation.Location = new System.Drawing.Point(0, 0);
            this.gbOrderInformation.Name = "gbOrderInformation";
            this.gbOrderInformation.Size = new System.Drawing.Size(427, 351);
            this.gbOrderInformation.TabIndex = 1;
            this.gbOrderInformation.TabStop = false;
            // 
            // statusOrder
            // 
            this.statusOrder.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusOrder.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusOrderProperties});
            this.statusOrder.Location = new System.Drawing.Point(3, 326);
            this.statusOrder.Name = "statusOrder";
            this.statusOrder.Size = new System.Drawing.Size(421, 22);
            this.statusOrder.TabIndex = 6;
            this.statusOrder.Text = "statusStrip1";
            // 
            // StatusOrderProperties
            // 
            this.StatusOrderProperties.Name = "StatusOrderProperties";
            this.StatusOrderProperties.Size = new System.Drawing.Size(0, 16);
            // 
            // pnFreight
            // 
            this.pnFreight.Controls.Add(this.nupFreight);
            this.pnFreight.Controls.Add(this.lbFreight);
            this.pnFreight.Location = new System.Drawing.Point(26, 280);
            this.pnFreight.Name = "pnFreight";
            this.pnFreight.Size = new System.Drawing.Size(373, 32);
            this.pnFreight.TabIndex = 5;
            // 
            // nupFreight
            // 
            this.nupFreight.DecimalPlaces = 2;
            this.nupFreight.Location = new System.Drawing.Point(123, 5);
            this.nupFreight.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nupFreight.Name = "nupFreight";
            this.nupFreight.Size = new System.Drawing.Size(250, 27);
            this.nupFreight.TabIndex = 5;
            this.nupFreight.Click += new System.EventHandler(this.nupFreight_Click);
            // 
            // lbFreight
            // 
            this.lbFreight.AutoSize = true;
            this.lbFreight.Location = new System.Drawing.Point(6, 3);
            this.lbFreight.Name = "lbFreight";
            this.lbFreight.Size = new System.Drawing.Size(55, 20);
            this.lbFreight.TabIndex = 0;
            this.lbFreight.Text = "Freight";
            // 
            // pnRequiredDate
            // 
            this.pnRequiredDate.Controls.Add(this.dtpRequiredDate);
            this.pnRequiredDate.Controls.Add(this.lbRequiredDate);
            this.pnRequiredDate.Location = new System.Drawing.Point(24, 141);
            this.pnRequiredDate.Name = "pnRequiredDate";
            this.pnRequiredDate.Size = new System.Drawing.Size(374, 32);
            this.pnRequiredDate.TabIndex = 3;
            // 
            // dtpRequiredDate
            // 
            this.dtpRequiredDate.Location = new System.Drawing.Point(122, -1);
            this.dtpRequiredDate.Name = "dtpRequiredDate";
            this.dtpRequiredDate.Size = new System.Drawing.Size(250, 27);
            this.dtpRequiredDate.TabIndex = 3;
            this.dtpRequiredDate.DropDown += new System.EventHandler(this.dtpRequiredDate_DropDown);
            // 
            // lbRequiredDate
            // 
            this.lbRequiredDate.AutoSize = true;
            this.lbRequiredDate.Location = new System.Drawing.Point(6, 3);
            this.lbRequiredDate.Name = "lbRequiredDate";
            this.lbRequiredDate.Size = new System.Drawing.Size(105, 20);
            this.lbRequiredDate.TabIndex = 0;
            this.lbRequiredDate.Text = "Required Date";
            // 
            // pnShippingDate
            // 
            this.pnShippingDate.Controls.Add(this.dtpShippingDate);
            this.pnShippingDate.Controls.Add(this.lbShippingDate);
            this.pnShippingDate.Location = new System.Drawing.Point(26, 215);
            this.pnShippingDate.Name = "pnShippingDate";
            this.pnShippingDate.Size = new System.Drawing.Size(372, 32);
            this.pnShippingDate.TabIndex = 4;
            // 
            // dtpShippingDate
            // 
            this.dtpShippingDate.Location = new System.Drawing.Point(124, 2);
            this.dtpShippingDate.Name = "dtpShippingDate";
            this.dtpShippingDate.Size = new System.Drawing.Size(250, 27);
            this.dtpShippingDate.TabIndex = 4;
            this.dtpShippingDate.DropDown += new System.EventHandler(this.dtpShippingDate_DropDown);
            // 
            // lbShippingDate
            // 
            this.lbShippingDate.AutoSize = true;
            this.lbShippingDate.Location = new System.Drawing.Point(6, 3);
            this.lbShippingDate.Name = "lbShippingDate";
            this.lbShippingDate.Size = new System.Drawing.Size(104, 20);
            this.lbShippingDate.TabIndex = 0;
            this.lbShippingDate.Text = "Shipping Date";
            // 
            // pnOrderID
            // 
            this.pnOrderID.Controls.Add(this.txtOrderID);
            this.pnOrderID.Controls.Add(this.lbOrderID);
            this.pnOrderID.Location = new System.Drawing.Point(23, 11);
            this.pnOrderID.Name = "pnOrderID";
            this.pnOrderID.Size = new System.Drawing.Size(374, 32);
            this.pnOrderID.TabIndex = 0;
            // 
            // txtOrderID
            // 
            this.txtOrderID.Location = new System.Drawing.Point(123, 0);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.Size = new System.Drawing.Size(248, 27);
            this.txtOrderID.TabIndex = 1;
            this.txtOrderID.MouseHover += new System.EventHandler(this.txtOrderID_MouseHover);
            // 
            // lbOrderID
            // 
            this.lbOrderID.AutoSize = true;
            this.lbOrderID.Location = new System.Drawing.Point(6, 3);
            this.lbOrderID.Name = "lbOrderID";
            this.lbOrderID.Size = new System.Drawing.Size(66, 20);
            this.lbOrderID.TabIndex = 0;
            this.lbOrderID.Text = "Order ID";
            // 
            // pnMemberID
            // 
            this.pnMemberID.Controls.Add(this.cboMemberID);
            this.pnMemberID.Controls.Add(this.lbMemberID);
            this.pnMemberID.Location = new System.Drawing.Point(25, 75);
            this.pnMemberID.Name = "pnMemberID";
            this.pnMemberID.Size = new System.Drawing.Size(374, 32);
            this.pnMemberID.TabIndex = 2;
            // 
            // cboMemberID
            // 
            this.cboMemberID.FormattingEnabled = true;
            this.cboMemberID.Location = new System.Drawing.Point(123, 1);
            this.cboMemberID.Name = "cboMemberID";
            this.cboMemberID.Size = new System.Drawing.Size(248, 28);
            this.cboMemberID.TabIndex = 2;
            this.cboMemberID.MouseHover += new System.EventHandler(this.cboMemberID_MouseHover);
            // 
            // lbMemberID
            // 
            this.lbMemberID.AutoSize = true;
            this.lbMemberID.Location = new System.Drawing.Point(6, 3);
            this.lbMemberID.Name = "lbMemberID";
            this.lbMemberID.Size = new System.Drawing.Size(84, 20);
            this.lbMemberID.TabIndex = 0;
            this.lbMemberID.Text = "Member ID";
            // 
            // gbOrderButton
            // 
            this.gbOrderButton.Controls.Add(this.btnSave);
            this.gbOrderButton.Controls.Add(this.btnClose);
            this.gbOrderButton.Location = new System.Drawing.Point(3, 372);
            this.gbOrderButton.Name = "gbOrderButton";
            this.gbOrderButton.Size = new System.Drawing.Size(427, 54);
            this.gbOrderButton.TabIndex = 2;
            this.gbOrderButton.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(84, 19);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 29);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnSave.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnSave_KeyDown);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(249, 19);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(94, 29);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnClose_KeyDown);
            // 
            // gbOrderDetailInformation
            // 
            this.gbOrderDetailInformation.Controls.Add(this.flpOrderDetailButtons);
            this.gbOrderDetailInformation.Controls.Add(this.dgv_OrderDetail);
            this.gbOrderDetailInformation.Controls.Add(this.pnOrderDetailInformation2);
            this.gbOrderDetailInformation.Controls.Add(this.pnOrderDetailInformation1);
            this.gbOrderDetailInformation.Location = new System.Drawing.Point(462, 9);
            this.gbOrderDetailInformation.Name = "gbOrderDetailInformation";
            this.gbOrderDetailInformation.Size = new System.Drawing.Size(777, 681);
            this.gbOrderDetailInformation.TabIndex = 5;
            this.gbOrderDetailInformation.TabStop = false;
            // 
            // flpOrderDetailButtons
            // 
            this.flpOrderDetailButtons.Controls.Add(this.panel1);
            this.flpOrderDetailButtons.Controls.Add(this.panel2);
            this.flpOrderDetailButtons.Controls.Add(this.panel3);
            this.flpOrderDetailButtons.Controls.Add(this.panel4);
            this.flpOrderDetailButtons.Location = new System.Drawing.Point(64, 224);
            this.flpOrderDetailButtons.Name = "flpOrderDetailButtons";
            this.flpOrderDetailButtons.Size = new System.Drawing.Size(625, 49);
            this.flpOrderDetailButtons.TabIndex = 18;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 43);
            this.panel1.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(28, 8);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 29);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnRemove);
            this.panel2.Location = new System.Drawing.Point(159, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(150, 43);
            this.panel2.TabIndex = 15;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(30, 8);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(94, 29);
            this.btnRemove.TabIndex = 15;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnEdit);
            this.panel3.Location = new System.Drawing.Point(315, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(150, 43);
            this.panel3.TabIndex = 16;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(26, 8);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(94, 29);
            this.btnEdit.TabIndex = 15;
            this.btnEdit.Text = "Edit Order";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnCheckOut);
            this.panel4.Location = new System.Drawing.Point(471, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(150, 43);
            this.panel4.TabIndex = 17;
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Location = new System.Drawing.Point(28, 8);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(94, 29);
            this.btnCheckOut.TabIndex = 16;
            this.btnCheckOut.Text = "Check Out";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // dgv_OrderDetail
            // 
            this.dgv_OrderDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_OrderDetail.Location = new System.Drawing.Point(-3, 316);
            this.dgv_OrderDetail.Name = "dgv_OrderDetail";
            this.dgv_OrderDetail.RowHeadersWidth = 51;
            this.dgv_OrderDetail.RowTemplate.Height = 29;
            this.dgv_OrderDetail.Size = new System.Drawing.Size(777, 359);
            this.dgv_OrderDetail.TabIndex = 17;
            this.dgv_OrderDetail.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_OrderDetail_CellClick);
            // 
            // pnOrderDetailInformation2
            // 
            this.pnOrderDetailInformation2.Controls.Add(this.lbLeftQuantity);
            this.pnOrderDetailInformation2.Controls.Add(this.pnTotalOrder);
            this.pnOrderDetailInformation2.Controls.Add(this.pnQuantity);
            this.pnOrderDetailInformation2.Controls.Add(this.pnDiscount);
            this.pnOrderDetailInformation2.Location = new System.Drawing.Point(456, 4);
            this.pnOrderDetailInformation2.Name = "pnOrderDetailInformation2";
            this.pnOrderDetailInformation2.Size = new System.Drawing.Size(317, 163);
            this.pnOrderDetailInformation2.TabIndex = 8;
            // 
            // lbLeftQuantity
            // 
            this.lbLeftQuantity.AutoSize = true;
            this.lbLeftQuantity.Location = new System.Drawing.Point(3, 37);
            this.lbLeftQuantity.Name = "lbLeftQuantity";
            this.lbLeftQuantity.Size = new System.Drawing.Size(0, 20);
            this.lbLeftQuantity.TabIndex = 2;
            // 
            // pnTotalOrder
            // 
            this.pnTotalOrder.Controls.Add(this.txtTotalOrder);
            this.pnTotalOrder.Controls.Add(this.label1);
            this.pnTotalOrder.Location = new System.Drawing.Point(3, 128);
            this.pnTotalOrder.Name = "pnTotalOrder";
            this.pnTotalOrder.Size = new System.Drawing.Size(313, 32);
            this.pnTotalOrder.TabIndex = 3;
            // 
            // txtTotalOrder
            // 
            this.txtTotalOrder.Enabled = false;
            this.txtTotalOrder.Location = new System.Drawing.Point(132, 0);
            this.txtTotalOrder.Name = "txtTotalOrder";
            this.txtTotalOrder.Size = new System.Drawing.Size(184, 27);
            this.txtTotalOrder.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Order";
            // 
            // pnQuantity
            // 
            this.pnQuantity.Controls.Add(this.nupQuantity);
            this.pnQuantity.Controls.Add(this.lbQuantity);
            this.pnQuantity.Location = new System.Drawing.Point(2, 0);
            this.pnQuantity.Name = "pnQuantity";
            this.pnQuantity.Size = new System.Drawing.Size(313, 32);
            this.pnQuantity.TabIndex = 0;
            // 
            // nupQuantity
            // 
            this.nupQuantity.Location = new System.Drawing.Point(129, 3);
            this.nupQuantity.Name = "nupQuantity";
            this.nupQuantity.Size = new System.Drawing.Size(181, 27);
            this.nupQuantity.TabIndex = 11;
            this.nupQuantity.ValueChanged += new System.EventHandler(this.nupQuantity_ValueChanged);
            // 
            // lbQuantity
            // 
            this.lbQuantity.AutoSize = true;
            this.lbQuantity.Location = new System.Drawing.Point(6, 3);
            this.lbQuantity.Name = "lbQuantity";
            this.lbQuantity.Size = new System.Drawing.Size(65, 20);
            this.lbQuantity.TabIndex = 0;
            this.lbQuantity.Text = "Quantity";
            // 
            // pnDiscount
            // 
            this.pnDiscount.Controls.Add(this.nupDiscount);
            this.pnDiscount.Controls.Add(this.lbDiscount);
            this.pnDiscount.Location = new System.Drawing.Point(1, 63);
            this.pnDiscount.Name = "pnDiscount";
            this.pnDiscount.Size = new System.Drawing.Size(313, 32);
            this.pnDiscount.TabIndex = 1;
            // 
            // nupDiscount
            // 
            this.nupDiscount.DecimalPlaces = 2;
            this.nupDiscount.Location = new System.Drawing.Point(132, 2);
            this.nupDiscount.Name = "nupDiscount";
            this.nupDiscount.Size = new System.Drawing.Size(181, 27);
            this.nupDiscount.TabIndex = 12;
            this.nupDiscount.ValueChanged += new System.EventHandler(this.nupDiscount_ValueChanged);
            // 
            // lbDiscount
            // 
            this.lbDiscount.AutoSize = true;
            this.lbDiscount.Location = new System.Drawing.Point(6, 3);
            this.lbDiscount.Name = "lbDiscount";
            this.lbDiscount.Size = new System.Drawing.Size(67, 20);
            this.lbDiscount.TabIndex = 0;
            this.lbDiscount.Text = "Discount";
            // 
            // pnOrderDetailInformation1
            // 
            this.pnOrderDetailInformation1.Controls.Add(this.pnProductID);
            this.pnOrderDetailInformation1.Controls.Add(this.pnProductName);
            this.pnOrderDetailInformation1.Controls.Add(this.pnUnitPrice);
            this.pnOrderDetailInformation1.Location = new System.Drawing.Point(6, 2);
            this.pnOrderDetailInformation1.Name = "pnOrderDetailInformation1";
            this.pnOrderDetailInformation1.Size = new System.Drawing.Size(317, 170);
            this.pnOrderDetailInformation1.TabIndex = 6;
            // 
            // pnProductID
            // 
            this.pnProductID.Controls.Add(this.txtProductID);
            this.pnProductID.Controls.Add(this.lbProductID);
            this.pnProductID.Location = new System.Drawing.Point(2, 0);
            this.pnProductID.Name = "pnProductID";
            this.pnProductID.Size = new System.Drawing.Size(313, 32);
            this.pnProductID.TabIndex = 0;
            // 
            // txtProductID
            // 
            this.txtProductID.Enabled = false;
            this.txtProductID.Location = new System.Drawing.Point(128, 2);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(184, 27);
            this.txtProductID.TabIndex = 8;
            // 
            // lbProductID
            // 
            this.lbProductID.AutoSize = true;
            this.lbProductID.Location = new System.Drawing.Point(6, 3);
            this.lbProductID.Name = "lbProductID";
            this.lbProductID.Size = new System.Drawing.Size(79, 20);
            this.lbProductID.TabIndex = 0;
            this.lbProductID.Text = "Product ID";
            // 
            // pnProductName
            // 
            this.pnProductName.Controls.Add(this.cboProductName);
            this.pnProductName.Controls.Add(this.lbProductName);
            this.pnProductName.Location = new System.Drawing.Point(2, 64);
            this.pnProductName.Name = "pnProductName";
            this.pnProductName.Size = new System.Drawing.Size(313, 32);
            this.pnProductName.TabIndex = 1;
            // 
            // cboProductName
            // 
            this.cboProductName.FormattingEnabled = true;
            this.cboProductName.Location = new System.Drawing.Point(132, 0);
            this.cboProductName.Name = "cboProductName";
            this.cboProductName.Size = new System.Drawing.Size(184, 28);
            this.cboProductName.TabIndex = 9;
            this.cboProductName.SelectedIndexChanged += new System.EventHandler(this.cboProductName_SelectedIndexChanged);
            // 
            // lbProductName
            // 
            this.lbProductName.AutoSize = true;
            this.lbProductName.Location = new System.Drawing.Point(6, 3);
            this.lbProductName.Name = "lbProductName";
            this.lbProductName.Size = new System.Drawing.Size(104, 20);
            this.lbProductName.TabIndex = 0;
            this.lbProductName.Text = "Product Name";
            // 
            // pnUnitPrice
            // 
            this.pnUnitPrice.Controls.Add(this.txtUnitPrice);
            this.pnUnitPrice.Controls.Add(this.lbUnitPrice);
            this.pnUnitPrice.Location = new System.Drawing.Point(1, 133);
            this.pnUnitPrice.Name = "pnUnitPrice";
            this.pnUnitPrice.Size = new System.Drawing.Size(313, 32);
            this.pnUnitPrice.TabIndex = 2;
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Enabled = false;
            this.txtUnitPrice.Location = new System.Drawing.Point(132, 0);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(184, 27);
            this.txtUnitPrice.TabIndex = 10;
            // 
            // lbUnitPrice
            // 
            this.lbUnitPrice.AutoSize = true;
            this.lbUnitPrice.Location = new System.Drawing.Point(6, 3);
            this.lbUnitPrice.Name = "lbUnitPrice";
            this.lbUnitPrice.Size = new System.Drawing.Size(72, 20);
            this.lbUnitPrice.TabIndex = 0;
            this.lbUnitPrice.Text = "Unit Price";
            // 
            // frmOrderDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1270, 690);
            this.Controls.Add(this.gbOrderDetailInformation);
            this.Controls.Add(this.gbOrderButton);
            this.Controls.Add(this.gbOrderInformation);
            this.Name = "frmOrderDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order Detail";
            this.Load += new System.EventHandler(this.frmOrderDetail_Load);
            this.MouseHover += new System.EventHandler(this.frmOrderDetail_MouseHover);
            this.gbOrderInformation.ResumeLayout(false);
            this.gbOrderInformation.PerformLayout();
            this.statusOrder.ResumeLayout(false);
            this.statusOrder.PerformLayout();
            this.pnFreight.ResumeLayout(false);
            this.pnFreight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupFreight)).EndInit();
            this.pnRequiredDate.ResumeLayout(false);
            this.pnRequiredDate.PerformLayout();
            this.pnShippingDate.ResumeLayout(false);
            this.pnShippingDate.PerformLayout();
            this.pnOrderID.ResumeLayout(false);
            this.pnOrderID.PerformLayout();
            this.pnMemberID.ResumeLayout(false);
            this.pnMemberID.PerformLayout();
            this.gbOrderButton.ResumeLayout(false);
            this.gbOrderDetailInformation.ResumeLayout(false);
            this.flpOrderDetailButtons.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_OrderDetail)).EndInit();
            this.pnOrderDetailInformation2.ResumeLayout(false);
            this.pnOrderDetailInformation2.PerformLayout();
            this.pnTotalOrder.ResumeLayout(false);
            this.pnTotalOrder.PerformLayout();
            this.pnQuantity.ResumeLayout(false);
            this.pnQuantity.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupQuantity)).EndInit();
            this.pnDiscount.ResumeLayout(false);
            this.pnDiscount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupDiscount)).EndInit();
            this.pnOrderDetailInformation1.ResumeLayout(false);
            this.pnProductID.ResumeLayout(false);
            this.pnProductID.PerformLayout();
            this.pnProductName.ResumeLayout(false);
            this.pnProductName.PerformLayout();
            this.pnUnitPrice.ResumeLayout(false);
            this.pnUnitPrice.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbOrderInformation;
        private System.Windows.Forms.Panel pnFreight;
        private System.Windows.Forms.Label lbFreight;
        private System.Windows.Forms.Panel pnRequiredDate;
        private System.Windows.Forms.Label lbRequiredDate;
        private System.Windows.Forms.Panel pnShippingDate;
        private System.Windows.Forms.Label lbShippingDate;
        private System.Windows.Forms.Panel pnOrderID;
        private System.Windows.Forms.Label lbOrderID;
        private System.Windows.Forms.Panel pnMemberID;
        private System.Windows.Forms.Label lbMemberID;
        private System.Windows.Forms.GroupBox gbOrderButton;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.DateTimePicker dtpRequiredDate;
        private System.Windows.Forms.DateTimePicker dtpShippingDate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox gbOrderDetailInformation;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.DataGridView dgv_OrderDetail;
        private System.Windows.Forms.Panel pnOrderDetailInformation2;
        private System.Windows.Forms.Panel pnQuantity;
        private System.Windows.Forms.Label lbQuantity;
        private System.Windows.Forms.Panel pnDiscount;
        private System.Windows.Forms.Label lbDiscount;
        private System.Windows.Forms.Panel pnOrderDetailInformation1;
        private System.Windows.Forms.Panel pnProductID;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.Label lbProductID;
        private System.Windows.Forms.Panel pnProductName;
        private System.Windows.Forms.Label lbProductName;
        private System.Windows.Forms.Panel pnUnitPrice;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.Label lbUnitPrice;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.NumericUpDown nupFreight;
        private System.Windows.Forms.Panel pnTotalOrder;
        private System.Windows.Forms.TextBox txtTotalOrder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nupQuantity;
        private System.Windows.Forms.NumericUpDown nupDiscount;
        private System.Windows.Forms.ComboBox cboProductName;
        private System.Windows.Forms.ComboBox cboMemberID;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.StatusStrip statusOrder;
        private System.Windows.Forms.ToolStripStatusLabel StatusOrderProperties;
        private System.Windows.Forms.FlowLayoutPanel flpOrderDetailButtons;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbLeftQuantity;
    }
}