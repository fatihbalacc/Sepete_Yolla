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
    public class ProductRepository : IProductRepository
    {
        public Product CreateProduct(Product product)
        {
            using (var sepeteYollaDbContext = new SepeteYollaDbContext())
            {
                sepeteYollaDbContext.Products.Add(product);
                sepeteYollaDbContext.SaveChanges();
                return product;
            }
        }

        public void DeleteProduct(int id)
        {
            using (var sepeteYollaDbContext = new SepeteYollaDbContext())
            {
                var deleted_Product = sepeteYollaDbContext.Products.Find(id);

                sepeteYollaDbContext.Products.Remove(deleted_Product);
                sepeteYollaDbContext.SaveChanges();
            }
        }

        public List<Product> GetProducts()
        {
            using (var sepeteYollaDbContext = new SepeteYollaDbContext())
            {
                return sepeteYollaDbContext.Products.ToList();
            }
        }

        /// <summary>
        /// ARAMA KUTUSUNDA ÇALIŞACAK METOD
        /// </summary>
        /// <param name="name">Satıcı adı</param>
        /// <returns></returns>
        public List<Product> GetProductsByName(string name)     
        {
            using (var sepeteYollaDbContext = new SepeteYollaDbContext())
            {
                return sepeteYollaDbContext.Products.ToList().FindAll(x => x.Name.Contains(name));
            }
        }

        public Product UpdateProduct(Product product)
        {
            using (var sepeteYollaDbContext = new SepeteYollaDbContext())
            {
                var updated_product = sepeteYollaDbContext.Products.FirstOrDefault(x => x.Id == product.Id);
                updated_product = product;
                sepeteYollaDbContext.Products.Update(updated_product);
                sepeteYollaDbContext.SaveChanges();
                return updated_product;
            }   // BURAYI KONTROL ET 
        }
    }
}
