using BlogApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlogApp.Data.Abstract
{
    public interface IBlogRepository
    {
        IQueryable<Blog> GetAll();
        Blog GetById(int blogId);
        void addBlog(Blog entity);
        void UpdateBlog(Blog entity);
        void DeleteBlog(int blogId);

    }
}
