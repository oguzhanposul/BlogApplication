using BlogApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlogApp.Data.Abstract
{
    public interface ICategoryRepository
    {
        IQueryable<Category> GetAll();
        Category GetById(int categoryId);
        void addCategory(Category entity);
        void UpdateCategory(Category entity);
        void DeleteCategory(int categoryId);

    }
}
