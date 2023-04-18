using System.ComponentModel.DataAnnotations;

namespace Demo_04_API_FormsAndSecrets.Models
{
    /*
        This is the list of optional parameters from the Api Ninja documentation: https://api-ninjas.com/api/city
        
        This class was created to facilitate passing data from the FORM on the Search page to the HomeController.

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

    public class CitySearchModel
    {
        public string? name { get; set; }

        [RegularExpression("^[A-Z]{2}$", ErrorMessage = "Please input a valid country code. For example: US, MX, CN")]
        public string? country { get; set; }
        public int? min_population { get; set; }
        public int? max_population { get; set; }
        public float? min_lat { get; set; }
        public float? max_lat { get; set; }
        public float? min_lon { get; set; }
        public float? max_lon { get; set; }

        [Range(1,30)]
        public int? limit { get; set; }
    }
}
