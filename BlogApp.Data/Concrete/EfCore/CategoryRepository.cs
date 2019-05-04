using BlogApp.Data.Abstract;
using BlogApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlogApp.Data.Concrete.EfCore
{
    public class CategoryRepository : ICategoryRepository
    {

        private BlogContext context;

        public CategoryRepository(BlogContext _context)
        {
            context = _context;
        }

        public void addCategory(Category entity)
        {
            context.Categories.Add(entity);
            context.SaveChanges();
        }

        public void DeleteCategory(int categoryId)
        {
            var requiredCategory = context.Categories.Find(categoryId);
            //var selectedCategory = context.Categories.Where(i => i.CategoryId == categoryId).FirstOrDefault();
            if (requiredCategory != null)
            {
                context.Categories.Remove(requiredCategory);
                context.SaveChanges();
            }
        }

        public IQueryable<Category> GetAll()
        {
            return context.Categories;
        }

        public Category GetById(int categoryId)
        {
            var requiredCategory = context.Categories.Find(categoryId);
            return requiredCategory;
        }

        public void UpdateCategory(Category entity)
        {
            context.Categories.Update(entity);
            context.SaveChanges(); 
        }
    }
}
