using Demo_04_API_FormsAndSecrets.Models;
using System.Reflection;
using System.Text;

namespace Demo_04_API_FormsAndSecrets.Services
{
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
