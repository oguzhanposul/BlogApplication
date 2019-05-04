using BlogApp.Data.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogApp.WebUI.ViewComponents
{
    public class CategoryMenuViewComponent:ViewComponent
    {
        private ICategoryRepository categoryRepository;
        public CategoryMenuViewComponent(ICategoryRepository _repo)
        {
            categoryRepository = _repo;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.selectedCategory = RouteData?.Values["id"];

            return View(categoryRepository.GetAll());
        }

    }
}
