using CoreMVCSample.UI.Models.Core.Context;
using CoreMVCSample.UI.Models.Core.Entities;
using System.Collections.Generic;
using System.Linq;

namespace CoreMVCSample.UI.Models.Core.DAL
{
	public class CategoryDAL
	{

        private readonly ProductAllergyContext _context;
        public CategoryDAL(ProductAllergyContext context)
        {
            _context = context;
        }

        public List<Category> GetCategories()
        {
            List<Category> temp = new List<Category>();
            temp = _context.Categories.ToList();
            return temp;
        }

        public Category GetCategoryByID(int ID)
        {
            Category temp = null;
            temp = (
                from c in _context.Categories
                where c.CategoryId == ID
                select new Category()
                {
                    CategoryId = c.CategoryId,
                    CategoryName = c.CategoryName,
                    IsSelected = c.IsSelected
                }
                ).SingleOrDefault();
            return temp;
        }

        public void AddCategory(Category category)
        {
            _context.Categories.Add(new Category()
            {
                CategoryId = category.CategoryId,
                CategoryName = category.CategoryName,
                IsSelected = false
            });
            _context.SaveChanges();
        }

        public void UpdateCategory(Category category)
        {
            _context.Categories.Update(category);
            _context.SaveChanges();
        }

        public void DeleteCategory(int ID)
        {
            Category category = GetCategoryByID(ID);
            _context.Categories.Remove(category);
            _context.SaveChanges();
        }

    }
}
