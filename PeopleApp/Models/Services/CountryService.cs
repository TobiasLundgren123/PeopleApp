using PeopleApp.Models.Data;
using PeopleApp.Models.Repos;
using PeopleApp.Models.ViewModels;
using System.Diagnostics.Metrics;

namespace PeopleApp.Models.Services
{
    public class CountryService : ICountryService
    {
        ICountryRepo _countryRepo;
        public CountryService(ICountryRepo countryRepo)
        {
            _countryRepo = countryRepo;
        }
        public Country Add(CreateCountryViewModel createCountry)
        {
            
            if (string.IsNullOrWhiteSpace(createCountry.CountryName))
                //|| string.IsNullOrWhiteSpace(createPerson.PhoneNumber))
                //|| string.IsNullOrWhiteSpace(createPerson.CityName))
            {
                throw new ArgumentException("Name,PhoneNumber or City, not be consist of backspace(s)/whitespace(s)");
            }
            Country country = new Country()
            {
                CountryName = createCountry.CountryName

            };

            country = _countryRepo.Create(country);

            return country;
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

        public List<Country> All()
        {
            return _countryRepo.Read();
        }

        

        public Country FindById(int id)
        {
            //return _peopleRepo.Read(id);
            Country foundCountry = _countryRepo.Read(id);

            return foundCountry;
        }
        public bool Edit(int id, CreateCountryViewModel editCountry)
        {
            Country orginalCountry = FindById(id);
            if (orginalCountry != null)
            {
                //Person person = _peopleRepo.GetById(id);
                //if (person != null)
                //{
                //    return false;
                //    person.Name = editPerson.Name;
                //    person.CityId = editPerson.CityId;
                //    person.PhoneNumber = editPerson.PhoneNumber;
                //}
                orginalCountry.CountryName = editCountry.CountryName;

            }
            return _countryRepo.Update(orginalCountry);
            // return _peopleRepo.Update(person);
        }
        public bool Remove(int id)
        {
            Country countryToDelete = _countryRepo.Read(id);
            bool success = _countryRepo.Delete(countryToDelete);

            return success;

        }

       
            public List<Country> Search(string search)
            {
                List<Country> searchCountry = _countryRepo.Read();
                //
                foreach (Country item in _countryRepo.Read())
                {
                    if (item.CountryName.Contains(search, StringComparison.OrdinalIgnoreCase))
                       //|| item.CityName.Contains(search, StringComparison.OrdinalIgnoreCase))
                    {
                    searchCountry = searchCountry.Where(p => p.CountryName.ToUpper().Contains(search.ToUpper())).ToList();
                    //|| p.CityName.Contains(search.ToUpper())).ToList();
                    searchCountry.Add(item);
                    }
                }
                //searchPerson = searchPerson.Where(p => p.Name.ToUpper().Contains(search.ToUpper()) || p.City.Contains(search.ToUpper())).ToList();
                if (searchCountry.Count == 0)
                {
                    throw new ArgumentException("Could not find what you where looking for");
                }
                return searchCountry;
            }
        
    }
}
