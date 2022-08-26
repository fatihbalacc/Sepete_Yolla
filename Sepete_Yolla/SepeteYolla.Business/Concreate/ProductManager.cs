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
    public class ProductManager : IProductService
    {
        private IProductRepository _productRepository;
        public ProductManager()
        {
            _productRepository = new ProductRepository();
        }

        public Product CreateProduct(Product product)
        {
            return _productRepository.CreateProduct(product);
        }

        public void DeleteProduct(int id)
        {
            _productRepository.DeleteProduct(id);
        }

        public List<Product> GetProducts()
        {
            return _productRepository.GetProducts();
        }

        public List<Product> GetProductsByName(string name)
        {
            return _productRepository.GetProductsByName(name);
        }

        public Product UpdateProduct(Product product)
        {
            return _productRepository.UpdateProduct(product);
        }
    }
}
