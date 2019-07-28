using News.Domain;
using News.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace News.UI.Controllers
{
    public class UserController : Controller
    {
        private readonly UserService userService;

        public UserController()
        {
            userService = new UserService(); 
        }
        // GET: User
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult UserRegister(User user)
        {
            if (user == null)
            {
                ModelState.AddModelError("", "Geçerli bir employee göndermelisiniz...");
                return View(user);
            }

            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Zorunlu alanlar doldurulmalıdır....");
                return View(user);
            }
            user.IsActive = true;
            userService.AddUser(user);
            userService.SaveDb();
            return RedirectToAction("Index", "Home");
        }






        [HttpPost]
        public ActionResult UserLogin(User user)
        {
            if (user == null)
            {
                ModelState.AddModelError("", "Geçerli bir employee göndermelisiniz...");
                return View(user);
            }

            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Zorunlu alanlar doldurulmalıdır....");
                return View(user);
            }
            user.IsActive = true;
            userService.AddUser(user);
            userService.SaveDb();
            return RedirectToAction("Index", "Home");
        }



        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Register()
        {
            return View();
        }



    }
}