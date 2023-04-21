using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Demo_04_MVC_EFC.Models;

namespace Demo_04_MVC_EFC.Controllers;

public class HomeController : Controller
{
    private readonly IAppUserRepository _AppUserRepo; // Another common pattern: this could be an interface, which would allow for easily swapping between a mock db and a real db

    public HomeController(IAppUserRepository appUserRepository)
    {
        _AppUserRepo = appUserRepository;
    }

    public IActionResult Index()
    {
        List<AppUser> AppUsers = _AppUserRepo.GetAppUsers();
        return View(AppUsers);
    }

    // TASK!
    // Create an iactionresult called Form that simply returns a view.
    // Then, create a the form view file. The file can be empty for now.

    // url: /Home/Form
    [HttpGet]
    public IActionResult Form()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Form(AppUser appUser)
    {
        // Add to the database.
        _AppUserRepo.AddSingleUser(appUser);

        return RedirectToAction("Index");
    }
}

