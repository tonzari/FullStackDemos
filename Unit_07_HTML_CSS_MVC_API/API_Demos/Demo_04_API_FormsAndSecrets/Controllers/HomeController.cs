using Demo_04_API_FormsAndSecrets.Models;
using Demo_04_API_FormsAndSecrets.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Demo_04_API_FormsAndSecrets.Controllers
{
    public class HomeController : Controller
    {
        private readonly CityApiService _cityApiService;

        public HomeController(CityApiService cityApiService)
        {
            _cityApiService = cityApiService;
        }

        public async Task<IActionResult> Index()
        {
            try
            {
                List<City> response = await _cityApiService.GetCityByName("Detroit");
                return View(response);
            }
            catch (Exception ex)
            {
                ViewBag.ErrorMessage = ex.Message;
            }

            return View();
            
        }

        public IActionResult Search()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Search(CitySearchModel searchModel) 
        { 
            if(!ModelState.IsValid)
            {
                return View(searchModel);
            }

            return RedirectToAction("SearchResults", searchModel);
        }

        public async Task<IActionResult> SearchResults(CitySearchModel searchModel)
        {
            //List<City> result = await _cityApiService.GetCityByName(searchModel.name); // Search only by name
            
            List<City> result = await _cityApiService.SearchByAnyParamater(searchModel);

            return View(result);
        }
    }
}