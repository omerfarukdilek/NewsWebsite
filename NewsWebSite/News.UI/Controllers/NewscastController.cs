using News.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace News.UI.Controllers
{
    public class NewscastController : Controller
    {
        private readonly CategoryService categoryService;
        private readonly NewscastService newscastService;

        public NewscastController()
        {
            categoryService = new CategoryService();

            newscastService = new NewscastService();
        }
        // GET: NewsPaper
        public ActionResult Index()
        {
            var categoryList = newscastService.GetNewscast();

            return View(categoryList);
        }

        public ActionResult Detail(int id)
        {
            var newsDetail = newscastService.GetNewscastById(id);
            return View(newsDetail);
        }
    }
}