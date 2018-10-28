using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Domain.Cookbook
{
    interface IIngredient
    {
        int GetIngredientID();
        void SetIngredientID(int ingredient);
        String GetIngredientName();
        void SetIngredientName(String ingredient);
    }
}
