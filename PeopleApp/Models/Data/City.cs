namespace PeopleApp.Models.Data
{
    public class City
    {
        public int CityId { get; set; }
        public string? CityName { get; set; }
        public List<Person>? CityPeople { get; set; }
    }
}
