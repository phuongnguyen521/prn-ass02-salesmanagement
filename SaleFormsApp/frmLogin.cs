using AutoMapper;
using BusinessObject.Object;
using DataAccess.Errors;
using DataAccess.Repository;
using SaleFormsApp.Mappers;
using System;
using System.Windows.Forms;

namespace SaleFormsApp
{
    public partial class frmLogin : Form
    {
        #region Initialized parameters
        // Intialize membeRepository for function
        public IMemberRepository memberRepository = new MemberRepository();
        private IMemberValidationRepository generalValidation = new MemberValidationRepository();
        private MemberErrors memberErrors = null;
        private IMapper mapper;
        #endregion
        public frmLogin()
        {
            InitializeComponent();
            var config = new MapperConfiguration(cfg => 
            {
                cfg.AddProfile(new MappingProfile());
            });
            mapper = config.CreateMapper();
        }

        #region Event
        private void LoadfrmLogin()
        {
            txtEmail.Text = String.Empty;
            txtPassword.Text = String.Empty;
            txtPassword.UseSystemPasswordChar = true;
            cbShowHide.Checked = false;
        }
        private bool checkValidationUser(Member member)
        {
            bool result = false;
            memberErrors = null;
            memberErrors = new MemberErrors();
            memberErrors.emailError = generalValidation.checkMemberEmail(member.Email, false);
            memberErrors.passwordError = generalValidation.checkMemberPassword(member.Password, false);
            return result = memberErrors.emailError == null && memberErrors.passwordError == null;
        }
        public bool checkLoginIn(Member member)
        {
            bool result = false;
            if (member != null)
            {
                MessageBox.Show("Login Successfully", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                result = true;
            }
            else if (member == null)
            {
                MessageBox.Show("User does not exist!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return result;
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            Member TempMember = new Member
            {
                Email = email,
                Password = password
            };
            if (checkValidationUser(TempMember))
            {
                Member member = memberRepository.Login(email, password);
                MemberDto loginUser = mapper.Map<Member, MemberDto>(member);
                //active user exists
                if (checkLoginIn(member))
                {
                    frmMain demo = new frmMain
                    {
                        loginUser = loginUser
                    };
                    this.Hide();
                    if (demo.ShowDialog() == DialogResult.Cancel)
                    {
                        LoadfrmLogin();
                        this.Show();
                    }
                }
            } else
                MessageBox.Show($"{memberErrors.Display()}", "Login",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void btnExit_Click(object sender, EventArgs e)
        => Close();
        #endregion

        #region Key Down and CheckedChanged
        private void btnLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }
        private void btnExit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                btnExit_Click(sender, e);
        }
        private void cbShowHide_CheckedChanged(object sender, EventArgs e)
        => txtPassword.UseSystemPasswordChar = !cbShowHide.Checked;
        #endregion
    }
}
