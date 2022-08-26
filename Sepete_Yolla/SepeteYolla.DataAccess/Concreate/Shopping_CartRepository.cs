using SepeteYolla.DataAccess.Abstract;
using SepeteYolla.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SepeteYolla.DataAccess.Concreate
{
    public class Shopping_CartRepository : IShopping_CartRepository
    {
        public Shopping_Cart CreateShopping_Cart(Shopping_Cart shopping_Cart)
        {
            using (var sepeteYollaDbContext = new SepeteYollaDbContext())
            {
                sepeteYollaDbContext.Shopping_Carts.Add(shopping_Cart);
                sepeteYollaDbContext.SaveChanges();
                return shopping_Cart;
            }
        }

        public void DeleteShopping_CartById(int id)
        {
            using (var sepeteYollaDbContext = new SepeteYollaDbContext())
            {
                var deleted_Shopping_Cart = sepeteYollaDbContext.Shopping_Carts.FirstOrDefault(x => x.Id.Equals(id));

                sepeteYollaDbContext.Shopping_Carts.Remove(deleted_Shopping_Cart);
                sepeteYollaDbContext.SaveChanges();
            }
        }

        public List<Shopping_Cart> GetShopping_CartsByCustomerId(int id)
        {
            using (var sepeteYollaDbContext = new SepeteYollaDbContext())
            {
                return sepeteYollaDbContext.Shopping_Carts.ToList().FindAll(x => x.Customer_Id.Equals(id));
            }
        }

        public Shopping_Cart UpdateShopping_CartById(Shopping_Cart shopping_Cart)
        {
            using (var sepeteYollaDbContext = new SepeteYollaDbContext())
            {
                var updated_shopping_cart = sepeteYollaDbContext.Shopping_Carts.FirstOrDefault(x => x.Id == shopping_Cart.Id);
                updated_shopping_cart = shopping_Cart;
                sepeteYollaDbContext.Shopping_Carts.Update(updated_shopping_cart);
                sepeteYollaDbContext.SaveChanges();
                return updated_shopping_cart;
            }   // BURAYI KONTROL ET 
        }
    }
}
