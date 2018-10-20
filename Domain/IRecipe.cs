using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    interface IRecipe
    {
        String GetRecipeName();
        void SetRecipeName(String recipename);
        void AddIngredient(IIngredient ingredient);
        void DeleteIngredient(IIngredient ingredient);
        String GetRecipeDescription();
        void SetRecipeDescription(String recipedescription);
        void AddReview(IReview review);
        void DeleteReview(IReview);
        List<IReview> GetReviews();
    }
}
