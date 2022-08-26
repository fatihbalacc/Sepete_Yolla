using SepeteYolla.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SepeteYolla.Business.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetCategories();

        Category CreateCategory(Category category);

        Category UpdateCategory(Category category);

        void DeleteCategory(int id);
    }
}
