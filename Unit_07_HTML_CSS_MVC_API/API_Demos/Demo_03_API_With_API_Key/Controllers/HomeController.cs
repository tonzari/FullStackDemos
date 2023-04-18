using Demo_03_API_With_API_Key.Models;
using Demo_03_API_With_API_Key.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Demo_03_API_With_API_Key.Controllers
{
    public class HomeController : Controller
    {
        // Use dependency injection to get the Animal Api Service
        private readonly AnimalApiService _animalApiService;
        public HomeController(AnimalApiService animalApiService)
        {
            _animalApiService = animalApiService;
        }

        // Call the GetAnimals method from the Index action, and pass to the index view
        public async Task<IActionResult> Index()
        {
            try
            {
                List<AnimalResponse> result = await _animalApiService.GetAnimalsBySearchTerm("panda");
                return View(result);
            }
            catch (Exception ex)
            {
                ViewBag.Exception = ex;
                Debug.WriteLine(ex);
                return View();
            }

        }
    }
}