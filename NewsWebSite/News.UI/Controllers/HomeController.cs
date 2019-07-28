using News.Contract.ViewModels;
using News.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace News.UI.Controllers
{
    public class HomeController : Controller
    {
        
       
        private readonly CategoryService categoryService;
        private readonly NewscastService newscastService;

        public HomeController()
        {
            categoryService = new CategoryService();

            newscastService = new NewscastService();
        }

        public ActionResult Index()
        {
            var categoryList = newscastService.GetNewscast();

            return View(categoryList);
        }


        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }


        public ActionResult Login()
        {
            return View();
        }





        public ActionResult Contact()
        {
            return View();
        }



    



        [HttpPost]
        public ActionResult Register(VmRegisterCategory vmRegisterCategory)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Eksik alanları doldurun...");
                return View(vmRegisterCategory);
            }

            if (!categoryService.IsValidCategoryName(vmRegisterCategory.CategoryName))
            {
                ModelState.AddModelError("", "Bu kategori adı sisteme kayıtlıdır..");
                return View(vmRegisterCategory);
            }

            

            categoryService.AddRegisterCategory(vmRegisterCategory);
            categoryService.SaveDb();

            
            return RedirectToAction(nameof(Index));
        }



        [HttpPost]
        public ActionResult Register(VmRegisterNewscast vmRegisterNewscast)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Eksik alanları doldurun...");
                return View(vmRegisterNewscast);
            }

            if (!newscastService.IsValidNewsTitle(vmRegisterNewscast.NewsTitle))
            {
                ModelState.AddModelError("", "Bu haber başlığı sisteme kayıtlıdır..");
                return View(vmRegisterNewscast);
            }



            newscastService.AddRegisterNewscast(vmRegisterNewscast);
            newscastService.SaveDb();


            return RedirectToAction(nameof(Index));
        }








    }
}