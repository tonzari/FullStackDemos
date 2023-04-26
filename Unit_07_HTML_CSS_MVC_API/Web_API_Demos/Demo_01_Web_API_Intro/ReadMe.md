# ASP.NET Web API // Demo 01 // Desserts API

- Create a Dessert class/model.
- Add dummy data (example desserts). For simplicity, we can create a static list of desserts in the dessert model class.
- Create a Dessert Controller.
	- Right click Controllers folder, and choose: Add Controller...
	- Make sure to choose the Web API Controller with Read/Write...
	- The generated controller will provide basic read/write methods to help us get started.

- Complete CRUD (Create, Read, Update, Delete) features so that the user can:
	- View all Desserts
	- View a single Dessert by ID or Name
	- Edit/update a single Dessert
	- Delete a single Dessert by ID
	- Get all Desserts of a type (like "cake" or "pie" for example)

## HTTP Verbs

```
// HTTP Verbs:
/*
 * GET      - Request informfation from a web address (URL). Retrieves data without modifying it.
 * POST     - Sends data to a server. Creates a new record. Data is in the 'body' of the the web request.
 * PUT      - Sends data to a server. Update an existing record (the ENTIRE record) by replacing it with the new data. Requires the full data for the update.
 * PATCH    - Sends data to a server. Update a part of an existing record. Only requires the fields that need to be updated.
 * DELETE   - Request to delete an existing on the server.
 * 
 */
// These HTTP verbs fulfill CRUD ( CREATE, READ, UPDATE, DELETE)
```

## Return types in Web API

We have a database of desserts. We want to provide users of the API access to the dessert data. 
We have an endpoint that provides ALL desserts: `GET: api/Desserts`
We also have an endpoint that provides a single dessert by ID: `GET api/Desserts/5`

So, what return type should we use? By default, the template sets the Get() method's return type as `IEnumerable<string>`.
For `GET: api/Desserts`, our goal is provide some sort of list of dessert objects, so `IEnumerable<Dessert>` could work, or an array or List of type `Dessert` would be fine too.
And for `GET api/Desserts/5`, our goal is to provide a single dessert object, so a return type of `Dessert` seems sensible, and would work!

But we have a potential problem. When we have a return type of `Dessert` or a list, or any other specific model, the response status is always 'OK'.
In other words, someone may access `GET api/Desserts/123` but there is no dessert with an Id of 123. If our return type is `Dessert` the API will return a status of OK, and 204 No Content. 

This may be preffered by some developers because it is a semantic response. But what if we want to return a different HTTP code? For example, a simple OK 200, or a Not Found 404?
Search online for conversation on how to handle this situation. 

Here's an article on the topic of no record found at particular ID: https://apihandyman.io/move-along-no-resource-to-see-here-seriously-http-status-code-204-vs-403-vs-404-vs-410/
Here's an article on the topic of returning empty lists: https://apihandyman.io/empty-lists-http-status-code-200-vs-204-vs-404/

For this demo, I would like to return a 404 if a particular ID is not found. This is a different respone than the 204 that is being generated currently by our application.
To provide a 404 in the event that a specific ID is not found, a return type of `Dessert` will not do! We need a more flexible return type that can provide a proper HTTP response code depending on the possibly changing circumstances.

We can make use of the return type `ActionResult`. We can wrap our desired return type of `Dessert` inside the ActionResult. See below.
Then, we can return an `Ok()` and pass the object as an argument.

```
        // GET api/Desserts/5
        [HttpGet("{id}")]
        public ActionResult<Dessert> Get(int id)
        {
            Dessert result = Dessert.Desserts.FirstOrDefault(x => x.Id == id);

            if (result != null)
            {
                return Ok(result);
            }
            else
            {
                return NotFound();
            }
        }
```

Doesn't that read nicely? If we have a result (it isn't null), then tell the API consumer everything is OK! Otherwise, tell them it wasn't found.

## Links / Other resources
Youtube video tutorial (uses .NET 7 but still helpful): https://www.youtube.com/watch?v=V0UF4vEMlhQ