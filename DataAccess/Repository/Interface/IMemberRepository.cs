using BusinessObject.Object;
using System;
using System.Collections.Generic;

namespace DataAccess.Repository
{
    public interface IMemberRepository
    {
        IEnumerable<Member> GetMember();
        Member Login(string email, string password);
        void InsertMember(Member member);
        void UpdateMember(Member member);
        void DeleteMember(int memberID);
        public Member checkDeleteMember(int memberID);
        public IEnumerable<Member> SearchIDAndCompanyName(int ID, string companyName);
        public IEnumerable<Member> SearchID(int ID);
        public IEnumerable<Member> SearchCompanyName(string companyName);
        public IEnumerable<Member> SearchCity(string City);
        public IEnumerable<String> GetCiyList();
        public IEnumerable<String> GetCountryList();
        public IEnumerable<Member> SearchCountry(string Country);
        public Member DuplicatedMemberID(string ID);
        public Member DuplicatedEmail(string email);

    }
}
