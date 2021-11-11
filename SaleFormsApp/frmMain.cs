using SaleFormsApp.Mappers;
using System;
using System.Windows.Forms;

namespace SaleFormsApp
{
    public partial class frmMain : Form
    {
        #region Initialized Objects
        private Form activeChildForm = null;
        public MemberDto loginUser { get; set; }
        #endregion
        public frmMain()
        {
            InitializeComponent();
        }

        #region Load and Check
        private bool IsAdmin()
        => loginUser.Email.Equals("admin@fstore.com");
        public void openChildForm(Form childForm)
        {
            if (activeChildForm != null)
                activeChildForm.Close();
            activeChildForm = childForm;
            childForm.TopLevel = false;
            flpDisplay.Controls.Add(childForm);
            flpDisplay.AutoScroll = true;
            flpDisplay.Tag = childForm;
            childForm.Show();
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            if (IsAdmin() == false)
            {
                MenuProductMainItem.Visible = false;
                MenuMemberMainItem.Text = "Profile";
                MenuOrderMainItem.Text = "History Order";
            }
        }
        #endregion

        #region Menu Item
        private void MenuMemberMainItem_Click(object sender, EventArgs e)
        {
            if (IsAdmin())
            {
                openChildForm(new frmMemberManagement()
                {
                    loginUser = loginUser
                });
            } else
            {
                openChildForm(new frmMemberDetail()
                {
                    Text = "Update a member",
                    loginUser = loginUser,
                    user = loginUser,
                    CreateOrUpdate = false, //Insert: true, Update: false
                });
            }
        }

        private void MenuExitMainItem_Click(object sender, EventArgs e)
        => Close();

        private void MenuOrderMainItem_Click(object sender, EventArgs e)
        {
            openChildForm(new frmOrderManagement() { loginUser = loginUser});
        }

        private void MenuProductMainItem_Click(object sender, EventArgs e)
        {
            openChildForm(new frmProductManagement() { loginUser = loginUser });
        }
        #endregion

    }
}
