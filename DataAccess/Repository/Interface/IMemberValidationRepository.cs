using BusinessObject.Object;
using DataAccess.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IMemberValidationRepository
    {
        #region Member
        public string checkRedundantWhiteSpace(string obj);
        public string checkMemberId(string id, bool? checkUser);
        public string checkMemberPassword(string password, bool? checkUser);
        public string checkMemberCity(string city, bool? checkUser);
        public string checkMemberCountry(string country, bool? checkUser);
        public string checkMemberCompanyName(string companyname, bool? checkUser);
        public string checkMemberEmail(string email, bool? checkUser);
        public MemberErrors checkMember(Member member);
        #endregion
    }
}
