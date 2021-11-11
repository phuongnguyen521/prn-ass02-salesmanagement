
namespace SaleFormsApp
{
    partial class frmProductDetail
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
            this.gbProductInformation = new System.Windows.Forms.GroupBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusProductDetail = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnUnitInStock = new System.Windows.Forms.Panel();
            this.nupUnitInStock = new System.Windows.Forms.NumericUpDown();
            this.lbUnitInStock = new System.Windows.Forms.Label();
            this.pnWeight = new System.Windows.Forms.Panel();
            this.nupWeight = new System.Windows.Forms.NumericUpDown();
            this.lbWeight = new System.Windows.Forms.Label();
            this.pnUnitPrice = new System.Windows.Forms.Panel();
            this.nupUnitPrice = new System.Windows.Forms.NumericUpDown();
            this.labUnitPrice = new System.Windows.Forms.Label();
            this.pnCategoryID = new System.Windows.Forms.Panel();
            this.cbCategoryID = new System.Windows.Forms.ComboBox();
            this.lbCategoryID = new System.Windows.Forms.Label();
            this.pnProductID = new System.Windows.Forms.Panel();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.lbProductID = new System.Windows.Forms.Label();
            this.pnProductName = new System.Windows.Forms.Panel();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.lbProductName = new System.Windows.Forms.Label();
            this.gbButtons = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.gbProductInformation.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.pnUnitInStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupUnitInStock)).BeginInit();
            this.pnWeight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupWeight)).BeginInit();
            this.pnUnitPrice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupUnitPrice)).BeginInit();
            this.pnCategoryID.SuspendLayout();
            this.pnProductID.SuspendLayout();
            this.pnProductName.SuspendLayout();
            this.gbButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbProductInformation
            // 
            this.gbProductInformation.Controls.Add(this.statusStrip1);
            this.gbProductInformation.Controls.Add(this.pnUnitInStock);
            this.gbProductInformation.Controls.Add(this.pnWeight);
            this.gbProductInformation.Controls.Add(this.pnUnitPrice);
            this.gbProductInformation.Controls.Add(this.pnCategoryID);
            this.gbProductInformation.Controls.Add(this.pnProductID);
            this.gbProductInformation.Controls.Add(this.pnProductName);
            this.gbProductInformation.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbProductInformation.Location = new System.Drawing.Point(0, 0);
            this.gbProductInformation.Name = "gbProductInformation";
            this.gbProductInformation.Size = new System.Drawing.Size(374, 401);
            this.gbProductInformation.TabIndex = 0;
            this.gbProductInformation.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusProductDetail});
            this.statusStrip1.Location = new System.Drawing.Point(3, 376);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(368, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusProductDetail
            // 
            this.statusProductDetail.Name = "statusProductDetail";
            this.statusProductDetail.Size = new System.Drawing.Size(0, 16);
            // 
            // pnUnitInStock
            // 
            this.pnUnitInStock.Controls.Add(this.nupUnitInStock);
            this.pnUnitInStock.Controls.Add(this.lbUnitInStock);
            this.pnUnitInStock.Location = new System.Drawing.Point(23, 329);
            this.pnUnitInStock.Name = "pnUnitInStock";
            this.pnUnitInStock.Size = new System.Drawing.Size(313, 32);
            this.pnUnitInStock.TabIndex = 5;
            // 
            // nupUnitInStock
            // 
            this.nupUnitInStock.Location = new System.Drawing.Point(125, 3);
            this.nupUnitInStock.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nupUnitInStock.Name = "nupUnitInStock";
            this.nupUnitInStock.Size = new System.Drawing.Size(188, 27);
            this.nupUnitInStock.TabIndex = 6;
            this.nupUnitInStock.Click += new System.EventHandler(this.nupUnitInStock_Click);
            // 
            // lbUnitInStock
            // 
            this.lbUnitInStock.AutoSize = true;
            this.lbUnitInStock.Location = new System.Drawing.Point(6, 3);
            this.lbUnitInStock.Name = "lbUnitInStock";
            this.lbUnitInStock.Size = new System.Drawing.Size(92, 20);
            this.lbUnitInStock.TabIndex = 0;
            this.lbUnitInStock.Text = "Unit In Stock";
            // 
            // pnWeight
            // 
            this.pnWeight.Controls.Add(this.nupWeight);
            this.pnWeight.Controls.Add(this.lbWeight);
            this.pnWeight.Location = new System.Drawing.Point(23, 196);
            this.pnWeight.Name = "pnWeight";
            this.pnWeight.Size = new System.Drawing.Size(313, 32);
            this.pnWeight.TabIndex = 3;
            // 
            // nupWeight
            // 
            this.nupWeight.Location = new System.Drawing.Point(126, 0);
            this.nupWeight.Name = "nupWeight";
            this.nupWeight.Size = new System.Drawing.Size(184, 27);
            this.nupWeight.TabIndex = 4;
            this.nupWeight.Click += new System.EventHandler(this.nupWeight_Click);
            // 
            // lbWeight
            // 
            this.lbWeight.AutoSize = true;
            this.lbWeight.Location = new System.Drawing.Point(6, 3);
            this.lbWeight.Name = "lbWeight";
            this.lbWeight.Size = new System.Drawing.Size(56, 20);
            this.lbWeight.TabIndex = 0;
            this.lbWeight.Text = "Weight";
            // 
            // pnUnitPrice
            // 
            this.pnUnitPrice.Controls.Add(this.nupUnitPrice);
            this.pnUnitPrice.Controls.Add(this.labUnitPrice);
            this.pnUnitPrice.Location = new System.Drawing.Point(23, 263);
            this.pnUnitPrice.Name = "pnUnitPrice";
            this.pnUnitPrice.Size = new System.Drawing.Size(313, 32);
            this.pnUnitPrice.TabIndex = 4;
            // 
            // nupUnitPrice
            // 
            this.nupUnitPrice.DecimalPlaces = 2;
            this.nupUnitPrice.Location = new System.Drawing.Point(125, 5);
            this.nupUnitPrice.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nupUnitPrice.Name = "nupUnitPrice";
            this.nupUnitPrice.Size = new System.Drawing.Size(184, 27);
            this.nupUnitPrice.TabIndex = 5;
            this.nupUnitPrice.Click += new System.EventHandler(this.nupUnitPrice_Click);
            // 
            // labUnitPrice
            // 
            this.labUnitPrice.AutoSize = true;
            this.labUnitPrice.Location = new System.Drawing.Point(6, 3);
            this.labUnitPrice.Name = "labUnitPrice";
            this.labUnitPrice.Size = new System.Drawing.Size(72, 20);
            this.labUnitPrice.TabIndex = 0;
            this.labUnitPrice.Text = "Unit Price";
            // 
            // pnCategoryID
            // 
            this.pnCategoryID.Controls.Add(this.cbCategoryID);
            this.pnCategoryID.Controls.Add(this.lbCategoryID);
            this.pnCategoryID.Location = new System.Drawing.Point(23, 134);
            this.pnCategoryID.Name = "pnCategoryID";
            this.pnCategoryID.Size = new System.Drawing.Size(314, 32);
            this.pnCategoryID.TabIndex = 1;
            // 
            // cbCategoryID
            // 
            this.cbCategoryID.FormattingEnabled = true;
            this.cbCategoryID.Items.AddRange(new object[] {
            "None",
            "1",
            "2",
            "3"});
            this.cbCategoryID.Location = new System.Drawing.Point(126, 0);
            this.cbCategoryID.Name = "cbCategoryID";
            this.cbCategoryID.Size = new System.Drawing.Size(184, 28);
            this.cbCategoryID.TabIndex = 3;
            this.cbCategoryID.Click += new System.EventHandler(this.cbCategoryID_Click);
            // 
            // lbCategoryID
            // 
            this.lbCategoryID.AutoSize = true;
            this.lbCategoryID.Location = new System.Drawing.Point(6, 3);
            this.lbCategoryID.Name = "lbCategoryID";
            this.lbCategoryID.Size = new System.Drawing.Size(88, 20);
            this.lbCategoryID.TabIndex = 0;
            this.lbCategoryID.Text = "Category ID";
            // 
            // pnProductID
            // 
            this.pnProductID.Controls.Add(this.txtProductID);
            this.pnProductID.Controls.Add(this.lbProductID);
            this.pnProductID.Location = new System.Drawing.Point(23, 11);
            this.pnProductID.Name = "pnProductID";
            this.pnProductID.Size = new System.Drawing.Size(313, 32);
            this.pnProductID.TabIndex = 0;
            // 
            // txtProductID
            // 
            this.txtProductID.Location = new System.Drawing.Point(126, 0);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(184, 27);
            this.txtProductID.TabIndex = 1;
            this.txtProductID.MouseHover += new System.EventHandler(this.txtProductID_MouseHover);
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
            this.pnProductName.Controls.Add(this.txtProductName);
            this.pnProductName.Controls.Add(this.lbProductName);
            this.pnProductName.Location = new System.Drawing.Point(23, 71);
            this.pnProductName.Name = "pnProductName";
            this.pnProductName.Size = new System.Drawing.Size(313, 32);
            this.pnProductName.TabIndex = 2;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(126, 0);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(184, 27);
            this.txtProductName.TabIndex = 2;
            this.txtProductName.MouseHover += new System.EventHandler(this.txtProductName_MouseHover);
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
            // gbButtons
            // 
            this.gbButtons.Controls.Add(this.btnCancel);
            this.gbButtons.Controls.Add(this.btnSave);
            this.gbButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbButtons.Location = new System.Drawing.Point(0, 401);
            this.gbButtons.Name = "gbButtons";
            this.gbButtons.Size = new System.Drawing.Size(374, 54);
            this.gbButtons.TabIndex = 1;
            this.gbButtons.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(199, 19);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 29);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(65, 19);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 29);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmProductDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 470);
            this.Controls.Add(this.gbButtons);
            this.Controls.Add(this.gbProductInformation);
            this.Name = "frmProductDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product Detail";
            this.Load += new System.EventHandler(this.frmProductDetail_Load);
            this.MouseHover += new System.EventHandler(this.frmProductDetail_MouseHover);
            this.gbProductInformation.ResumeLayout(false);
            this.gbProductInformation.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.pnUnitInStock.ResumeLayout(false);
            this.pnUnitInStock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupUnitInStock)).EndInit();
            this.pnWeight.ResumeLayout(false);
            this.pnWeight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupWeight)).EndInit();
            this.pnUnitPrice.ResumeLayout(false);
            this.pnUnitPrice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupUnitPrice)).EndInit();
            this.pnCategoryID.ResumeLayout(false);
            this.pnCategoryID.PerformLayout();
            this.pnProductID.ResumeLayout(false);
            this.pnProductID.PerformLayout();
            this.pnProductName.ResumeLayout(false);
            this.pnProductName.PerformLayout();
            this.gbButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbProductInformation;
        private System.Windows.Forms.Panel pnCategoryID;
        private System.Windows.Forms.Label lbCategoryID;
        private System.Windows.Forms.Panel pnProductID;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.Label lbProductID;
        private System.Windows.Forms.Panel pnProductName;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label lbProductName;
        private System.Windows.Forms.Panel pnUnitInStock;
        private System.Windows.Forms.Label lbUnitInStock;
        private System.Windows.Forms.Panel pnWeight;
        private System.Windows.Forms.Label lbWeight;
        private System.Windows.Forms.Panel pnUnitPrice;
        private System.Windows.Forms.Label labUnitPrice;
        private System.Windows.Forms.ComboBox cbCategoryID;
        private System.Windows.Forms.NumericUpDown nupUnitInStock;
        private System.Windows.Forms.NumericUpDown nupWeight;
        private System.Windows.Forms.NumericUpDown nupUnitPrice;
        private System.Windows.Forms.GroupBox gbButtons;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusProductDetail;
    }
}