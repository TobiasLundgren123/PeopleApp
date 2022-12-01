using PeopleApp.Models.Data;

namespace PeopleApp.Models.ViewModels
{
    public class CountryViewModel
    {
        public List<Country> CountryListView { get; set; }

        public string? FilterString { get; set; }

        public CountryViewModel()
        { CountryListView = new List<Country>(); }
    }
}
