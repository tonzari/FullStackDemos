namespace Demo_02_API_Intro.Models
{
    // https://github.com/grandcircusco/cheatsheets/blob/master/csharp/api_calling_consuming.md

    /*
     * API
     * Application Programming Interface
     * 
     * Example of interfaces in real life: car radio panel, microwave panel, steering wheel, game controller, elevator buttons/panel
     * 
     * Interfaces in general, allow people to interact with a complex system using a simplified set of options/input
     * 
     * APIs also provide a simple way to interact with a complex system. Instead of buttons on a panel, we access the API through
     * URLs / URIs / Endpoints
     * 
     * When we access a URL/Endpoint of an API, we are making a web request. They are HTTP requests:
     *      GET, POST, PUT, PATCH, DELETE
     * 
     * 
     */

    /*
     * We will use this API: https://jsonplaceholder.typicode.com/
     * Our main goal for this demo is to retrieve a list of "posts"
     * and display the posts on our Index page.
     * 
     * The posts are located at the /posts endpoint: https://jsonplaceholder.typicode.com/posts
     * 
     * We want to make a web request from code to that endpoint.
     * Then, we want to convert the JSON into C# objects, so we can pass them to the Index view (or do whatever processing you'd like).
     * 
     * First install a Nuget package: Microsoft.AspNet.WebApi.Client
     * 
     */

    public class ApiConnection
    {
        // To make web requests from .NET we will use a built in class calles HttpClient
        // We will create a singleton of the HttpClient

        private static HttpClient _httpClient = null;

        public static HttpClient Client
        {
            get
            {
                if (_httpClient == null)
                {
                    _httpClient = new HttpClient();

                    // Here, we will set the base URL to the API that we want to interact with
                    _httpClient.BaseAddress = new Uri("https://jsonplaceholder.typicode.com/");

                    // If you are accessing an API tht requires an API key, then you could add that here. 
                    //_httpClient.DefaultRequestHeaders.Add("the-api-key", "12312312313123123123");
                }

                return _httpClient;
            }
            
        }

        // Let's create a method that will return ALL available 'posts' from the API
        // We will use asynchronous code here.
        // We will use async/await.
        // Aysnc/await allows us to make asynchronous methods. Web requests take a long time. 
        public static async Task<List<Post>> GetPosts()
        {
            // Make the actual request, and store it in a variable called 'response'
            HttpResponseMessage response = await Client.GetAsync("posts");

            // Next, we want to convert the JSON in the response into C# objects. We've prepared the Post.cs for this to happen.
            List<Post> posts = await response.Content.ReadAsAsync<List<Post>>();

            return posts;

        }

    }
}
