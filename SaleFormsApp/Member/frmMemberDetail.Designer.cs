
namespace SaleFormsApp
{
    partial class frmMemberDetail
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
            this.statusMemberDetail = new System.Windows.Forms.StatusStrip();
            this.statusProductDetail = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnPassword = new System.Windows.Forms.Panel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lbUnitInStock = new System.Windows.Forms.Label();
            this.pnCity = new System.Windows.Forms.Panel();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lbWeight = new System.Windows.Forms.Label();
            this.pnCountry = new System.Windows.Forms.Panel();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.labUnitPrice = new System.Windows.Forms.Label();
            this.pnCompanyName = new System.Windows.Forms.Panel();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.lbCategoryID = new System.Windows.Forms.Label();
            this.pnMemberID = new System.Windows.Forms.Panel();
            this.txtMemberID = new System.Windows.Forms.TextBox();
            this.lbProductID = new System.Windows.Forms.Label();
            this.pnEmail = new System.Windows.Forms.Panel();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lbProductName = new System.Windows.Forms.Label();
            this.gbButtons = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.gbProductInformation.SuspendLayout();
            this.statusMemberDetail.SuspendLayout();
            this.pnPassword.SuspendLayout();
            this.pnCity.SuspendLayout();
            this.pnCountry.SuspendLayout();
            this.pnCompanyName.SuspendLayout();
            this.pnMemberID.SuspendLayout();
            this.pnEmail.SuspendLayout();
            this.gbButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbProductInformation
            // 
            this.gbProductInformation.Controls.Add(this.statusMemberDetail);
            this.gbProductInformation.Controls.Add(this.pnPassword);
            this.gbProductInformation.Controls.Add(this.pnCity);
            this.gbProductInformation.Controls.Add(this.pnCountry);
            this.gbProductInformation.Controls.Add(this.pnCompanyName);
            this.gbProductInformation.Controls.Add(this.pnMemberID);
            this.gbProductInformation.Controls.Add(this.pnEmail);
            this.gbProductInformation.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbProductInformation.Location = new System.Drawing.Point(0, 0);
            this.gbProductInformation.Name = "gbProductInformation";
            this.gbProductInformation.Size = new System.Drawing.Size(374, 401);
            this.gbProductInformation.TabIndex = 1;
            this.gbProductInformation.TabStop = false;
            // 
            // statusMemberDetail
            // 
            this.statusMemberDetail.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusMemberDetail.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusProductDetail});
            this.statusMemberDetail.Location = new System.Drawing.Point(3, 376);
            this.statusMemberDetail.Name = "statusMemberDetail";
            this.statusMemberDetail.Size = new System.Drawing.Size(368, 22);
            this.statusMemberDetail.TabIndex = 6;
            // 
            // statusProductDetail
            // 
            this.statusProductDetail.Name = "statusProductDetail";
            this.statusProductDetail.Size = new System.Drawing.Size(0, 18);
            // 
            // pnPassword
            // 
            this.pnPassword.Controls.Add(this.txtPassword);
            this.pnPassword.Controls.Add(this.lbUnitInStock);
            this.pnPassword.Location = new System.Drawing.Point(23, 329);
            this.pnPassword.Name = "pnPassword";
            this.pnPassword.Size = new System.Drawing.Size(313, 32);
            this.pnPassword.TabIndex = 5;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(126, 3);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(184, 27);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.MouseHover += new System.EventHandler(this.txtPassword_MouseHover);
            // 
            // lbUnitInStock
            // 
            this.lbUnitInStock.AutoSize = true;
            this.lbUnitInStock.Location = new System.Drawing.Point(6, 3);
            this.lbUnitInStock.Name = "lbUnitInStock";
            this.lbUnitInStock.Size = new System.Drawing.Size(70, 20);
            this.lbUnitInStock.TabIndex = 0;
            this.lbUnitInStock.Text = "Password";
            // 
            // pnCity
            // 
            this.pnCity.Controls.Add(this.txtCity);
            this.pnCity.Controls.Add(this.lbWeight);
            this.pnCity.Location = new System.Drawing.Point(23, 196);
            this.pnCity.Name = "pnCity";
            this.pnCity.Size = new System.Drawing.Size(313, 32);
            this.pnCity.TabIndex = 3;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(126, 2);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(184, 27);
            this.txtCity.TabIndex = 4;
            this.txtCity.MouseHover += new System.EventHandler(this.txtCity_MouseHover);
            // 
            // lbWeight
            // 
            this.lbWeight.AutoSize = true;
            this.lbWeight.Location = new System.Drawing.Point(6, 3);
            this.lbWeight.Name = "lbWeight";
            this.lbWeight.Size = new System.Drawing.Size(34, 20);
            this.lbWeight.TabIndex = 0;
            this.lbWeight.Text = "City";
            // 
            // pnCountry
            // 
            this.pnCountry.Controls.Add(this.txtCountry);
            this.pnCountry.Controls.Add(this.labUnitPrice);
            this.pnCountry.Location = new System.Drawing.Point(23, 263);
            this.pnCountry.Name = "pnCountry";
            this.pnCountry.Size = new System.Drawing.Size(313, 32);
            this.pnCountry.TabIndex = 4;
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(126, 2);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(184, 27);
            this.txtCountry.TabIndex = 4;
            this.txtCountry.MouseHover += new System.EventHandler(this.txtCountry_MouseHover);
            // 
            // labUnitPrice
            // 
            this.labUnitPrice.AutoSize = true;
            this.labUnitPrice.Location = new System.Drawing.Point(6, 3);
            this.labUnitPrice.Name = "labUnitPrice";
            this.labUnitPrice.Size = new System.Drawing.Size(60, 20);
            this.labUnitPrice.TabIndex = 0;
            this.labUnitPrice.Text = "Country";
            // 
            // pnCompanyName
            // 
            this.pnCompanyName.Controls.Add(this.txtCompanyName);
            this.pnCompanyName.Controls.Add(this.lbCategoryID);
            this.pnCompanyName.Location = new System.Drawing.Point(23, 134);
            this.pnCompanyName.Name = "pnCompanyName";
            this.pnCompanyName.Size = new System.Drawing.Size(314, 32);
            this.pnCompanyName.TabIndex = 1;
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Location = new System.Drawing.Point(129, 0);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(184, 27);
            this.txtCompanyName.TabIndex = 3;
            this.txtCompanyName.MouseHover += new System.EventHandler(this.txtCompanyName_MouseHover);
            // 
            // lbCategoryID
            // 
            this.lbCategoryID.AutoSize = true;
            this.lbCategoryID.Location = new System.Drawing.Point(6, 3);
            this.lbCategoryID.Name = "lbCategoryID";
            this.lbCategoryID.Size = new System.Drawing.Size(116, 20);
            this.lbCategoryID.TabIndex = 0;
            this.lbCategoryID.Text = "Company Name";
            // 
            // pnMemberID
            // 
            this.pnMemberID.Controls.Add(this.txtMemberID);
            this.pnMemberID.Controls.Add(this.lbProductID);
            this.pnMemberID.Location = new System.Drawing.Point(23, 11);
            this.pnMemberID.Name = "pnMemberID";
            this.pnMemberID.Size = new System.Drawing.Size(313, 32);
            this.pnMemberID.TabIndex = 0;
            // 
            // txtMemberID
            // 
            this.txtMemberID.Location = new System.Drawing.Point(126, 0);
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.Size = new System.Drawing.Size(184, 27);
            this.txtMemberID.TabIndex = 1;
            this.txtMemberID.MouseHover += new System.EventHandler(this.txtMemberID_MouseHover);
            // 
            // lbProductID
            // 
            this.lbProductID.AutoSize = true;
            this.lbProductID.Location = new System.Drawing.Point(6, 3);
            this.lbProductID.Name = "lbProductID";
            this.lbProductID.Size = new System.Drawing.Size(84, 20);
            this.lbProductID.TabIndex = 0;
            this.lbProductID.Text = "Member ID";
            // 
            // pnEmail
            // 
            this.pnEmail.Controls.Add(this.txtEmail);
            this.pnEmail.Controls.Add(this.lbProductName);
            this.pnEmail.Location = new System.Drawing.Point(23, 71);
            this.pnEmail.Name = "pnEmail";
            this.pnEmail.Size = new System.Drawing.Size(313, 32);
            this.pnEmail.TabIndex = 2;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(126, 0);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(184, 27);
            this.txtEmail.TabIndex = 2;
            this.txtEmail.MouseHover += new System.EventHandler(this.txtEmail_MouseHover);
            // 
            // lbProductName
            // 
            this.lbProductName.AutoSize = true;
            this.lbProductName.Location = new System.Drawing.Point(6, 3);
            this.lbProductName.Name = "lbProductName";
            this.lbProductName.Size = new System.Drawing.Size(46, 20);
            this.lbProductName.TabIndex = 0;
            this.lbProductName.Text = "Email";
            // 
            // gbButtons
            // 
            this.gbButtons.Controls.Add(this.btnCancel);
            this.gbButtons.Controls.Add(this.btnSave);
            this.gbButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbButtons.Location = new System.Drawing.Point(0, 401);
            this.gbButtons.Name = "gbButtons";
            this.gbButtons.Size = new System.Drawing.Size(374, 54);
            this.gbButtons.TabIndex = 2;
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
            // frmMemberDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 470);
            this.Controls.Add(this.gbButtons);
            this.Controls.Add(this.gbProductInformation);
            this.Name = "frmMemberDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Member Detail";
            this.Load += new System.EventHandler(this.frmMemberDetail_Load);
            this.MouseHover += new System.EventHandler(this.frmMemberDetail_MouseHover);
            this.gbProductInformation.ResumeLayout(false);
            this.gbProductInformation.PerformLayout();
            this.statusMemberDetail.ResumeLayout(false);
            this.statusMemberDetail.PerformLayout();
            this.pnPassword.ResumeLayout(false);
            this.pnPassword.PerformLayout();
            this.pnCity.ResumeLayout(false);
            this.pnCity.PerformLayout();
            this.pnCountry.ResumeLayout(false);
            this.pnCountry.PerformLayout();
            this.pnCompanyName.ResumeLayout(false);
            this.pnCompanyName.PerformLayout();
            this.pnMemberID.ResumeLayout(false);
            this.pnMemberID.PerformLayout();
            this.pnEmail.ResumeLayout(false);
            this.pnEmail.PerformLayout();
            this.gbButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbProductInformation;
        private System.Windows.Forms.StatusStrip statusMemberDetail;
        private System.Windows.Forms.ToolStripStatusLabel statusProductDetail;
        private System.Windows.Forms.Panel pnPassword;
        private System.Windows.Forms.Label lbUnitInStock;
        private System.Windows.Forms.Panel pnCity;
        private System.Windows.Forms.Label lbWeight;
        private System.Windows.Forms.Panel pnCountry;
        private System.Windows.Forms.Label labUnitPrice;
        private System.Windows.Forms.Panel pnCompanyName;
        private System.Windows.Forms.Label lbCategoryID;
        private System.Windows.Forms.Panel pnMemberID;
        private System.Windows.Forms.TextBox txtMemberID;
        private System.Windows.Forms.Label lbProductID;
        private System.Windows.Forms.Panel pnEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lbProductName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.GroupBox gbButtons;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
    }
}