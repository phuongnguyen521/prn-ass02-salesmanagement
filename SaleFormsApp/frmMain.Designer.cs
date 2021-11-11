
namespace SaleFormsApp
{
    partial class frmMain
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
            this.MenuMemberMainItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuOrderMainItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuProductMainItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuExitMainItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flpDisplay = new System.Windows.Forms.FlowLayoutPanel();
            this.gbMenu.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbMenu
            // 
            this.gbMenu.Controls.Add(this.menuStrip1);
            this.gbMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbMenu.Location = new System.Drawing.Point(0, 0);
            this.gbMenu.Name = "gbMenu";
            this.gbMenu.Size = new System.Drawing.Size(1159, 50);
            this.gbMenu.TabIndex = 3;
            this.gbMenu.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuManagement});
            this.menuStrip1.Location = new System.Drawing.Point(3, 23);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1153, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuManagement
            // 
            this.MenuManagement.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.MenuManagement.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuMemberMainItem,
            this.MenuOrderMainItem,
            this.MenuProductMainItem,
            this.MenuExitMainItem});
            this.MenuManagement.Name = "MenuManagement";
            this.MenuManagement.Size = new System.Drawing.Size(60, 24);
            this.MenuManagement.Text = "Menu";
            // 
            // MenuMemberMainItem
            // 
            this.MenuMemberMainItem.Name = "MenuMemberMainItem";
            this.MenuMemberMainItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.MenuMemberMainItem.Size = new System.Drawing.Size(295, 26);
            this.MenuMemberMainItem.Text = "Member Management";
            this.MenuMemberMainItem.Click += new System.EventHandler(this.MenuMemberMainItem_Click);
            // 
            // MenuOrderMainItem
            // 
            this.MenuOrderMainItem.Name = "MenuOrderMainItem";
            this.MenuOrderMainItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.MenuOrderMainItem.Size = new System.Drawing.Size(295, 26);
            this.MenuOrderMainItem.Text = "Order Management";
            this.MenuOrderMainItem.Click += new System.EventHandler(this.MenuOrderMainItem_Click);
            // 
            // MenuProductMainItem
            // 
            this.MenuProductMainItem.Name = "MenuProductMainItem";
            this.MenuProductMainItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.MenuProductMainItem.Size = new System.Drawing.Size(295, 26);
            this.MenuProductMainItem.Text = "Product Management";
            this.MenuProductMainItem.Click += new System.EventHandler(this.MenuProductMainItem_Click);
            // 
            // MenuExitMainItem
            // 
            this.MenuExitMainItem.Name = "MenuExitMainItem";
            this.MenuExitMainItem.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.MenuExitMainItem.Size = new System.Drawing.Size(295, 26);
            this.MenuExitMainItem.Text = "Exit";
            this.MenuExitMainItem.Click += new System.EventHandler(this.MenuExitMainItem_Click);
            // 
            // flpDisplay
            // 
            this.flpDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpDisplay.Location = new System.Drawing.Point(0, 50);
            this.flpDisplay.Name = "flpDisplay";
            this.flpDisplay.Size = new System.Drawing.Size(1159, 784);
            this.flpDisplay.TabIndex = 1;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 834);
            this.Controls.Add(this.flpDisplay);
            this.Controls.Add(this.gbMenu);
            this.Name = "frmMain";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.gbMenu.ResumeLayout(false);
            this.gbMenu.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbMenu;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuManagement;
        private System.Windows.Forms.ToolStripMenuItem MenuMemberMainItem;
        private System.Windows.Forms.ToolStripMenuItem MenuOrderMainItem;
        private System.Windows.Forms.ToolStripMenuItem MenuProductMainItem;
        private System.Windows.Forms.ToolStripMenuItem MenuExitMainItem;
        private System.Windows.Forms.FlowLayoutPanel flpDisplay;
    }
}