namespace PeopleApp.Models.Data
{
    public class Country
    {
        public int CountryId { get; set; }
        public string? CountryName { get; set; }
        public List<City>? Cities { get; set; }

    }
}
