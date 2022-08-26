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
    public class Product_KindManager : IProduct_KindService
    {
        private IProduct_KindRepository _product_KindRepository;
        public Product_KindManager()
        {
            _product_KindRepository = new Product_KindRepository();
        }

        public Product_Kind CreateProduct_Kind(Product_Kind product_Kind)
        {
            return _product_KindRepository.CreateProduct_Kind(product_Kind);
        }

        public void DeleteProduct_Kind(int id)
        {
            _product_KindRepository.DeleteProduct_Kind(id);
        }

        public List<Product_Kind> GetProductsByDemansionOrColorOrPriceOrCompanyOrCategory(string demansion, string color, int minPrice, int maxPrice, int company_id, int category_id)
        {
            return _product_KindRepository.GetProductsByDemansionOrColorOrPriceOrCompanyOrCategory(demansion, color, minPrice, maxPrice, company_id, category_id);
        }

        public List<Product_Kind> GetProduct_KindsByProductId(int id)
        {
            return _product_KindRepository.GetProduct_KindsByProductId(id);
        }

        public Product_Kind UpdateProduct_Kind(Product_Kind product_Kind)
        {
            return _product_KindRepository.UpdateProduct_Kind(product_Kind);
        }
    }
}
