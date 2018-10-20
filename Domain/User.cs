using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    class User : IUser
    {
        private ICookbook cookbook;
        private IAccountProfile accountprofile;
        
        //initialization
        public User(ICookbook cookbook, IAccountProfile accountprofile)
        {
            this.cookbook = cookbook;
            this.accountprofile = accountprofile;
        }
        public void DeleteCookbook(ICookbook cookbook)
        {
            //clears the cookbook
            this.cookbook = new Cookbook();
        }

        public IAccountProfile GetAccountProfile()
        {
            return this.accountprofile;
        }

        public ICookbook GetCookbook()
        {
            return this.cookbook;
        }

        public void SetAccountProfile(IAccountProfile accountprofile)
        {
            this.accountprofile = accountprofile;
        }

        public void SetCookbook(ICookbook cookbook)
        {
            this.cookbook = cookbook;
        }
    }
}
