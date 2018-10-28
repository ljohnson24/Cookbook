using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Domain.Review;

namespace Com.Domain.Cookbook
{
    interface IRecipe
    {
        int GetRecipeID();
        void SetRecipeID(int receiptid);
        String GetRecipeName();
        void SetRecipeName(String recipename);
        void AddIngredient(IIngredient ingredient);
        void DeleteIngredient(IIngredient ingredient);
        List<IIngredient> GetIngredients();

        String GetRecipeDescription();
        void SetRecipeDescription(String recipedescription);
        void AddReview(IReview review);
        void DeleteReview(IReview review);
        List<IReview> GetReviews();
        void SetInstructions(List<String> instructions);
        List<String> GetInstructions();
    }
}
