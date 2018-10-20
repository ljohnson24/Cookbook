using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    class Recipe : IRecipe
    {
        public void AddIngredient(IIngredient ingredient)
        {
            throw new NotImplementedException();
        }

        public void AddReview(IReview review)
        {
            throw new NotImplementedException();
        }

        public void DeleteIngredient(IIngredient ingredient)
        {
            throw new NotImplementedException();
        }

        public void DeleteReview(IReview )
        {
            throw new NotImplementedException();
        }

        public string GetRecipeDescription()
        {
            throw new NotImplementedException();
        }

        public string GetRecipeName()
        {
            throw new NotImplementedException();
        }

        public List<IReview> GetReviews()
        {
            throw new NotImplementedException();
        }

        public void SetRecipeDescription(string recipedescription)
        {
            throw new NotImplementedException();
        }

        public void SetRecipeName(string recipename)
        {
            throw new NotImplementedException();
        }
    }
}
