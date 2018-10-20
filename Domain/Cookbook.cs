using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    class Cookbook : ICookbook
    {
        private List<IRecipe> recipes;
        private String cookbookname;

        public Cookbook(List<IRecipe> recipes, String cookbookname)
        {
            this.recipes = recipes;
            this.cookbookname = cookbookname;
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
