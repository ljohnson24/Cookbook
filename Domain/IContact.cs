using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Domain.Account
{
    interface IContact
    {
        int GetContactID();
        void SetContactID(int contactid);
        String GetFullName();
        void SetFullName(String fullname);
        String GetPhone();
        void SetPhone(String phone);
        String GetEmail();
        void SetEmail(String email);
        String GetAddress();
        void SetAddress(String address);
    }
}
