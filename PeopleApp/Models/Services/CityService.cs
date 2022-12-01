using PeopleApp.Models.Data;
using PeopleApp.Models.Repos;
using PeopleApp.Models.ViewModels;

namespace PeopleApp.Models.Services
{
    public class CityService : ICityService
    {
        ICityRepo _cityRepo;
        public CityService(ICityRepo cityRepo)
        {
            _cityRepo = cityRepo;
        }
        public City Add(CreateCityViewModel createCity)
        {
            
            if (string.IsNullOrWhiteSpace(createCity.CityName))
                //|| string.IsNullOrWhiteSpace(createPerson.PhoneNumber))
                //|| string.IsNullOrWhiteSpace(createPerson.CityName))
            {
                throw new ArgumentException("Name,PhoneNumber or City, not be consist of backspace(s)/whitespace(s)");
            }
            City city = new City()
            {
                CityName = createCity.CityName,

            };

            city = _cityRepo.Create(city);

            return city;
        }

        //public Person Add(CreatePersonViewModel createPerson)
        //{
        //    Person person = _peopleRepo.Create(createPerson.Name, createPerson.PhoneNumber, createPerson.CityName);
        //    if (string.IsNullOrWhiteSpace(createPerson.Name)
        //        || string.IsNullOrWhiteSpace(createPerson.PhoneNumber)
        //        || string.IsNullOrWhiteSpace(createPerson.CityName))
        //    {
        //        throw new ArgumentException("Name,PhoneNumber or City, not be consist of backspace(s)/whitespace(s)");
        //    }

        //    return person;
        //}

        public List<City> All()
        {
            return _cityRepo.Read();
        }

        

        public City FindById(int id)
        {
            //return _peopleRepo.Read(id);
            City foundCity = _cityRepo.Read(id);

            return foundCity;
        }
        public bool Edit(int id, CreateCityViewModel editCity)
        {
            City orginalCity = FindById(id);
            if (orginalCity != null)
            {
                //Person person = _peopleRepo.GetById(id);
                //if (person != null)
                //{
                //    return false;
                //    person.Name = editPerson.Name;
                //    person.CityId = editPerson.CityId;
                //    person.PhoneNumber = editPerson.PhoneNumber;
                //}
                orginalCity.CityName = editCity.CityName;
            }
            return _cityRepo.Update(orginalCity);
            // return _peopleRepo.Update(person);
        }
        public bool Remove(int id)
        {
            City cityToDelete = _cityRepo.Read(id);
            bool success = _cityRepo.Delete(cityToDelete);

            return success;

        }

       
            public List<City> Search(string search)
            {
                List<City> searchCity = _cityRepo.Read();
                //
                foreach (City item in _cityRepo.Read())
                {
                    if (item.CityName.Contains(search, StringComparison.OrdinalIgnoreCase))
                       //|| item.CityName.Contains(search, StringComparison.OrdinalIgnoreCase))
                    {
                    searchCity = searchCity.Where(p => p.CityName.ToUpper().Contains(search.ToUpper())).ToList();
                        //|| p.CityName.Contains(search.ToUpper())).ToList();
                        searchCity.Add(item);
                    }
                }
                //searchPerson = searchPerson.Where(p => p.Name.ToUpper().Contains(search.ToUpper()) || p.City.Contains(search.ToUpper())).ToList();
                if (searchCity.Count == 0)
                {
                    throw new ArgumentException("Could not find what you where looking for");
                }
                return searchCity;
            }
        
    }
}
