using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    interface IReview
    {
        void SetRating(Boolean rating);
        Boolean GetRating();
        void SetComment(String comment);
        String GetComment();
        String GetReviewer(IUser user);
    }
}
