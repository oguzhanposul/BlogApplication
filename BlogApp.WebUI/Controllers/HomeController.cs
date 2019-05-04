using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogApp.Data.Abstract;
using BlogApp.WebUI.Models;
using Microsoft.AspNetCore.Mvc;

namespace BlogApp.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private IBlogRepository blogRepository = null;
        private ICategoryRepository categoryRepository = null;

        public HomeController(IBlogRepository _blogrepo, ICategoryRepository _categoryrepo)
        {
            blogRepository = _blogrepo;
            categoryRepository = _categoryrepo;
        }

        public IActionResult Index()
        {
            HomeBlogModel model = new HomeBlogModel();
            model.HomeBlogs = blogRepository.GetAll().Where(i => i.isHome && i.isApproved).ToList();
            model.SliderBlogs = blogRepository.GetAll().Where(i => i.isHome && i.isSlider).ToList();

            return View(model);
        }

        public IActionResult List()
        {
            var allBlogs = blogRepository.GetAll();

            return View(allBlogs);
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var requiredBlog = blogRepository.GetById(id);
           
            return View(requiredBlog);
        }

      


    }
}