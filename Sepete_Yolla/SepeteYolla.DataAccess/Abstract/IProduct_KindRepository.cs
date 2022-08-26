﻿using SepeteYolla.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SepeteYolla.DataAccess.Abstract
{
    public interface IProduct_KindRepository
    {
        /// <summary>
        /// Ana ürüne ait çeşitli modelleri getirir.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        List<Product_Kind> GetProduct_KindsByProductId(int id);

        List<Product_Kind> GetProductsByDemansionOrColorOrPriceOrCompanyOrCategory(string demansion, string color, int minPrice, int maxPrice, int company_id, int category_id);

        Product_Kind CreateProduct_Kind(Product_Kind product_Kind);

        Product_Kind UpdateProduct_Kind(Product_Kind product_Kind);

        void DeleteProduct_Kind(int id);
    }
}
