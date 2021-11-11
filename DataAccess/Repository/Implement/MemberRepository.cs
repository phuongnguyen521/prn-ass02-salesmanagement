using BusinessObject.Object;
using System.Collections.Generic;


namespace DataAccess.Repository
{
    public class MemberRepository : IMemberRepository
    {
        public void DeleteMember(int memberID)
        => MemberDAO.Instance.DeleteMember(memberID);

        public IEnumerable<Member> GetMember()
        => MemberDAO.Instance.GetMemberList();

        public void InsertMember(Member member)
        => MemberDAO.Instance.AddMember(member);

        public void UpdateMember(Member member)
        => MemberDAO.Instance.UpdateMember(member);

        Member IMemberRepository.Login(string email, string password)
        => MemberDAO.Instance.Login(email, password);

        IEnumerable<Member> IMemberRepository.SearchCity(string City)
        => MemberDAO.Instance.SearchCity(City);

        IEnumerable<Member> IMemberRepository.SearchID(int ID)
        => MemberDAO.Instance.SearchID(ID);

        IEnumerable<Member> IMemberRepository.SearchIDAndCompanyName(int ID, string companyName)
        => MemberDAO.Instance.SearchIDAndCompanyName(ID,companyName);

        IEnumerable<Member> IMemberRepository.SearchCompanyName(string companyName)
        => MemberDAO.Instance.SearchCompanyName(companyName);

        IEnumerable<string> IMemberRepository.GetCiyList()
        => MemberDAO.Instance.GetCityList();

        IEnumerable<string> IMemberRepository.GetCountryList()
        => MemberDAO.Instance.GetCountryList();

        IEnumerable<Member> IMemberRepository.SearchCountry(string Country)
        => MemberDAO.Instance.SearchCountry(Country);

        Member IMemberRepository.DuplicatedMemberID(string ID)
        => MemberDAO.Instance.DuplicatedMemberID(ID);

        Member IMemberRepository.DuplicatedEmail(string email)
        => MemberDAO.Instance.DuplicatedEmail(email);

        public Member checkDeleteMember(int memberID)
        => MemberDAO.Instance.checkDeleteMember(memberID);
    }
}
