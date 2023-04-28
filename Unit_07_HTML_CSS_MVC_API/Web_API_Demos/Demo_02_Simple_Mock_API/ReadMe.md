## Notes
	
In this demo, we have another mock database (this time it is just a plain old class object, CafeDb.cs) which has some dummy data already entered.
The CafeDb.cs is instantiated at the beginning of CafeController. We have added the mock database this way in interest of simplicity and time.
	
Return types in this demo are simply the actual objects that are being accessed. (Ex. List<MenuItems> )
This simplified return type approach is what you can expect to find in the Mock Assessment and the real Assessment.
Normally, you'd use a return type of ActionResult<YourObject> and because making calls to a real database takes time, you would want to use asynchronous code.

For example, 
```
// GET: api/TodoItems
    [HttpGet]
    public async Task<ActionResult<IEnumerable<TodoItemDTO>>> GetTodoItems()
    {
        return await _context.TodoItems
            .Select(x => ItemToDTO(x))
            .ToListAsync();
    }
```

## Endpoints for this demo

	1.	Menus - an endpoint that returns all menu names. Return back all Menu names as a list of strings.

	2.	MenuItems - an endpoint that returns all menu items. Return back all MenuItems as a list.

	3.	SearchForCategory - this endpoint takes in a parameter of string category and returns back all menu items that belong to the given category.

	4.	SortedByPrice - this endpoint returns all menu items sorted by their prices (lowest price first).

    4b. ItemsLessThanPriceOf/{price} - this endpoint returns all menu items under a price with the price given in the URI.

	5.	ItemsInMenu - this endpoint will take in an integer menuId and return all MenuItems associated with the given menu ID.

	6.	MenusOfItem - this endpoint will take in an integer itemId and return all Menus that contain the given menu item ID.

    6b. MenusOfItemByName - this endpoint takes in a parameter of string name and returns back all menu names that contain the searched menu item name.

	7.	UniqueCategories - this endpoint filters through the MenuItems and returns all unique categories. The returned list should not contain duplicates.
