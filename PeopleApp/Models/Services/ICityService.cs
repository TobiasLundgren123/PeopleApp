using PeopleApp.Models.Data;
using PeopleApp.Models.ViewModels;

namespace PeopleApp.Models.Services
{
    public interface ICityService
    {
        City Add(CreateCityViewModel createCity);
        List<City> All();
        List<City> Search(string Search);
        City FindById(int id);
        //Person Edit(Person person);
        bool Edit(int id, CreateCityViewModel editCity);
        //bool Remove(Person person);
        bool Remove(int id);
    }
}
