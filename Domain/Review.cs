using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Domain.Account;
namespace Com.Domain.Review
{
    class Review : IReview
    {
        private int reviewid;
        private bool rating;
        private String comment;
        private IUser author;

        public Review(int reviewid, bool rating, String comment, IUser user)
        {
            this.reviewid = reviewid;
            this.rating = rating;
            this.comment = comment;
            this.author = user;
        }
        public void SetUser(IUser user)
        {
            this.author = user;
        }

        public IUser GetUser()
        {
            return this.author;
        }
        public String GetComment()
        {
            return this.comment;
        }

        public bool GetRating()
        {
            return this.rating;
        }

        public String GetReviewer(IUser user)
        {
            return this.author.GetAccountProfile().GetUsername();
        }

        public void SetComment(String comment)
        {
            this.comment = comment;
        }

        public void SetRating(bool rating)
        {
            this.rating = rating;
        }

    }
}
