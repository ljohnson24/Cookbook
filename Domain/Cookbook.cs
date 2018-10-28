using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Domain.Cookbook
{
    class Cookbook : ICookbook
    {
        private int cookbookid;
        private List<IRecipe> recipes;
        private String cookbookname;
        
        public Cookbook(int cookbookid, List<IRecipe> recipes, String cookbookname)
        {
            this.cookbookid = cookbookid;
            this.recipes = recipes;
            this.cookbookname = cookbookname;
        }
        public int GetCookbookID()
        {
            return this.cookbookid;
        }

        public void SetCookbookID(int cookbookid)
        {
            this.cookbookid = cookbookid;
        }
        public void AddRecipe(IRecipe recipe)
        {
            this.recipes.Add(recipe);
        }

        public void DeleteRecipe(IRecipe recipe)
        {
            this.recipes.Remove(recipe);
        }

        public List<IRecipe> GetRecipes()
        {
            return this.recipes;
        }

        public void UpdateRecipe(IRecipe oldrecipe, IRecipe newrecipe)
        {
            //need to implement
            //this.recipes.Find(oldrecipe);
            
            
        }
    }
}
