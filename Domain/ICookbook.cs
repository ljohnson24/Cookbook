using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Domain.Cookbook
{
    interface ICookbook
    {
        void SetCookbookID(int cookbookid);
        int GetCookbookID();
        List<IRecipe> GetRecipes();
        void AddRecipe(IRecipe recipe);
        void DeleteRecipe(IRecipe recipe);
        void UpdateRecipe(IRecipe currentrecipe, IRecipe newrecipe);
    }
}
