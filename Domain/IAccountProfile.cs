using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Domain.Account
{
    interface IAccountProfile
    {
        int GetAccountProfileID();
        void SetAccountProfileID(int accountprofileid);
        String GetUsername();
        void SetUsername(String username);
        String GetPassword();
        void SetPassword(String password);
        IContact GetContact();
        void SetContact(IContact contact);
    }
}
