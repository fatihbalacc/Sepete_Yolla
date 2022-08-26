using SepeteYolla.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SepeteYolla.Business.Abstract
{
    public interface IPurchasedService
    {
        List<Purchased> GetPurchaseds();

        List<Purchased> GetPurchasedsByCompanyId(int id);

        List<Purchased> GetPurchasedsByCustomerId(int id);

        List<Purchased> GetPurchasedsByProductId(int id);

        /// <summary>
        /// Satılan tüm ürünleri elde edilen kazanca göre küçükten büyüğe sıralar.
        /// </summary>
        /// <returns></returns>
        List<Purchased> GetPurchasedsWithPriceIncrease();

        /// <summary>
        /// Satılan tüm ürünleri elde edilen kazanca göre büyükten küçüğe sıralar.
        /// </summary>
        /// <returns></returns>
        List<Purchased> GetPurchasedsWithPriceDecrease();

        Purchased CreatePurchased(Purchased purchased);

        void DeletePurchased(int id);
    }
}
