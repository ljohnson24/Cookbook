using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    class Contact : IContact
    {
        private String address;
        private String email;
        private String fullname;
        private int phone;

        public Contact(String address, String email, String fullname, int phone)
        {
            this.address = address;
            this.email = email;
            this.fullname = fullname;
            this.phone = phone;
        }
        public string GetAddress()
        {
            throw new NotImplementedException();
        }

        public string GetEmail()
        {
            throw new NotImplementedException();
        }

        public string GetFullName()
        {
            throw new NotImplementedException();
        }

        public int GetPhone()
        {
            throw new NotImplementedException();
        }

        public void SetAddress(string address)
        {
            throw new NotImplementedException();
        }

        public void SetEmail(string email)
        {
            throw new NotImplementedException();
        }

        public void SetFullName(string fullname)
        {
            throw new NotImplementedException();
        }

        public void SetPhone(int phone)
        {
            throw new NotImplementedException();
        }
    }
}
