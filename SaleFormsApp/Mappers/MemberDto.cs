using System.ComponentModel;

namespace SaleFormsApp.Mappers
{
    public class MemberDto
    {
        [DisplayName("Member ID")]
        public int MemberId { get; set; }
        [DisplayName("Email")]
        public string Email { get; set; }
        [DisplayName("Company Name")]
        public string CompanyName { get; set; }
        [DisplayName("City")]
        public string City { get; set; }
        [DisplayName("Country")]
        public string Country { get; set; }
        [DisplayName("Password")]
        public string Password { get; set; }
    }
}
