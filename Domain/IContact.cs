using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    interface IContact
    {
        String GetFullName();
        void SetFullName(String fullname);
        int GetPhone();
        void SetPhone(int phone);
        String GetEmail();
        void SetEmail(String email);
        String GetAddress();
        void SetAddress(String address);
    }
}
