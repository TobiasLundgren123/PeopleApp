using PeopleApp.Data;
using PeopleApp.Models.Data;
using System.Linq;

namespace PeopleApp.Models.Repos
{
    public class DataBaseCitysRepo : ICityRepo
    {
        readonly PeopleDbContext _peopleDbContext;
        public DataBaseCitysRepo(PeopleDbContext peopleDbContext)
        {
            _peopleDbContext = peopleDbContext;
        }

        public City Create(City city)
        {
            _peopleDbContext.Add(city);
            _peopleDbContext.SaveChanges();
            return city;
        }

        //public Person Create(string name, string phonenumber, string city)
        //{
        //    throw new NotImplementedException();
        //}


        public List<City> Read()
        {
            return _peopleDbContext.Cities.ToList();
        }

        public City Read(int id)
        {

            return _peopleDbContext.Cities.SingleOrDefault(city => city.CityId == id);
        }

        public bool Update(City city)
        {
            if(city != null) { 
            _peopleDbContext.Update(city);
            _peopleDbContext.SaveChanges();
            return true;
            }
            return false;
        }


        public bool Delete(City city)
        {
            if (city != null)
            {
                _peopleDbContext.Remove(city);
                _peopleDbContext.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
