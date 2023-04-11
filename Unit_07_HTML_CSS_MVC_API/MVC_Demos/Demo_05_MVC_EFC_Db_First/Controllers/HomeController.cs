using Demo_05_MVC_EFC_Db_First.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Demo_05_MVC_EFC_Db_First.Controllers
{
    public class HomeController : Controller
    {
        private readonly DessertDbContext _db;

        public HomeController(DessertDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View(_db.Desserts.ToList());
        }
    }
}