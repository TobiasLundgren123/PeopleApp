using PeopleApp.Models.Data;

namespace PeopleApp.Models.ViewModels
{
    public class CityViewModel
    {
        public List<City> CityListView { get; set; }

        public string? FilterString { get; set; }

        public CityViewModel()
        { CityListView = new List<City>(); }
    }
}
