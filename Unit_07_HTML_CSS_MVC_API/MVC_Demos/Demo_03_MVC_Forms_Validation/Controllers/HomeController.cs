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
        public IActionResult Form(UserInfo userInfo)
        {
            if (ModelState.IsValid)
            {
                _userRepository.AddNewUser(userInfo);

                return View("Welcome", userInfo);
            }

            // If the model is NOT valid, 
            return View(userInfo);
        }

        public IActionResult Welcome(UserInfo userInfo)
        {
            // Get saved user data from DB and display here. (We are using a mock DB for now.)

            UserInfo user = _userRepository.GetUserByEmail(userInfo.EmailAddress);

            // If the user's email address wasn't found, then the DB didn't save the new user details. Thus the user object will be null.
            if (user != null) {
                return View("Form");
            }

            return RedirectToAction("Index");
        }

    }
}