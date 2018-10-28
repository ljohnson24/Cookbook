using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Domain.Review;

namespace Com.Domain.Cookbook
{
    class Recipe : IRecipe
    {
        private int recipeid;
        private String recipename;
        private String recipedescription;
        private List<String> recipeinstructions;
        private List<IReview> reviews;
        private List<IIngredient> ingredients;
        
        // recipe constructor
        public Recipe(int recipeid, String recipename, String recipedescription, List<String> recipeinstructions, List<IIngredient> ingredients)
        {
            // initialization of attributes
            this.recipeid = recipeid;
            this.recipename = recipename;
            this.recipedescription = recipedescription;
            this.recipeinstructions = recipeinstructions;
            this.reviews = new List<IReview>();
            this.ingredients = ingredients;
        }

        public void SetRecipeID(int recipeid)
        {
            this.recipeid = recipeid;
        }

        public int GetRecipeID()
        {
            return this.recipeid;
        }

        public void AddIngredient(IIngredient ingredient)
        {
            this.ingredients.Add(ingredient);
        }

        public List<IIngredient> GetIngredients()
        {
            return this.ingredients;
        }

        public void DeleteIngredient(IIngredient ingredient)
        {
            //provision for deleting ingredient
        }

        public void AddReview(IReview review)
        {
            this.reviews.Add(review);
        }

        public void DeleteReview(IReview review)
        {
            //Provisions for delete option - unable to delete a review, reviews are final
            
        }

        public List<IReview> GetReviews()
        {
            return this.reviews;
        }

        public string GetRecipeDescription()
        {
            return this.recipedescription;
        }

        public void SetRecipeDescription(string recipedescription)
        {
            this.recipedescription = recipedescription;
        }

        public String GetRecipeName()
        {
            return this.recipename;
        }
        
        public void SetRecipeName(string recipename)
        {
            this.recipename = recipename;
        }

        public List<String> GetInstructions()
        {
            return this.recipeinstructions;
        }

        public void SetInstructions(List<String> recipeinstructions)
        {
            this.recipeinstructions = recipeinstructions;
        }
    }
}
