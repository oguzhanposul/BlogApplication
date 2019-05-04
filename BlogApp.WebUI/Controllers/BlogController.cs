using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using BlogApp.Data.Abstract;
using BlogApp.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BlogApp.WebUI.Controllers
{
    public class BlogController : Controller
    {
        private IBlogRepository blogRepository;
        private ICategoryRepository categoryRepository;

        public BlogController(IBlogRepository _blogRepo,ICategoryRepository _categoryRepo)
        {
            blogRepository = _blogRepo ;
            categoryRepository = _categoryRepo;

        }

        
        public IActionResult Index(int? id,string q)
        {
            var query = blogRepository.GetAll().Where(i => i.isApproved);

            if (id != null)
            {
                query = query.Where(i => i.CategoryId == id).OrderByDescending(i => i.Date);
            }

            if (!string.IsNullOrEmpty(q))
            {
                query = query.Where(i => i.Title.Contains(q) || i.Description.Contains(q) || i.Body.Contains(q) );
            }

            return View(query);
        }

        public IActionResult List()
        {
            return View(blogRepository.GetAll());
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Categories = new SelectList(categoryRepository.GetAll(),"CategoryId","Name" );
            return View();
        }

        [HttpPost]
        public IActionResult Create(Blog entity)
        {
            entity.Date = DateTime.Now;

            if (ModelState.IsValid)
            {
                blogRepository.addBlog(entity);
                return RedirectToAction("List");
            }
            ViewBag.Categories = new SelectList(categoryRepository.GetAll(), "CategoryId", "Name");
            return View(entity);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Categories= new SelectList(categoryRepository.GetAll(), "CategoryId", "Name");
            var blog = blogRepository.GetById(id);
            return View(blog);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Blog entity,IFormFile file)
        {
            if (ModelState.IsValid)
            {
                if (file != null)
                {
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\img", file.FileName);

                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await file.CopyToAsync(stream);
                    }

                    entity.Image = file.FileName;
                }
            

                TempData["message"] = $"{entity.Title} güncellendi ";
                entity.Date = DateTime.Now;
                blogRepository.UpdateBlog(entity);

                return RedirectToAction("List");
            }
            ViewBag.Categories = new SelectList(categoryRepository.GetAll(), "CategoryId", "Name");
            return View(entity);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            return View(blogRepository.GetById(id));
        }

        [HttpPost,ActionName("Delete")]
        public IActionResult DeleteConfirmed(int BlogId)
        {
            blogRepository.DeleteBlog(BlogId);
            TempData["message"] = $"The item whos id number is {BlogId} has deleted.";
            return RedirectToAction("List");
        }

        public IActionResult Details(int id)
        {
            return View(blogRepository.GetById(id));
        }


    }
}