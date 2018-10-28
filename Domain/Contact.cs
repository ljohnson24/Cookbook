using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Domain.Account
{
    class Contact : IContact
    {
        int contactid;
        private String address;
        private String email;
        private String fullname;
        private int phone;

        public Contact(int contactid,String address, String email, String fullname, int phone)
        {
            this.contactid = contactid;
            this.address = address;
            this.email = email;
            this.fullname = fullname;
            this.phone = phone;
        }
        public string GetAddress()
        {
            return this.address;
        }

        public string GetEmail()
        {
            return this.email;
        }

        public string GetFullName()
        {
            return this.fullname;
        }

        public int GetPhone()
        {
            return this.phone;
        }

        public void SetAddress(string address)
        {
            this.address = address;
        }

        public void SetEmail(string email)
        {
            this.email = email;
        }

        public void SetFullName(string fullname)
        {
            this.fullname = fullname;
        }

        public void SetPhone(int phone)
        {
            this.phone = phone;
        }

        public void SetContactID(int contactid)
        {
            this.contactid = contactid;
        }

        public int GetContactID()
        {
            return this.contactid;
        }
    }
}
