using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Domain.Cookbook;
namespace Com.Domain.Account
{
    interface IUser
    {
        IAccountProfile GetAccountProfile();
        void SetAccountProfile(IAccountProfile accountprofile);
        ICookbook GetCookbook();
        void SetCookbook(ICookbook cookbook);
        void DeleteCookbook(ICookbook cookbook);
    }
}
