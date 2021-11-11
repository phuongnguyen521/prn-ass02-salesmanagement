
namespace SaleFormsApp.Orders
{
    partial class frmOrderExport
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
            this.gbSearch = new System.Windows.Forms.GroupBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.pnSearchProductName = new System.Windows.Forms.Panel();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.lbSearchEndDate = new System.Windows.Forms.Label();
            this.pnSearchProductID = new System.Windows.Forms.Panel();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.lbSearchStartDate = new System.Windows.Forms.Label();
            this.dgv_Order = new System.Windows.Forms.DataGridView();
            this.gbSearch.SuspendLayout();
            this.pnSearchProductName.SuspendLayout();
            this.pnSearchProductID.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Order)).BeginInit();
            this.SuspendLayout();
            // 
            // gbSearch
            // 
            this.gbSearch.Controls.Add(this.btnExport);
            this.gbSearch.Controls.Add(this.btnSearch);
            this.gbSearch.Controls.Add(this.pnSearchProductName);
            this.gbSearch.Controls.Add(this.pnSearchProductID);
            this.gbSearch.Location = new System.Drawing.Point(0, 0);
            this.gbSearch.Name = "gbSearch";
            this.gbSearch.Size = new System.Drawing.Size(840, 134);
            this.gbSearch.TabIndex = 9;
            this.gbSearch.TabStop = false;
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(444, 99);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(94, 29);
            this.btnExport.TabIndex = 4;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(286, 99);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(94, 29);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // pnSearchProductName
            // 
            this.pnSearchProductName.Controls.Add(this.dtpEndDate);
            this.pnSearchProductName.Controls.Add(this.lbSearchEndDate);
            this.pnSearchProductName.Location = new System.Drawing.Point(444, 43);
            this.pnSearchProductName.Name = "pnSearchProductName";
            this.pnSearchProductName.Size = new System.Drawing.Size(354, 32);
            this.pnSearchProductName.TabIndex = 2;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(113, 2);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(238, 27);
            this.dtpEndDate.TabIndex = 2;
            // 
            // lbSearchEndDate
            // 
            this.lbSearchEndDate.AutoSize = true;
            this.lbSearchEndDate.Location = new System.Drawing.Point(6, 3);
            this.lbSearchEndDate.Name = "lbSearchEndDate";
            this.lbSearchEndDate.Size = new System.Drawing.Size(70, 20);
            this.lbSearchEndDate.TabIndex = 0;
            this.lbSearchEndDate.Text = "End Date";
            // 
            // pnSearchProductID
            // 
            this.pnSearchProductID.Controls.Add(this.dtpStartDate);
            this.pnSearchProductID.Controls.Add(this.lbSearchStartDate);
            this.pnSearchProductID.Location = new System.Drawing.Point(26, 43);
            this.pnSearchProductID.Name = "pnSearchProductID";
            this.pnSearchProductID.Size = new System.Drawing.Size(354, 32);
            this.pnSearchProductID.TabIndex = 1;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(116, 2);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(238, 27);
            this.dtpStartDate.TabIndex = 1;
            // 
            // lbSearchStartDate
            // 
            this.lbSearchStartDate.AutoSize = true;
            this.lbSearchStartDate.Location = new System.Drawing.Point(6, 3);
            this.lbSearchStartDate.Name = "lbSearchStartDate";
            this.lbSearchStartDate.Size = new System.Drawing.Size(76, 20);
            this.lbSearchStartDate.TabIndex = 0;
            this.lbSearchStartDate.Text = "Start Date";
            // 
            // dgv_Order
            // 
            this.dgv_Order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Order.Location = new System.Drawing.Point(0, 134);
            this.dgv_Order.Name = "dgv_Order";
            this.dgv_Order.RowHeadersWidth = 51;
            this.dgv_Order.RowTemplate.Height = 29;
            this.dgv_Order.Size = new System.Drawing.Size(840, 333);
            this.dgv_Order.TabIndex = 5;
            // 
            // frmOrderExport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 469);
            this.Controls.Add(this.dgv_Order);
            this.Controls.Add(this.gbSearch);
            this.Name = "frmOrderExport";
            this.Text = "frmOrderExport";
            this.Load += new System.EventHandler(this.frmOrderExport_Load);
            this.gbSearch.ResumeLayout(false);
            this.pnSearchProductName.ResumeLayout(false);
            this.pnSearchProductName.PerformLayout();
            this.pnSearchProductID.ResumeLayout(false);
            this.pnSearchProductID.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Order)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSearch;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel pnSearchProductName;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label lbSearchEndDate;
        private System.Windows.Forms.Panel pnSearchProductID;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label lbSearchStartDate;
        private System.Windows.Forms.DataGridView dgv_Order;
    }
}