using Frent_Project.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Microsoft.AspNetCore.Identity;
using FRENT_Project.Models;
using Frent_Project.DataAccess.Repository.Irepository;

namespace FRENT_Project.Controllers
{
    public class HomeController : Controller
    {
        private readonly UserManager<User> _userManager;

        private readonly IUnitOfWork _IUnit;

        public HomeController(UserManager<User> userManager, IUnitOfWork IUnit)
        {
            _userManager = userManager;
            _IUnit = IUnit;
        }

        public IActionResult Index()
        {
            var userID = _userManager.GetUserId(HttpContext.User);
            if (userID != null)
            {
                return RedirectToAction("Home", "Home");
            }
            return View();
        }

        public IActionResult Home()
        {
            return View();
        }

        public IActionResult Account()
        {
            var userID = _userManager.GetUserId(HttpContext.User);
            if (userID == null)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                User user = _userManager.FindByIdAsync(userID).Result;
                return View(user);
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Account(User user)
        {
            if (ModelState.IsValid)
            {
                _IUnit.User.Update(user);
                _IUnit.Save();
                return RedirectToAction("Home", "Home");
            }
            return View(user);
        }

        public IActionResult activity()
        {
            return View();
        }
        public IActionResult AdvanceSearch()
        {
            return View();
        }
        public IActionResult Blocked()
        {
            return View();
        }
        public IActionResult Chat()
        {
            return View();
        }
        public IActionResult ChatList()
        {
            return View();
        }
        public IActionResult Condition()
        {
            return View();
        }
        public IActionResult ContactUS()
        {
            return View();
        }
        public IActionResult gender()
        {
            return View();
        }
        public IActionResult Order()
        {
            return View();
        }
        public IActionResult partnerDetails()
        {
            return View();
        }
        public IActionResult PartnerList()
        {
            return View();
        }
        public IActionResult Payment()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }
        
        public IActionResult Profile()
        {
            var userID = _userManager.GetUserId(HttpContext.User);
            if(userID == null)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                User user = _userManager.FindByIdAsync(userID).Result;
                return View(user);
            }
            
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Profile(User user)
        {
            if (ModelState.IsValid)
            {
                _IUnit.User.Update(user);
                _IUnit.Save();
                return RedirectToAction("Home", "Home");
            }
            return View(user);
        }

        public IActionResult Settings2()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}