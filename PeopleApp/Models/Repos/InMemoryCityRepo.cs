using PeopleApp.Models.Data;

namespace PeopleApp.Models.Repos
{

    public class InMemoryCityRepo : ICityRepo
    {
        private static List<City> cityList = new List<City>();
        private static int idCounter = 0;

        public City Create(City city)
        {
            city.CityId = ++idCounter;
            cityList.Add(city);
            return city;
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

        public List<City> Read()
        {
            return cityList;
        }

        public City Read(int id)
        {

            foreach (City city in cityList)
            {
                if (city.CityId == id)
                {
                    return city;

                }
            }
            return null;
        }

        public bool Update(City city)
        {
            City orgCity = Read(city.CityId);
            if (orgCity == null)
            {
                return false;
            }
            else
            {
                orgCity.CityName = orgCity.CityName;
                return true;
            }
        }
        public bool Delete(City city)
        {
            return cityList.Remove(city);
        }
    }
}
