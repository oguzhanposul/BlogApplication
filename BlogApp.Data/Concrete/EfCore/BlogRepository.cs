using BlogApp.Data.Abstract;
using BlogApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlogApp.Data.Concrete.EfCore
{
    public class BlogRepository : IBlogRepository
    {
        private BlogContext context;

        public BlogRepository(BlogContext _context)
        {
            context = _context;
        }

        public void addBlog(Blog entity)
        {
            context.Blogs.Add(entity);
            context.SaveChanges();
        }

        public void DeleteBlog(int blogId)
        {
            var requiredBlog = context.Blogs.FirstOrDefault(i => i.BlogId == blogId);

            if (requiredBlog != null)
            {
                context.Blogs.Remove(requiredBlog);
                context.SaveChanges();
            }
        }

        public IQueryable<Blog> GetAll()
        {
            return context.Blogs;
        }

        public Blog GetById(int blogId)
        {
            var requiredBlog = context.Blogs.FirstOrDefault(i => i.BlogId == blogId);

            return requiredBlog;
        }

        public void UpdateBlog(Blog entity)
        {
            context.Blogs.Update(entity);
            context.SaveChanges();
        }

    }
}
