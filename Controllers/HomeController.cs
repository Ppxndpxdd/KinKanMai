using AuthSystem.Areas.Identity.Data;
using AuthSystem.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using KinKanMai.Models;
using AuthSystem.Data;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel.Design;

namespace AuthSystem.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly AuthSystemDbContext _db;
        
        public HomeController(ILogger<HomeController> logger, UserManager<ApplicationUser> userManager, AuthSystemDbContext db)
        { 
            _logger = logger;
            this._userManager = userManager;
            _db = db;
        }

        public IActionResult Index()
        {
            ViewData["UserID"] = _userManager.GetUserName(this.User);
            IEnumerable<Menu> all = _db.Menus;
            
            return View(all);
        }

        public IActionResult Send()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Add(Menu obj)
        {
            /*var OrderId = new Kinkanmai { OrderId = 1};*/

            if (ModelState.IsValid)
            {
                _db.Menus.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}