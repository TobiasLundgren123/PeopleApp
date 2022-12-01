using PeopleApp.Models.Data;
using PeopleApp.Models.ViewModels;

namespace PeopleApp.Models.Services
{
    public interface ICountryService
    {
        Country Add(CreateCountryViewModel createCountry);
        List<Country> All();
        List<Country> Search(string Search);
        Country FindById(int id);
        //Person Edit(Person person);
        bool Edit(int id, CreateCountryViewModel editCountry);
        //bool Remove(Person person);
        bool Remove(int id);
    }
}
