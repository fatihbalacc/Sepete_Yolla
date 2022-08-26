using SepeteYolla.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SepeteYolla.DataAccess.Abstract
{
    public interface IProductRepository
    {
        List<Product> GetProducts();

        List<Product> GetProductsByName(string name);

        Product CreateProduct(Product product);

        Product UpdateProduct(Product product);

        void DeleteProduct(int id);
    }
}
