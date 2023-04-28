using Demo_02_Simple_Mock_API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


/*
	1.	Menus - an endpoint that returns all menu names. Return back all Menu names as a list of strings.

	2.	MenuItems - an endpoint that returns all menu items. Return back all MenuItems as a list.

	3.	SearchForCategory - this endpoint takes in a parameter of string category and returns back all menu items that belong to the given category.

	4.	SortedByPrice - this endpoint returns all menu items sorted by their prices (lowest price first).

    4b. ItemsLessThanPriceOf/{price} - this endpoint returns all menu items under a price with the price given in the URI.

	5.	ItemsInMenu - this endpoint will take in an integer menuId and return all MenuItems associated with the given menu ID.

	6.	MenusOfItem - this endpoint will take in an integer itemId and return all Menus that contain the given menu item ID.

    6b. MenusOfItemByName - this endpoint takes in a parameter of string name and returns back all menu names that contain the searched menu item name.

	7.	UniqueCategories - this endpoint filters through the MenuItems and returns all unique categories. The returned list should not contain duplicates.

*/

namespace Demo_02_Simple_Mock_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CafeController : ControllerBase
    {
		public CafeDb _cafeDb = new CafeDb(); // This will be our mock database. This is similar to how the mock assessment works for the sake of simplicity.

		[HttpGet("Menus")]
		public List<Menu> GetMenus()
		{
			return _cafeDb.Menus;
		}

		[HttpGet("AllMenuItems")]
		public List<MenuItem> GetMenuItems()
		{
			return _cafeDb.MenuItems;
		}

        [HttpGet("SearchForCategory")]
        public List<MenuItem> GetItemsInCategory(string searchQuery)
        {
			List<MenuItem> result = new List<MenuItem>();

			result = _cafeDb.MenuItems.FindAll(m => m.Category.ToLower() == searchQuery.ToLower());

            return result;
        }

        [HttpGet("SortedByPrice")]
        public List<MenuItem> GetItemsSortedByPrice()
        {
            List<MenuItem> result = new List<MenuItem>();

            result = _cafeDb.MenuItems.OrderBy(m => m.Price).ToList();

            return result;
        }

        [HttpGet("ItemsLessThanPriceOf/{price}")]
        public List<MenuItem> GetItemsLessThanPrice(decimal price)
        {
            List<MenuItem> result = new List<MenuItem>();

            result = _cafeDb.MenuItems.Where(m => m.Price < price).ToList();

            return result;
        }

        [HttpGet("ItemsInMenu")]
        public List<MenuItem> GetItemsInMenu(int menuId)
        {
            List<MenuItem> result = new List<MenuItem>();

            Menu menu = _cafeDb.Menus.FirstOrDefault(m => m.Id == menuId);

            // One example of how to turn a list of IDs into a list of MenuItems

            if (menu != null)
            {
                foreach (int itemId in menu.MenuItemIds)
                {
                    MenuItem m = _cafeDb.MenuItems.First(m => m.Id == itemId);
                    result.Add(m);
                }
            }


            // Another way to turn a list of IDs into a list of MenuItems

            //if (menu != null)
            //{
            //    result = menu.MenuItemIds.Select(menuItemId => _cafeDb.MenuItems.First(m => m.Id == menuItemId)).ToList();
            //}

            return result;
        }

        [HttpGet("MenusOfItem")]
        public List<Menu> GetMenusOfItem(int itemID)
        {
            List<Menu> result = new List<Menu>();

            foreach (Menu menu in _cafeDb.Menus)
            {
                foreach (int item in menu.MenuItemIds)
                {
                    if (item == itemID)
                    {
                        result.Add(menu);
                    }
                }
            }

            return result;
        }
        // Alternate version of GetMenusOfItem.
        // Ex. Search "salad" and get back "Day Menu"
        // Ex. Search "espresso" and get back "Breakfast Menu", "Day Menu"

        [HttpGet("MenusOfItemName")]
        public List<string> GetMenusOfItemName(string searchQuery)
        {
            List<string> result = new List<string>();

            foreach (Menu menu in _cafeDb.Menus)
            {
                List<MenuItem> items = GetItemsInMenu(menu.Id);

                foreach (MenuItem item in items)
                {
                    if (item.Name.ToLower() == searchQuery.ToLower())
                    {
                        result.Add(menu.Name);
                    }
                }
            }

            return result;
        }

        [HttpGet("UniqueCategories")]
        public List<string> GetUniqueCategories()
        {
            List<string> result = new List<string> ();

            IEnumerable<string> categories = _cafeDb.MenuItems.Select(m => m.Category);

            result = categories.Distinct().ToList();

            return result;
        }
    }
}
