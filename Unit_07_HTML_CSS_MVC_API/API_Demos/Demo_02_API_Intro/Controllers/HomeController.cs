using Demo_02_API_Intro.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Demo_02_API_Intro.Controllers
{
    public class HomeController : Controller
    {
        public async Task<IActionResult> Index()
        {
            List<Post> posts = await ApiConnection.GetPosts();

            // You can process the data here before passing to the view.
            // You can create a class/model that handles processing the data in some way.
            
            return View(posts.Take(5).ToList());
        }
    }
}