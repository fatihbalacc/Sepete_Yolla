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
    public class CategoryManager : ICategoryService
    {
        private ICategoryRepository _categoryRepository;
        public CategoryManager()
        {
            _categoryRepository = new CategoryRepository();
        }

        public Category CreateCategory(Category category)
        {
            return _categoryRepository.CreateCategory(category);
        }

        public void DeleteCategory(int id)
        {
            _categoryRepository.DeleteCategory(id);
        }

        public List<Category> GetCategories()
        {
            return _categoryRepository.GetCategories();
        }

        public Category UpdateCategory(Category category)
        {
            return _categoryRepository.UpdateCategory(category);
        }
    }
}
