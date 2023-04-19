using Demo_04_API_FormsAndSecrets.Models;
using System.Reflection;
using System.Text;

namespace Demo_04_API_FormsAndSecrets.Services
{
    /*
        This is the list of optional parameters from the Api Ninja documentation: https://api-ninjas.com/api/city
        
        name (optional) - name of city.

        country (optional) - country filter. Must be an ISO-3166 alpha-2 country code (e.g. US).

        min_population (optional) - minimum city population.

        max_population (optional) - maximum city population.

        min_lat (optional) - minimum latitude coordinate.

        max_lat (optional) - maximum latitude coordinate.

        min_lon (optional) - minimum longitude coordinate.

        max_lon (optional) - maximum longitude coordinate.

        limit (optional) - How many results to return. Must be between 1 and 30. Default is 1.

    */

    public class CityApiService
    {
        private readonly HttpClient _httpClient;
        public CityApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<City>> GetCityByName(string cityName)
        {
            var response = await _httpClient.GetAsync($"city?name={cityName}");
            var result = await response.Content.ReadAsAsync<List<City>>();
            
            return result;
        }


        // See: https://stackoverflow.com/questions/66310813/parameterized-query-with-c-httpclient
        public async Task<List<City>> SearchByAnyParamater(CitySearchModel searchModel)
        {
            /*
             * This method is called when the user completes the form to search for cities.
             * 
             * Our goal is turn the user's submission from the form into a query string which can be passed to the API.
             * 
             * Each search parameter is OPTIONAL!
             * 
             * So, that means if the user only searches by city name, we only pass a value for 'name' to the API.
             * We would then make a web request that looks like this: https://api-ninjas.com/api/city?name=detroit
             * 
             * But what if the user searches for country, max population, and they want up to 30 results? 
             * We would need to build a URL that looks like this: https://api-ninjas.com/api/city?name=san&country=US&max_population=5000&limit=30
             * 
             * How do we build those URLs in code? 
             * 
             * We could do it manually by checking each property in the CitySearchModel...
             * if(searchModel.name != null) 
             *      create the string "name={searchModel.name}&"
             *      
             * But we have a lot of properties and I really don't feel like manually building a big string.
             * 
             * So how about we programmatically loop through ALL the properties in the CitySearchModel? And then we can check if the user actually
             * submitted a value or not. If they DID submit a value, then we will add it to thet query string. If they didn't submit a value, then just move on!
             * 
             * How do we loop throug the properties of an object? 
             * Reflection!!!
             * 
             * How do we automatically build a query string without having to manage a string manually ourselves?
             * We'll build a dictionary to store each user parameter submission along with the parameter name, ( "name","detroit" )
             * We'll pass that dictionary into FormUrlEncodedContent() https://learn.microsoft.com/en-us/dotnet/api/system.net.http.formurlencodedcontent?view=net-6.0
             * Then we turn it into a string using ReadAsStringAsync()
             * 
             * And then we have a complete query string that contains all the parameters and values passed in by the user who completed the form.
             * Thankfully the actual code is far less than this explanation! See below.
             */

            // Create dictionary to store the parameters and values passed from the form by the user
            var queryParameters = new Dictionary<string, string>();

            // Get the type of the object
            Type objType = searchModel.GetType();

            // Get all public properties of the object
            PropertyInfo[] properties = objType.GetProperties();

            // Loop through the properties
            foreach (PropertyInfo property in properties)
            {
                // Get the property name
                string propertyName = property.Name;

                // Get the property value
                object propertyValue = property.GetValue(searchModel, null);

                // Check if there's a value
                if (propertyValue != null)
                {
                    queryParameters.Add(propertyName, propertyValue.ToString());
                }
            }

            // Convert dictionary into query string
            var dictFormUrlEncoded = new FormUrlEncodedContent(queryParameters);
            var queryString = await dictFormUrlEncoded.ReadAsStringAsync();

            // Make web request, store response, and deserialize form JSON into C# object list (of type City)
            var response = await _httpClient.GetAsync($"city?{queryString}");
            var result = await response.Content.ReadAsAsync<List<City>>();

            return result;
        }
    }
}
