
namespace SaleFormsApp
{
    partial class frmMemberManagement
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
            this.gbMenu = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuOrderItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuProductItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuExitItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbSearchAndFilter = new System.Windows.Forms.GroupBox();
            this.gbFilter = new System.Windows.Forms.GroupBox();
            this.pnSearchCity = new System.Windows.Forms.Panel();
            this.cboSearchCity = new System.Windows.Forms.ComboBox();
            this.lbSearchCity = new System.Windows.Forms.Label();
            this.pnSearchCountry = new System.Windows.Forms.Panel();
            this.cboSearchCountry = new System.Windows.Forms.ComboBox();
            this.lbSearchCountry = new System.Windows.Forms.Label();
            this.gbSearch = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.pnSearchProductName = new System.Windows.Forms.Panel();
            this.txtSearchCompanyName = new System.Windows.Forms.TextBox();
            this.lbSearchCompanyName = new System.Windows.Forms.Label();
            this.pnSearchProductID = new System.Windows.Forms.Panel();
            this.txtSearchMemberID = new System.Windows.Forms.TextBox();
            this.lbSearchMemberID = new System.Windows.Forms.Label();
            this.pnButtons = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.pnInformationDetail2 = new System.Windows.Forms.Panel();
            this.pnWeight = new System.Windows.Forms.Panel();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lbCity = new System.Windows.Forms.Label();
            this.pnUnitInStock = new System.Windows.Forms.Panel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.pnUnitPrice = new System.Windows.Forms.Panel();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.labCounty = new System.Windows.Forms.Label();
            this.pnInformationDetail1 = new System.Windows.Forms.Panel();
            this.pnProductID = new System.Windows.Forms.Panel();
            this.txtMemberID = new System.Windows.Forms.TextBox();
            this.lbMemberID = new System.Windows.Forms.Label();
            this.pnCategoryID = new System.Windows.Forms.Panel();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.pnProductName = new System.Windows.Forms.Panel();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.lbProductName = new System.Windows.Forms.Label();
            this.dgv_Member = new System.Windows.Forms.DataGridView();
            this.pnClose = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.gbMenu.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.gbSearchAndFilter.SuspendLayout();
            this.gbFilter.SuspendLayout();
            this.pnSearchCity.SuspendLayout();
            this.pnSearchCountry.SuspendLayout();
            this.gbSearch.SuspendLayout();
            this.pnSearchProductName.SuspendLayout();
            this.pnSearchProductID.SuspendLayout();
            this.pnButtons.SuspendLayout();
            this.pnInformationDetail2.SuspendLayout();
            this.pnWeight.SuspendLayout();
            this.pnUnitInStock.SuspendLayout();
            this.pnUnitPrice.SuspendLayout();
            this.pnInformationDetail1.SuspendLayout();
            this.pnProductID.SuspendLayout();
            this.pnCategoryID.SuspendLayout();
            this.pnProductName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Member)).BeginInit();
            this.pnClose.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbMenu
            // 
            this.gbMenu.Controls.Add(this.menuStrip1);
            this.gbMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbMenu.Location = new System.Drawing.Point(0, 0);
            this.gbMenu.Name = "gbMenu";
            this.gbMenu.Size = new System.Drawing.Size(831, 50);
            this.gbMenu.TabIndex = 1;
            this.gbMenu.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuManagement});
            this.menuStrip1.Location = new System.Drawing.Point(3, 23);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(825, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuManagement
            // 
            this.MenuManagement.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.MenuManagement.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuOrderItem,
            this.MenuProductItem,
            this.MenuExitItem});
            this.MenuManagement.Name = "MenuManagement";
            this.MenuManagement.Size = new System.Drawing.Size(60, 24);
            this.MenuManagement.Text = "Menu";
            // 
            // MenuOrderItem
            // 
            this.MenuOrderItem.Name = "MenuOrderItem";
            this.MenuOrderItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.MenuOrderItem.Size = new System.Drawing.Size(285, 26);
            this.MenuOrderItem.Text = "Order Management";
            // 
            // MenuProductItem
            // 
            this.MenuProductItem.Name = "MenuProductItem";
            this.MenuProductItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.MenuProductItem.Size = new System.Drawing.Size(285, 26);
            this.MenuProductItem.Text = "Product Management";
            // 
            // MenuExitItem
            // 
            this.MenuExitItem.Name = "MenuExitItem";
            this.MenuExitItem.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.MenuExitItem.Size = new System.Drawing.Size(285, 26);
            this.MenuExitItem.Text = "Exit";
            // 
            // gbSearchAndFilter
            // 
            this.gbSearchAndFilter.Controls.Add(this.gbFilter);
            this.gbSearchAndFilter.Controls.Add(this.gbSearch);
            this.gbSearchAndFilter.Controls.Add(this.pnButtons);
            this.gbSearchAndFilter.Controls.Add(this.pnInformationDetail2);
            this.gbSearchAndFilter.Controls.Add(this.pnInformationDetail1);
            this.gbSearchAndFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbSearchAndFilter.Location = new System.Drawing.Point(0, 50);
            this.gbSearchAndFilter.Name = "gbSearchAndFilter";
            this.gbSearchAndFilter.Size = new System.Drawing.Size(831, 437);
            this.gbSearchAndFilter.TabIndex = 2;
            this.gbSearchAndFilter.TabStop = false;
            // 
            // gbFilter
            // 
            this.gbFilter.Controls.Add(this.pnSearchCity);
            this.gbFilter.Controls.Add(this.pnSearchCountry);
            this.gbFilter.Location = new System.Drawing.Point(410, 191);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Size = new System.Drawing.Size(409, 192);
            this.gbFilter.TabIndex = 10;
            this.gbFilter.TabStop = false;
            this.gbFilter.Text = "Filter";
            // 
            // pnSearchCity
            // 
            this.pnSearchCity.Controls.Add(this.cboSearchCity);
            this.pnSearchCity.Controls.Add(this.lbSearchCity);
            this.pnSearchCity.Location = new System.Drawing.Point(54, 95);
            this.pnSearchCity.Name = "pnSearchCity";
            this.pnSearchCity.Size = new System.Drawing.Size(314, 30);
            this.pnSearchCity.TabIndex = 16;
            // 
            // cboSearchCity
            // 
            this.cboSearchCity.FormattingEnabled = true;
            this.cboSearchCity.Location = new System.Drawing.Point(127, 0);
            this.cboSearchCity.Name = "cboSearchCity";
            this.cboSearchCity.Size = new System.Drawing.Size(187, 28);
            this.cboSearchCity.TabIndex = 15;
            this.cboSearchCity.SelectedIndexChanged += new System.EventHandler(this.cboSearchCity_SelectedIndexChanged);
            // 
            // lbSearchCity
            // 
            this.lbSearchCity.AutoSize = true;
            this.lbSearchCity.Location = new System.Drawing.Point(12, 3);
            this.lbSearchCity.Name = "lbSearchCity";
            this.lbSearchCity.Size = new System.Drawing.Size(34, 20);
            this.lbSearchCity.TabIndex = 0;
            this.lbSearchCity.Text = "City";
            // 
            // pnSearchCountry
            // 
            this.pnSearchCountry.Controls.Add(this.cboSearchCountry);
            this.pnSearchCountry.Controls.Add(this.lbSearchCountry);
            this.pnSearchCountry.Location = new System.Drawing.Point(55, 48);
            this.pnSearchCountry.Name = "pnSearchCountry";
            this.pnSearchCountry.Size = new System.Drawing.Size(314, 30);
            this.pnSearchCountry.TabIndex = 4;
            // 
            // cboSearchCountry
            // 
            this.cboSearchCountry.FormattingEnabled = true;
            this.cboSearchCountry.Location = new System.Drawing.Point(127, 0);
            this.cboSearchCountry.Name = "cboSearchCountry";
            this.cboSearchCountry.Size = new System.Drawing.Size(187, 28);
            this.cboSearchCountry.TabIndex = 15;
            this.cboSearchCountry.SelectedIndexChanged += new System.EventHandler(this.cboSearchCountry_SelectedIndexChanged);
            // 
            // lbSearchCountry
            // 
            this.lbSearchCountry.AutoSize = true;
            this.lbSearchCountry.Location = new System.Drawing.Point(12, 3);
            this.lbSearchCountry.Name = "lbSearchCountry";
            this.lbSearchCountry.Size = new System.Drawing.Size(60, 20);
            this.lbSearchCountry.TabIndex = 0;
            this.lbSearchCountry.Text = "Country";
            // 
            // gbSearch
            // 
            this.gbSearch.Controls.Add(this.btnSearch);
            this.gbSearch.Controls.Add(this.pnSearchProductName);
            this.gbSearch.Controls.Add(this.pnSearchProductID);
            this.gbSearch.Location = new System.Drawing.Point(12, 191);
            this.gbSearch.Name = "gbSearch";
            this.gbSearch.Size = new System.Drawing.Size(369, 192);
            this.gbSearch.TabIndex = 8;
            this.gbSearch.TabStop = false;
            this.gbSearch.Text = "Search ID/Product Name";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(134, 157);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(94, 29);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // pnSearchProductName
            // 
            this.pnSearchProductName.Controls.Add(this.txtSearchCompanyName);
            this.pnSearchProductName.Controls.Add(this.lbSearchCompanyName);
            this.pnSearchProductName.Location = new System.Drawing.Point(33, 95);
            this.pnSearchProductName.Name = "pnSearchProductName";
            this.pnSearchProductName.Size = new System.Drawing.Size(313, 32);
            this.pnSearchProductName.TabIndex = 2;
            // 
            // txtSearchCompanyName
            // 
            this.txtSearchCompanyName.Location = new System.Drawing.Point(126, 0);
            this.txtSearchCompanyName.Name = "txtSearchCompanyName";
            this.txtSearchCompanyName.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSearchCompanyName.Size = new System.Drawing.Size(184, 27);
            this.txtSearchCompanyName.TabIndex = 8;
            // 
            // lbSearchCompanyName
            // 
            this.lbSearchCompanyName.AutoSize = true;
            this.lbSearchCompanyName.Location = new System.Drawing.Point(6, 3);
            this.lbSearchCompanyName.Name = "lbSearchCompanyName";
            this.lbSearchCompanyName.Size = new System.Drawing.Size(116, 20);
            this.lbSearchCompanyName.TabIndex = 0;
            this.lbSearchCompanyName.Text = "Company Name";
            // 
            // pnSearchProductID
            // 
            this.pnSearchProductID.Controls.Add(this.txtSearchMemberID);
            this.pnSearchProductID.Controls.Add(this.lbSearchMemberID);
            this.pnSearchProductID.Location = new System.Drawing.Point(33, 45);
            this.pnSearchProductID.Name = "pnSearchProductID";
            this.pnSearchProductID.Size = new System.Drawing.Size(313, 32);
            this.pnSearchProductID.TabIndex = 1;
            // 
            // txtSearchMemberID
            // 
            this.txtSearchMemberID.Location = new System.Drawing.Point(126, 0);
            this.txtSearchMemberID.Name = "txtSearchMemberID";
            this.txtSearchMemberID.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSearchMemberID.Size = new System.Drawing.Size(184, 27);
            this.txtSearchMemberID.TabIndex = 7;
            // 
            // lbSearchMemberID
            // 
            this.lbSearchMemberID.AutoSize = true;
            this.lbSearchMemberID.Location = new System.Drawing.Point(6, 3);
            this.lbSearchMemberID.Name = "lbSearchMemberID";
            this.lbSearchMemberID.Size = new System.Drawing.Size(84, 20);
            this.lbSearchMemberID.TabIndex = 0;
            this.lbSearchMemberID.Text = "Member ID";
            // 
            // pnButtons
            // 
            this.pnButtons.Controls.Add(this.btnDelete);
            this.pnButtons.Controls.Add(this.btnCreate);
            this.pnButtons.Controls.Add(this.btnLoad);
            this.pnButtons.Location = new System.Drawing.Point(247, 390);
            this.pnButtons.Name = "pnButtons";
            this.pnButtons.Size = new System.Drawing.Size(355, 47);
            this.pnButtons.TabIndex = 7;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(246, 6);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 29);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(122, 6);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(94, 29);
            this.btnCreate.TabIndex = 16;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(3, 6);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(94, 29);
            this.btnLoad.TabIndex = 15;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // pnInformationDetail2
            // 
            this.pnInformationDetail2.Controls.Add(this.pnWeight);
            this.pnInformationDetail2.Controls.Add(this.pnUnitInStock);
            this.pnInformationDetail2.Controls.Add(this.pnUnitPrice);
            this.pnInformationDetail2.Location = new System.Drawing.Point(465, 14);
            this.pnInformationDetail2.Name = "pnInformationDetail2";
            this.pnInformationDetail2.Size = new System.Drawing.Size(320, 153);
            this.pnInformationDetail2.TabIndex = 2;
            // 
            // pnWeight
            // 
            this.pnWeight.Controls.Add(this.txtCity);
            this.pnWeight.Controls.Add(this.lbCity);
            this.pnWeight.Location = new System.Drawing.Point(4, 3);
            this.pnWeight.Name = "pnWeight";
            this.pnWeight.Size = new System.Drawing.Size(313, 32);
            this.pnWeight.TabIndex = 3;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(126, 0);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(184, 27);
            this.txtCity.TabIndex = 4;
            // 
            // lbCity
            // 
            this.lbCity.AutoSize = true;
            this.lbCity.Location = new System.Drawing.Point(6, 3);
            this.lbCity.Name = "lbCity";
            this.lbCity.Size = new System.Drawing.Size(34, 20);
            this.lbCity.TabIndex = 0;
            this.lbCity.Text = "City";
            // 
            // pnUnitInStock
            // 
            this.pnUnitInStock.Controls.Add(this.txtPassword);
            this.pnUnitInStock.Controls.Add(this.lbPassword);
            this.pnUnitInStock.Location = new System.Drawing.Point(3, 118);
            this.pnUnitInStock.Name = "pnUnitInStock";
            this.pnUnitInStock.Size = new System.Drawing.Size(313, 32);
            this.pnUnitInStock.TabIndex = 5;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(126, 0);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(184, 27);
            this.txtPassword.TabIndex = 6;
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(6, 3);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(70, 20);
            this.lbPassword.TabIndex = 0;
            this.lbPassword.Text = "Password";
            // 
            // pnUnitPrice
            // 
            this.pnUnitPrice.Controls.Add(this.txtCountry);
            this.pnUnitPrice.Controls.Add(this.labCounty);
            this.pnUnitPrice.Location = new System.Drawing.Point(4, 60);
            this.pnUnitPrice.Name = "pnUnitPrice";
            this.pnUnitPrice.Size = new System.Drawing.Size(313, 32);
            this.pnUnitPrice.TabIndex = 4;
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(126, 0);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(184, 27);
            this.txtCountry.TabIndex = 5;
            // 
            // labCounty
            // 
            this.labCounty.AutoSize = true;
            this.labCounty.Location = new System.Drawing.Point(6, 3);
            this.labCounty.Name = "labCounty";
            this.labCounty.Size = new System.Drawing.Size(60, 20);
            this.labCounty.TabIndex = 0;
            this.labCounty.Text = "Country";
            // 
            // pnInformationDetail1
            // 
            this.pnInformationDetail1.Controls.Add(this.pnProductID);
            this.pnInformationDetail1.Controls.Add(this.pnCategoryID);
            this.pnInformationDetail1.Controls.Add(this.pnProductName);
            this.pnInformationDetail1.Location = new System.Drawing.Point(45, 14);
            this.pnInformationDetail1.Name = "pnInformationDetail1";
            this.pnInformationDetail1.Size = new System.Drawing.Size(317, 153);
            this.pnInformationDetail1.TabIndex = 6;
            // 
            // pnProductID
            // 
            this.pnProductID.Controls.Add(this.txtMemberID);
            this.pnProductID.Controls.Add(this.lbMemberID);
            this.pnProductID.Location = new System.Drawing.Point(2, 0);
            this.pnProductID.Name = "pnProductID";
            this.pnProductID.Size = new System.Drawing.Size(313, 32);
            this.pnProductID.TabIndex = 0;
            // 
            // txtMemberID
            // 
            this.txtMemberID.Location = new System.Drawing.Point(126, 0);
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.Size = new System.Drawing.Size(184, 27);
            this.txtMemberID.TabIndex = 1;
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
            // pnCategoryID
            // 
            this.pnCategoryID.Controls.Add(this.txtEmail);
            this.pnCategoryID.Controls.Add(this.lbEmail);
            this.pnCategoryID.Location = new System.Drawing.Point(1, 60);
            this.pnCategoryID.Name = "pnCategoryID";
            this.pnCategoryID.Size = new System.Drawing.Size(313, 32);
            this.pnCategoryID.TabIndex = 1;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(130, 0);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(184, 27);
            this.txtEmail.TabIndex = 2;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(6, 3);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(46, 20);
            this.lbEmail.TabIndex = 0;
            this.lbEmail.Text = "Email";
            // 
            // pnProductName
            // 
            this.pnProductName.Controls.Add(this.txtCompanyName);
            this.pnProductName.Controls.Add(this.lbProductName);
            this.pnProductName.Location = new System.Drawing.Point(1, 118);
            this.pnProductName.Name = "pnProductName";
            this.pnProductName.Size = new System.Drawing.Size(313, 32);
            this.pnProductName.TabIndex = 2;
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Location = new System.Drawing.Point(126, 0);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(184, 27);
            this.txtCompanyName.TabIndex = 3;
            // 
            // lbProductName
            // 
            this.lbProductName.AutoSize = true;
            this.lbProductName.Location = new System.Drawing.Point(6, 3);
            this.lbProductName.Name = "lbProductName";
            this.lbProductName.Size = new System.Drawing.Size(116, 20);
            this.lbProductName.TabIndex = 0;
            this.lbProductName.Text = "Company Name";
            // 
            // dgv_Member
            // 
            this.dgv_Member.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Member.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgv_Member.Location = new System.Drawing.Point(0, 487);
            this.dgv_Member.Name = "dgv_Member";
            this.dgv_Member.RowHeadersWidth = 51;
            this.dgv_Member.RowTemplate.Height = 29;
            this.dgv_Member.Size = new System.Drawing.Size(831, 282);
            this.dgv_Member.TabIndex = 19;
            this.dgv_Member.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Member_CellDoubleClick);
            // 
            // pnClose
            // 
            this.pnClose.Controls.Add(this.btnClose);
            this.pnClose.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnClose.Location = new System.Drawing.Point(0, 769);
            this.pnClose.Name = "pnClose";
            this.pnClose.Size = new System.Drawing.Size(831, 45);
            this.pnClose.TabIndex = 21;
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(367, 8);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(94, 29);
            this.btnClose.TabIndex = 20;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmMemberManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 811);
            this.Controls.Add(this.pnClose);
            this.Controls.Add(this.dgv_Member);
            this.Controls.Add(this.gbSearchAndFilter);
            this.Controls.Add(this.gbMenu);
            this.Name = "frmMemberManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Member Management";
            this.Load += new System.EventHandler(this.frmMemberManagement_Load);
            this.gbMenu.ResumeLayout(false);
            this.gbMenu.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbSearchAndFilter.ResumeLayout(false);
            this.gbFilter.ResumeLayout(false);
            this.pnSearchCity.ResumeLayout(false);
            this.pnSearchCity.PerformLayout();
            this.pnSearchCountry.ResumeLayout(false);
            this.pnSearchCountry.PerformLayout();
            this.gbSearch.ResumeLayout(false);
            this.pnSearchProductName.ResumeLayout(false);
            this.pnSearchProductName.PerformLayout();
            this.pnSearchProductID.ResumeLayout(false);
            this.pnSearchProductID.PerformLayout();
            this.pnButtons.ResumeLayout(false);
            this.pnInformationDetail2.ResumeLayout(false);
            this.pnWeight.ResumeLayout(false);
            this.pnWeight.PerformLayout();
            this.pnUnitInStock.ResumeLayout(false);
            this.pnUnitInStock.PerformLayout();
            this.pnUnitPrice.ResumeLayout(false);
            this.pnUnitPrice.PerformLayout();
            this.pnInformationDetail1.ResumeLayout(false);
            this.pnProductID.ResumeLayout(false);
            this.pnProductID.PerformLayout();
            this.pnCategoryID.ResumeLayout(false);
            this.pnCategoryID.PerformLayout();
            this.pnProductName.ResumeLayout(false);
            this.pnProductName.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Member)).EndInit();
            this.pnClose.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbMenu;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuManagement;
        private System.Windows.Forms.ToolStripMenuItem MenuOrderItem;
        private System.Windows.Forms.ToolStripMenuItem MenuProductItem;
        private System.Windows.Forms.ToolStripMenuItem MenuExitItem;
        private System.Windows.Forms.GroupBox gbSearchAndFilter;
        private System.Windows.Forms.GroupBox gbSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel pnSearchProductName;
        private System.Windows.Forms.TextBox txtSearchCompanyName;
        private System.Windows.Forms.Label lbSearchCompanyName;
        private System.Windows.Forms.Panel pnSearchProductID;
        private System.Windows.Forms.TextBox txtSearchMemberID;
        private System.Windows.Forms.Label lbSearchMemberID;
        private System.Windows.Forms.Panel pnButtons;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Panel pnInformationDetail2;
        private System.Windows.Forms.Panel pnWeight;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lbCity;
        private System.Windows.Forms.Panel pnUnitInStock;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Panel pnUnitPrice;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.Label labCounty;
        private System.Windows.Forms.Panel pnInformationDetail1;
        private System.Windows.Forms.Panel pnProductID;
        private System.Windows.Forms.TextBox txtMemberID;
        private System.Windows.Forms.Label lbMemberID;
        private System.Windows.Forms.Panel pnCategoryID;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Panel pnProductName;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.Label lbProductName;
        private System.Windows.Forms.DataGridView dgv_Member;
        private System.Windows.Forms.Panel pnClose;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox gbFilter;
        private System.Windows.Forms.Panel pnSearchCity;
        private System.Windows.Forms.ComboBox cboSearchCity;
        private System.Windows.Forms.Label lbSearchCity;
        private System.Windows.Forms.Panel pnSearchCountry;
        private System.Windows.Forms.ComboBox cboSearchCountry;
        private System.Windows.Forms.Label lbSearchCountry;
    }
}