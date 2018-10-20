using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    class AccountProfile : IAccountProfile
    {
        private IContact contact;
        private String username;
        private String password;

        public AccountProfile(IContact contact, String username, String password)
        {
            this.contact = contact;
            this.username = username;
            this.password = password;
        }
        public IContact GetContact()
        {
            return this.contact;
        }

        public string GetPassword()
        {
            return this.password;
        }

        public string GetUsername()
        {
            return this.username;
        }

        public void SetContact(IContact contact)
        {
            this.contact = contact;
        }

        public void SetPassword(string password)
        {
            this.password = password;
        }

        public void SetUsername(string username)
        {
            this.username = username;
        }
    }
}
