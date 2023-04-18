namespace Demo_03_API_With_API_Key.Models
{
    public class AnimalResponse
    {
        public string name { get; set; }
        public Taxonomy taxonomy { get; set; }
        public string[] locations { get; set; }
        public Characteristics characteristics { get; set; }
    }

    public class Taxonomy
    {
        public string kingdom { get; set; }
        public string phylum { get; set; }
        public string _class { get; set; }
        public string order { get; set; }
        public string family { get; set; }
        public string genus { get; set; }
        public string scientific_name { get; set; }
    }

    public class Characteristics
    {
        public string prey { get; set; }
        public string name_of_young { get; set; }
        public string group_behavior { get; set; }
        public string estimated_population_size { get; set; }
        public string biggest_threat { get; set; }
        public string most_distinctive_feature { get; set; }
        public string gestation_period { get; set; }
        public string habitat { get; set; }
        public string diet { get; set; }
        public string average_litter_size { get; set; }
        public string lifestyle { get; set; }
        public string common_name { get; set; }
        public string number_of_species { get; set; }
        public string location { get; set; }
        public string slogan { get; set; }
        public string group { get; set; }
        public string color { get; set; }
        public string skin_type { get; set; }
        public string top_speed { get; set; }
        public string lifespan { get; set; }
        public string weight { get; set; }
        public string height { get; set; }
        public string age_of_sexual_maturity { get; set; }
        public string age_of_weaning { get; set; }
    }

}
