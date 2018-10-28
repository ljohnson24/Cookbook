using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Domain.Account
{
    class AccountProfile : IAccountProfile
    {
        private int accountprofileid;
        private IContact contact;
        private String username;
        private String password;

        public AccountProfile(int accountprofileid, IContact contact, String username, String password)
        {
            this.accountprofileid = accountprofileid;
            this.contact = contact;
            this.username = username;
            this.password = password;
        }

        public int GetAccountProfileID()
        {
            return this.accountprofileid;
        }

        public void SetAccountProfileID(int accountprofileid)
        {
            this.accountprofileid = accountprofileid ;
        }

        public IContact GetContact()
        {
            return this.contact;
        }

        public String GetPassword()
        {
            return this.password;
        }

        public String GetUsername()
        {
            return this.username;
        }

        public void SetContact(IContact contact)
        {
            this.contact = contact;
        }

        public void SetPassword(String password)
        {
            this.password = password;
        }

        public void SetUsername(String username)
        {
            this.username = username;
        }
    }
}
