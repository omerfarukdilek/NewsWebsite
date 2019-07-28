using News.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace News.UI.Controllers
{
    public class CategoryController : Controller
    {
        private readonly CategoryService categoryService;
        private readonly NewscastService newscastService;

        public CategoryController()
        {
            categoryService = new CategoryService();

            newscastService = new NewscastService();
        }
        public ActionResult List(int id)
        {
            var categoryNewsTitle = newscastService.GetNewscastCategoryById(id);
            return View(categoryNewsTitle);
        }
    }
}