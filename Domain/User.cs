using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Domain.Cookbook;

namespace Com.Domain.Account
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
            List<IRecipe> temp = new List<IRecipe>();
            
            this.cookbook = new Cookbook.Cookbook(1,temp,"");
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
