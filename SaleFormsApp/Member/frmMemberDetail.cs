using AutoMapper;
using BusinessObject.Object;
using DataAccess.Errors;
using DataAccess.Repository;
using SaleFormsApp.Mappers;
using System;
using System.Windows.Forms;

namespace SaleFormsApp
{
    public partial class frmMemberDetail : Form
    {
        #region Initialized Objects
        public MemberDto loginUser { get; set; }
        public MemberDto user { get; set; }
        public bool CreateOrUpdate { get; set; } //Insert: True; Update: False
        private IMemberRepository memberRepository = new MemberRepository();
        private IMemberValidationRepository validation = new MemberValidationRepository();
        MemberErrors memberError = null;
        #endregion
        public frmMemberDetail()
        {
            InitializeComponent();
            
        }

        #region Check
        private void checkMemberID(string memberID)
        {
            try
            {
                int MemberID = Convert.ToInt32(memberID);
                string error = validation.checkMemberId(memberID, false);
                if (error != null)
                {
                    memberError = new MemberErrors();
                    memberError.memberidError = error;
                }
                else if (memberRepository.DuplicatedMemberID(txtMemberID.Text) != null
              && loginUser != user)
                {
                    memberError = new MemberErrors();
                    memberError.memberidError = "Member ID is duplicated!";
                }
                else
                    memberError = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("memberID is empty", "Check Member ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void checkRedundantWhiteSpace()
        {
            IMemberValidationRepository validation = new MemberValidationRepository();
            txtCompanyName.Text = validation.checkRedundantWhiteSpace(txtCompanyName.Text);
            txtCountry.Text = validation.checkRedundantWhiteSpace(txtCountry.Text);
            txtCity.Text = validation.checkRedundantWhiteSpace(txtCity.Text);
        }

        public void checkDuplicatedAdmin()
        {
            if (txtEmail.Text.Equals("admin@fstore.com")
                && txtPassword.Text.Equals("admin@@"))
                memberError.emailError = "Duplicated Email!";
        }

        public void checkDuplicatedEmail()
        {
            checkDuplicatedAdmin();
            if (memberError.emailError == null)
            {
                if (memberRepository.DuplicatedEmail(txtEmail.Text) != null)
                    memberError.emailError = "Email is duplicated!";
            }
        }

        public MemberErrors checkValidation(Member member)
        {
            validation = null;
            validation = new MemberValidationRepository();
            return validation.checkMember(member);
        }

        private void checkLoginUser()
            => txtMemberID.Enabled = loginUser.Email.Equals("admin@fstore.com") && loginUser != user;
        #endregion

        #region Event
        private void frmMemberDetail_Load(object sender, EventArgs e)
        => LoadMember();

        private void LoadMember()
        {
            txtMemberID.Enabled = CreateOrUpdate;
            // Update
            if (CreateOrUpdate == false)
            {
                txtMemberID.Text = user.MemberId.ToString();
                txtCompanyName.Text = user.CompanyName.Trim().ToString();
                txtEmail.Text = user.Email.Trim().ToString();
                txtPassword.Text = user.Password.Trim().ToString();
                txtCity.Text = user.City.Trim().ToString();
                txtCountry.Text = user.Country.Trim().ToString();
                checkLoginUser();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string messsage = CreateOrUpdate == true ? "Add new Member" : "Update member";
            checkMemberID(txtMemberID.Text);
            bool result = memberError != null;
            try {
                if (result)
                    MessageBox.Show(memberError.Display(), messsage, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    checkRedundantWhiteSpace();
                    memberError = new MemberErrors();
                    checkDuplicatedEmail();
                    if (memberError.isEmpty())
                    {
                        Member TempMember = new Member
                        {
                            MemberId = Int32.Parse(txtMemberID.Text),
                            CompanyName = txtCompanyName.Text,
                            Password = txtPassword.Text,
                            City = txtCity.Text,
                            Country = txtCountry.Text,
                            Email = txtEmail.Text
                        };
                        memberError = new MemberErrors();
                        memberError = checkValidation(TempMember);
                        if (memberError == null)
                        {
                            //Insert
                            if (CreateOrUpdate)
                                memberRepository.InsertMember(TempMember);
                            //Update
                            else
                                memberRepository.UpdateMember(TempMember);
                            MessageBox.Show($"{messsage} Successfully!", messsage, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                            MessageBox.Show(memberError.Display(), messsage, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                        MessageBox.Show(memberError.Display(), messsage, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            } catch(Exception ex) 
            { 
                MessageBox.Show(ex.Message, messsage, MessageBoxButtons.OK, MessageBoxIcon.Warning); 
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        => Close();
        #endregion

        #region Mouse Hover
        private void txtMemberID_MouseHover(object sender, EventArgs e)
        => statusMemberDetail.Text = "MemberID shall be number";

        private void txtEmail_MouseHover(object sender, EventArgs e)
        => statusMemberDetail.Text = "Email shall be format email";

        private void txtCompanyName_MouseHover(object sender, EventArgs e)
        => statusMemberDetail.Text = "Company name's length is from 1 to 40 characters";

        private void txtCity_MouseHover(object sender, EventArgs e)
        => statusMemberDetail.Text = "City's length is from 1 to 15 characters\n(only letters and whitespace are allowed)";

        private void txtCountry_MouseHover(object sender, EventArgs e)
        => statusMemberDetail.Text = "Country's length is from 1 to 15 characters\n(only letters and whitespace are allowed)";

        private void txtPassword_MouseHover(object sender, EventArgs e)
        => statusMemberDetail.Text = "Password length is from 3 to 30 characters";

        private void frmMemberDetail_MouseHover(object sender, EventArgs e)
        => statusMemberDetail.Text = String.Empty;
        #endregion
    }
}
