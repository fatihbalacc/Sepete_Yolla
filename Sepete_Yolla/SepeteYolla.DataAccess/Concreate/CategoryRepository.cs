using SepeteYolla.DataAccess.Abstract;
using SepeteYolla.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SepeteYolla.DataAccess.Concreate
{
    public class CategoryRepository : ICategoryRepository
    {
        public Category CreateCategory(Category category)
        {
            using (var sepeteYollaDbContext = new SepeteYollaDbContext())
            {
                sepeteYollaDbContext.Categories.Add(category);
                sepeteYollaDbContext.SaveChanges();
                return category;
            }
        }

        public void DeleteCategory(int id)
        {
            using (var sepeteYollaDbContext = new SepeteYollaDbContext())
            {
                var deleted_Category = sepeteYollaDbContext.Categories.Find(id);

                sepeteYollaDbContext.Categories.Remove(deleted_Category);
                sepeteYollaDbContext.SaveChanges();
            }
        }

        public List<Category> GetCategories()
        {
            using (var sepeteYollaDbContext = new SepeteYollaDbContext())
            {
                return sepeteYollaDbContext.Categories.ToList();
            }
        }

        public Category UpdateCategory(Category category)
        {
            using (var sepeteYollaDbContext = new SepeteYollaDbContext())
            {
                var updated_category = sepeteYollaDbContext.Categories.FirstOrDefault(x => x.Id == category.Id);
                updated_category = category;
                sepeteYollaDbContext.Categories.Update(updated_category);
                sepeteYollaDbContext.SaveChanges();
                return updated_category;
            }   // BURAYI KONTROL ET 
        }
    }
}
