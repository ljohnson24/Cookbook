using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    interface IIngredient
    {
        String GetItem();
        void SetItem(String Item);
    }
}
