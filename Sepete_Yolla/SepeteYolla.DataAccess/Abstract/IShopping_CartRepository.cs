using SepeteYolla.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SepeteYolla.DataAccess.Abstract
{
    public interface IShopping_CartRepository
    {
        List<Shopping_Cart> GetShopping_CartsByCustomerId(int id);

        Shopping_Cart CreateShopping_Cart(Shopping_Cart shopping_Cart);

        Shopping_Cart UpdateShopping_CartById(Shopping_Cart shopping_Cart);

        void DeleteShopping_CartById(int id);
    }
}
