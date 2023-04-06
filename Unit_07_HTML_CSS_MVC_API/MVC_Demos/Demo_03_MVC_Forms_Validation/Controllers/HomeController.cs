using Demo_03_MVC_Forms_Validation.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Demo_03_MVC_Forms_Validation.Controllers
{
    public class HomeController : Controller
    {

        private readonly UserRepository _userRepository;

        public HomeController(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Form()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Form(UserInfo userInfo)
        {
            if (ModelState.IsValid)
            {
                _userRepository.AddNewUser(userInfo);

                return View("SubmitUserDetails", userInfo);
            }

            return View(userInfo);
        }

        public IActionResult SubmitUserDetails(UserInfo userInfo)
        {
            // Get saved user data from DB and display here. (We are using a mock DB for now.)

            UserInfo user = _userRepository.GetUserByEmail(userInfo.EmailAddress);

            if (user != null) {
                return View(user);
            }

            return RedirectToAction("Index");
        }

    }
}