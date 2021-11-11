using AutoMapper;
using BusinessObject.Object;
using DataAccess.Errors;
using DataAccess.Repository;
using SaleFormsApp.Mappers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace SaleFormsApp
{
    public partial class frmMemberManagement : Form
    {
        #region Initial Objects
        public MemberDto loginUser { get; set; }
        IMemberRepository memberRepository = new MemberRepository();
        private IMemberValidationRepository validation = new MemberValidationRepository();
        IMapper mapper = null;

        BindingSource citySource = null;
        BindingSource countrySource = null;
        BindingSource source = null;
        #endregion
        public frmMemberManagement()
        {
            InitializeComponent();
            var config = new MapperConfiguration(cfg => 
            {
                cfg.AddProfile(new MappingProfile());
            });
            mapper = config.CreateMapper();
        }

        #region Event
        private void ClearText()
        {
            txtMemberID.Text = string.Empty;
            txtCompanyName.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtCity.Text = string.Empty;
            txtCountry.Text = string.Empty;
        }

        private MemberDto GetMember()
        {
            MemberDto member = null;
            try
            {
                member = new MemberDto
                {
                    MemberId = int.Parse(txtMemberID.Text),
                    CompanyName = txtCompanyName.Text,
                    Email = txtEmail.Text,
                    Password = txtPassword.Text,
                    City = txtCity.Text,
                    Country = txtCountry.Text
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get Member");
            }
            return member;
        }

        private void frmMemberManagement_Load(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            txtMemberID.Enabled = false;
            txtCompanyName.Enabled = false;
            txtEmail.Enabled = false;
            txtPassword.Enabled = false;
            txtPassword.UseSystemPasswordChar = true;
            txtCity.Enabled = false;
            txtCountry.Enabled = false;
            gbSearch.Enabled = false;
            gbFilter.Enabled = false;
            dgv_Member.CellDoubleClick += dgv_Member_CellDoubleClick;
        }

        private void dgv_Member_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmMemberDetail memberDetail = new frmMemberDetail()
            {
                Text = "Update a member",
                loginUser = loginUser,
                user = GetMember(),
                CreateOrUpdate = false, //Insert: true, Update: false
            };

            if (memberDetail.ShowDialog() == DialogResult.Cancel)
                LoadMemberList();
        }

        private void LoadMemberList()
        {
            source = null;
            source = new BindingSource();
            var list = memberRepository.GetMember().OrderBy(temp => temp.MemberId);
            IEnumerable<MemberDto> members = list.Select(
                                temp => mapper.Map<Member, MemberDto>(temp));
            try
            {
                source.DataSource = members;
                var countryList = memberRepository.GetCountryList();
                var cityList = memberRepository.GetCiyList();

                if (members.Count() > 0)
                {
                    countrySource = new BindingSource();
                    countrySource.DataSource = countryList;
                    cboSearchCountry.DataSource = null;
                    cboSearchCountry.DataSource = countrySource;

                    citySource = new BindingSource();
                    citySource.DataSource = cityList;
                    cboSearchCity.DataSource = null;
                    cboSearchCity.DataSource = citySource;
                    txtSearchMemberID.Text = String.Empty;
                    txtSearchCompanyName.Text = String.Empty;
                }
                txtMemberID.DataBindings.Clear();
                txtEmail.DataBindings.Clear();
                txtCompanyName.DataBindings.Clear();
                txtCity.DataBindings.Clear();
                txtCountry.DataBindings.Clear();
                txtPassword.DataBindings.Clear();

                txtMemberID.DataBindings.Add("Text", source, "MemberID");
                txtEmail.DataBindings.Add("Text", source, "Email");
                txtCompanyName.DataBindings.Add("Text", source, "CompanyName");
                txtCity.DataBindings.Add("Text", source, "City");
                txtCountry.DataBindings.Add("Text", source, "Country");
                txtPassword.DataBindings.Add("Text", source, "Password");

                dgv_Member.DataSource = null;
                dgv_Member.DataSource = source;

                if (members.Any())
                {
                    btnDelete.Enabled = true;
                    gbSearch.Enabled = true;
                    gbFilter.Enabled = true;
                }

                else
                {
                    btnDelete.Enabled = true;
                    gbSearch.Enabled = true;
                    gbFilter.Enabled = true;
                    btnDelete.Enabled = false;
                    ClearText();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load Member List");
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        => LoadMemberList();

        private void btnCreate_Click(object sender, EventArgs e)
        {
            MemberDto user = GetMember();
            frmMemberDetail memberDetail = new frmMemberDetail()
            {
                loginUser = loginUser,
                user = user,
                CreateOrUpdate = true, //Insert: true, Update: false
            };

            if (memberDetail.ShowDialog() == DialogResult.Cancel)
                LoadMemberList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var member = GetMember();
            Member tempMember = memberRepository.checkDeleteMember(member.MemberId);
            if (member.MemberId.Equals(loginUser.MemberId))
                MessageBox.Show("You cannot delete this member", "Delete a member", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (tempMember != null)
                MessageBox.Show("You cannot delete this member", "Delete a member", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                DialogResult result;
                result = MessageBox.Show($"Do you want to delete this member?", "Delete a member", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    try
                    {
                        memberRepository.DeleteMember(member.MemberId);
                        LoadMemberList();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Delete a memeber");
                    }
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        => Close();

        private void LoadSearchingMemberList(IEnumerable<Member> SearchResult)
        {
            IEnumerable<MemberDto> MemberList = null;
            if (SearchResult.Any())
            {
                MemberList = SearchResult.Select(
                        temp => mapper.Map<Member, MemberDto>(temp)
                    );
                source = new BindingSource();
                source.DataSource = MemberList;

                txtMemberID.DataBindings.Clear();
                txtEmail.DataBindings.Clear();
                txtCompanyName.DataBindings.Clear();
                txtCity.DataBindings.Clear();
                txtCountry.DataBindings.Clear();
                txtPassword.DataBindings.Clear();

                txtMemberID.DataBindings.Add("Text", source, "MemberID");
                txtEmail.DataBindings.Add("Text", source, "Email");
                txtCompanyName.DataBindings.Add("Text", source, "CompanyName");
                txtCity.DataBindings.Add("Text", source, "City");
                txtCountry.DataBindings.Add("Text", source, "Country");
                txtPassword.DataBindings.Add("Text", source, "Password");

                dgv_Member.DataSource = null;
                dgv_Member.DataSource = source;

                if (SearchResult.Any())
                    btnDelete.Enabled = true;
                else
                    btnDelete.Enabled = false;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            MemberErrors errors = new MemberErrors();
            validation = new MemberValidationRepository();
            errors.memberidError = validation.checkMemberId(txtSearchMemberID.Text, false);
            errors.companynameError = validation.checkMemberCompanyName(txtSearchCompanyName.Text, false);
            if (errors.isEmpty() == false)
                MessageBox.Show($"{errors.Display()}", "Search Country", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                if (txtSearchCompanyName == null && txtSearchMemberID != null)
                {
                    IEnumerable<Member> SearchResult = memberRepository.SearchCompanyName(txtSearchCompanyName.Text);
                    if (SearchResult != null)
                        LoadSearchingMemberList(SearchResult);
                    else
                        MessageBox.Show($"No result matches with Compnay Name", "Search Company", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } else if (txtSearchCompanyName != null && txtSearchMemberID == null)
                {
                    IEnumerable<Member> SearchResult = memberRepository.SearchID(Int32.Parse(txtSearchMemberID.Text));
                    if (SearchResult != null)
                        LoadSearchingMemberList(SearchResult);
                    else
                        MessageBox.Show($"No result matches with ID", "Search ID", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } else
                {
                    IEnumerable<Member> SearchResult = memberRepository.SearchIDAndCompanyName(Int32.Parse(txtSearchMemberID.Text), txtSearchCompanyName.Text);
                    if (SearchResult != null)
                        LoadSearchingMemberList(SearchResult);
                    else
                        MessageBox.Show($"No result matches with ID and Company Name", "Search ID and Company Name", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void cboSearchCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cboSearchCountry.DataSource != null)
                {
                    string Country = cboSearchCountry.SelectedItem.ToString();
                    string error = validation.checkMemberCity(Country, false);
                    if (error == null)
                    {
                        if (Country.Equals("All"))
                            LoadMemberList();
                        else
                        {
                            IEnumerable<Member> searchResult = memberRepository.SearchCountry(Country);
                            if (searchResult.Any())
                                LoadSearchingMemberList(searchResult);
                            else
                                MessageBox.Show("No result matches the search country", "Search Country", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                        MessageBox.Show(error, "Search Country", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Search Country", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cboSearchCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cboSearchCity.DataSource != null)
                {
                    string City = cboSearchCity.SelectedItem.ToString();
                    string error = validation.checkMemberCity(City, false);
                    if (error == null)
                    {
                        if (City.Equals("All"))
                            LoadMemberList();
                        else
                        {
                            IEnumerable<Member> searchResult = memberRepository.SearchCity(City);
                            if (searchResult.Any())
                                LoadSearchingMemberList(searchResult);
                            else
                                MessageBox.Show("No result matches the search city", "Search City", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                        MessageBox.Show(error, "Search City", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Search City", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
    }
}
