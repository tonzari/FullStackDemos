using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Demo_04_MVC_EFC.Models;

namespace Demo_04_MVC_EFC.Controllers;

public class HomeController : Controller
{
    private readonly AppUserRepository _AppUserRepo;

    public HomeController(AppUserRepository appUserRepository)
    {
        _AppUserRepo = appUserRepository;
    }

    public IActionResult Index()
    {
        return View();
    }
}

