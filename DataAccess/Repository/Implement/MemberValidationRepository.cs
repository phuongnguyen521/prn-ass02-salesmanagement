using BusinessObject.Object;
using DataAccess.Errors;
using DataAccess.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class MemberValidationRepository : IMemberValidationRepository
    {
        #region Member
        public string checkMemberCity(string city, bool? checkUser)
        => MemberValidation.Instance.checkMemberCity(city, checkUser);

        public string checkMemberCompanyName(string companyname, bool? checkUser)
        => MemberValidation.Instance.checkMemberCompanyName(companyname, checkUser);

        public string checkMemberCountry(string country, bool? checkUser)
        => MemberValidation.Instance.checkMemberCountry(country, checkUser);

        public string checkMemberEmail(string email, bool? checkUser)
        => MemberValidation.Instance.checkMemberEmail(email, checkUser);

        public string checkMemberId(string id, bool? checkUser)
        => MemberValidation.Instance.checkMemberId(id, checkUser);

        public string checkMemberPassword(string password, bool? checkUser)
        => MemberValidation.Instance.checkMemberPassword(password, checkUser);

        public string checkRedundantWhiteSpace(string obj)
         => MemberValidation.Instance.checkRedundantWhiteSpace(obj);

        public MemberErrors checkMember(Member member)
        => MemberValidation.Instance.checkMember(member);

        #endregion
    }
}
