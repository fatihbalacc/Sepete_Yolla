using SepeteYolla.Business.Abstract;
using SepeteYolla.DataAccess.Concreate;
using SepeteYolla.DataAccess.Abstract;
using SepeteYolla.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SepeteYolla.Business.Concreate
{
    public class Shopping_CartManager : IShopping_CartService
    {
        private IShopping_CartRepository _shopping_CartRepository;
        public Shopping_CartManager()
        {
            _shopping_CartRepository = new Shopping_CartRepository();
        }

        public Shopping_Cart CreateShopping_Cart(Shopping_Cart shopping_Cart)
        {
            return _shopping_CartRepository.CreateShopping_Cart(shopping_Cart);
        }

        public void DeleteShopping_CartById(int id)
        {
            _shopping_CartRepository.DeleteShopping_CartById(id);
        }

        public List<Shopping_Cart> GetShopping_CartsByCustomerId(int id)
        {
            return _shopping_CartRepository.GetShopping_CartsByCustomerId(id);
        }

        public Shopping_Cart UpdateShopping_CartById(Shopping_Cart shopping_Cart)
        {
            return _shopping_CartRepository.UpdateShopping_CartById(shopping_Cart);
        }
    }
}
