using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    class Review : IReview
    {
        public string GetComment()
        {
            throw new NotImplementedException();
        }

        public bool GetRating()
        {
            throw new NotImplementedException();
        }

        public string GetReviewer(IUser user)
        {
            throw new NotImplementedException();
        }

        public void SetComment(string comment)
        {
            throw new NotImplementedException();
        }

        public void SetRating(bool rating)
        {
            throw new NotImplementedException();
        }
    }
}
