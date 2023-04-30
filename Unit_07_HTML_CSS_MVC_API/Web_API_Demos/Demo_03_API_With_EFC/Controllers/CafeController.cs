using Demo_03_API_With_EFC.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Demo_03_API_With_EFC.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CafeController : ControllerBase
    {
        private readonly CafeDbContext _context;

        public CafeController(CafeDbContext context) 
        {
            _context = context;
        }

        [HttpPost("AddItemToMenu")]
        public ActionResult<Menu> AddItemToMenu(AddItemToMenuDto request)
        {
            // find the menu
            Menu menu = _context.Menus
                            .Where(m => m.Id == request.MenuId)
                            .Include(m => m.MenuItems)
                            .FirstOrDefault();

            if (menu is null)
            {
                return NotFound();
            }

            // find the menu item
            MenuItem menuItem = _context.MenuItems.Find(request.MenuId);

            if (menuItem is null)
            {
                return NotFound();
            }

            // menu.save the item, save db
            menu.MenuItems.Add(menuItem);
            _context.SaveChanges();

            return Ok(menu);
        }
    }
}
