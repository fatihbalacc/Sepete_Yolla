using SepeteYolla.DataAccess.Abstract;
using SepeteYolla.Entities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SepeteYolla.DataAccess.Concreate
{
    public class Product_KindRepository : IProduct_KindRepository
    {
        public Product_Kind CreateProduct_Kind(Product_Kind product_Kind)
        {
            using (var sepeteYollaDbContext = new SepeteYollaDbContext())
            {
                sepeteYollaDbContext.Product_Kinds.Add(product_Kind);
                sepeteYollaDbContext.SaveChanges();
                return product_Kind;
            }
        }

        public void DeleteProduct_Kind(int id)
        {
            using (var sepeteYollaDbContext = new SepeteYollaDbContext())
            {
                var deleted_product_Kind = sepeteYollaDbContext.Product_Kinds.Find(id);

                sepeteYollaDbContext.Product_Kinds.Remove(deleted_product_Kind);
                sepeteYollaDbContext.SaveChanges();
            }
        }

        public List<Product_Kind> GetProductsByDemansionOrColorOrPriceOrCompanyOrCategory(string dimansion, string color, int minPrice, int maxPrice, int company_id, int category_id)
        {
            using (var sepeteYollaDbContext = new SepeteYollaDbContext())
            {
                return sepeteYollaDbContext.Product_Kinds.ToList().FindAll(x => x.Dimension.Equals(dimansion) || x.Color.Equals(color) || (x.Price > minPrice && x.Price < maxPrice) || x.Company_Id.Equals(company_id) || x.Category_Id.Equals(category_id));
            }
        }

        public List<Product_Kind> GetProduct_KindsByProductId(int id)
        {
            using (var sepeteYollaDbContext = new SepeteYollaDbContext())
            {
                return sepeteYollaDbContext.Product_Kinds.ToList().FindAll(x => x.Product_Id.Equals(id));
            }
        }

        public Product_Kind UpdateProduct_Kind(Product_Kind product_Kind)
        {
            using (var sepeteYollaDbContext = new SepeteYollaDbContext())
            {
                var updated_product_kind = sepeteYollaDbContext.Product_Kinds.FirstOrDefault(x => x.Id == product_Kind.Id);
                updated_product_kind = product_Kind;
                sepeteYollaDbContext.Product_Kinds.Update(updated_product_kind);
                sepeteYollaDbContext.SaveChanges();
                return updated_product_kind;
            }   // BURAYI KONTROL ET 
        }
    }
}
