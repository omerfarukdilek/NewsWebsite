using News.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace News.UI.Controllers
{
    public class CommonController : Controller
    {
        private readonly CategoryService categoryService;
        private readonly NewscastService newscastService;

        public CommonController()
        {
            categoryService = new CategoryService();

            newscastService = new NewscastService();
        }
        [ChildActionOnly]
        public PartialViewResult Header()
        {

            return PartialView();

        }


        [ChildActionOnly]
        public PartialViewResult Footer()
        {

            return PartialView();

        }


        public PartialViewResult _CategoryList()
        {
            var categoryList = categoryService.GetCategory();

            return PartialView(categoryList);
        }
    }
}