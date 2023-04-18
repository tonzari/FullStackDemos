using Demo_03_API_With_API_Key.Models;
using System.ComponentModel;

namespace Demo_03_API_With_API_Key.Services
{
    public class AnimalApiService
    {
        // Inject the HttpClient
        private readonly HttpClient _httpClient;
        public AnimalApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        // Create at least one Get method calling the API
        public async Task<List<AnimalResponse>> GetAnimalsBySearchTerm(string searchTerm)
        {
            // Make a request, and store the response
            HttpResponseMessage response = await _httpClient.GetAsync($"animals?name={searchTerm}");

            // Deserialize the response from JSON into C# objects. NOTE: we will ReadAsAsync() which requires the NuGet package: Microsoft.AspNet.WebApi.Client
            List<AnimalResponse> result = await response.Content.ReadAsAsync<List<AnimalResponse>>();

            return result;
        }
    }
}
