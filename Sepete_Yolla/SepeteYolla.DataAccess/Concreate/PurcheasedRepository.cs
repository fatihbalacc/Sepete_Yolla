using SepeteYolla.DataAccess.Abstract;
using SepeteYolla.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SepeteYolla.DataAccess.Concreate
{
    public class PurcheasedRepository : IPurchasedRepository
    {
        public Purchased CreatePurchased(Purchased purchased)
        {
            using (var sepeteYollaDbContext = new SepeteYollaDbContext())
            {
                sepeteYollaDbContext.Purchaseds.Add(purchased);
                sepeteYollaDbContext.SaveChanges();
                return purchased;
            }
        }

        public void DeletePurchased(int id)
        {
            using (var sepeteYollaDbContext = new SepeteYollaDbContext())
            {
                var deleted_Purchased = sepeteYollaDbContext.Purchaseds.Find(id);

                sepeteYollaDbContext.Purchaseds.Remove(deleted_Purchased);
                sepeteYollaDbContext.SaveChanges();
            }
        }

        public List<Purchased> GetPurchaseds()
        {
            using (var sepeteYollaDbContext = new SepeteYollaDbContext())
            {
                return sepeteYollaDbContext.Purchaseds.ToList();
            }
        }

        public List<Purchased> GetPurchasedsByCompanyId(int id)
        {
            using (var sepeteYollaDbContext = new SepeteYollaDbContext())
            {
                return sepeteYollaDbContext.Purchaseds.ToList().FindAll(x => x.Company_Id.Equals(id));
            }
        }

        public List<Purchased> GetPurchasedsByCustomerId(int id)
        {
            using (var sepeteYollaDbContext = new SepeteYollaDbContext())
            {
                return sepeteYollaDbContext.Purchaseds.ToList().FindAll(x => x.Customer_Id.Equals(id));
            }
        }

        public List<Purchased> GetPurchasedsByProductId(int id)
        {
            using (var sepeteYollaDbContext = new SepeteYollaDbContext())
            {
                return sepeteYollaDbContext.Purchaseds.ToList().FindAll(x => x.Product_Id.Equals(id));
            }
        }

        public List<Purchased> GetPurchasedsWithPriceDecrease()
        {
            using (var sepeteYollaDbContext = new SepeteYollaDbContext())
            {
                return sepeteYollaDbContext.Purchaseds.OrderByDescending(x => x).ToList();
            }
        }

        public List<Purchased> GetPurchasedsWithPriceIncrease()
        {
            using (var sepeteYollaDbContext = new SepeteYollaDbContext())
            {
                return sepeteYollaDbContext.Purchaseds.OrderBy(x => x).ToList();
            }
        }
    }
}
