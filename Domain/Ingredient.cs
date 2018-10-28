using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Domain.Cookbook
{
    class Ingredient : IIngredient
    {
        private String ingredientname;
        private int ingredientid;
        
        public string GetIngredientName()
        {
            return this.ingredientname;
        }

        public void SetIngredientName(String ingredientname)
        {
            this.ingredientname = ingredientname;
        }

        public void SetIngredientID(int ingredientid)
        {
            this.ingredientid = ingredientid;
        }

        public int GetIngredientID()
        {
            return this.ingredientid;
        }
    }
}
