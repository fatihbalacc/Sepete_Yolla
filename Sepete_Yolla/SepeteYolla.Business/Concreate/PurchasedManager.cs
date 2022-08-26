using SepeteYolla.Business.Abstract;
using SepeteYolla.DataAccess.Abstract;
using SepeteYolla.DataAccess.Concreate;
using SepeteYolla.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SepeteYolla.Business.Concreate
{
    public class PurchasedManager : IPurchasedService
    {
        private IPurchasedRepository _purchasedRepository;
        public PurchasedManager()
        {
            _purchasedRepository = new PurcheasedRepository();
        }

        public Purchased CreatePurchased(Purchased purchased)
        {
            return _purchasedRepository.CreatePurchased(purchased);
        }

        public void DeletePurchased(int id)
        {
            _purchasedRepository.DeletePurchased(id);
        }

        public List<Purchased> GetPurchaseds()
        {
            return _purchasedRepository.GetPurchaseds();
        }

        public List<Purchased> GetPurchasedsByCompanyId(int id)
        {
            return _purchasedRepository.GetPurchasedsByCompanyId(id);
        }

        public List<Purchased> GetPurchasedsByCustomerId(int id)
        {
            return _purchasedRepository.GetPurchasedsByCustomerId(id);
        }

        public List<Purchased> GetPurchasedsByProductId(int id)
        {
            return _purchasedRepository.GetPurchasedsByProductId(id);
        }

        public List<Purchased> GetPurchasedsWithPriceDecrease()
        {
            return _purchasedRepository.GetPurchasedsWithPriceDecrease();
        }

        public List<Purchased> GetPurchasedsWithPriceIncrease()
        {
            return _purchasedRepository.GetPurchasedsWithPriceIncrease();
        }
    }
}
