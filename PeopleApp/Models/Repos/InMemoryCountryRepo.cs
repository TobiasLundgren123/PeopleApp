using PeopleApp.Models.Data;

namespace PeopleApp.Models.Repos
{

    public class InMemoryCountryRepo : ICountryRepo
    {
        private static List<Country> countryList = new List<Country>();
        private static int idCounter = 0;

        public Country Create(Country country)
        {
            country.CountryId = ++idCounter;
            countryList.Add(country);
            return country;
        }

        //public Person Create(string name, string phonenumber, string cityname)
        //{
        //    Person person = new Person(name, phonenumber, cityname);

        //    person.PersonId = ++idCounter;
        //    person.Name = name;
        //    person.PhoneNumber = phonenumber;
        //    person.CityName = cityname;
        //    peopleList.Add(person);
        //    return person;
        //}

        public List<Country> Read()
        {
            return countryList;
        }

        public Country Read(int id)
        {

            foreach (Country country in countryList)
            {
                if (country.CountryId == id)
                {
                    return country;

                }
            }
            return null;
        }

        public bool Update(Country country)
        {
            Country orgCountry = Read(country.CountryId);
            if (orgCountry == null)
            {
                return false;
            }
            else
            {
                orgCountry.CountryName = country.CountryName;
                return true;
            }
        }
        public bool Delete(Country country)
        {
            return countryList.Remove(country);
        }
    }
}
