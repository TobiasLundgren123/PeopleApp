using PeopleApp.Data;
using PeopleApp.Models.Data;
using System.Diagnostics.Metrics;
using System.Linq;

namespace PeopleApp.Models.Repos
{
    public class DataBaseCountrysRepo : ICountryRepo
    {
        readonly PeopleDbContext _peopleDbContext;
        public DataBaseCountrysRepo(PeopleDbContext peopleDbContext)
        {
            _peopleDbContext = peopleDbContext;
        }

        public Country Create(Country country)
        {
            _peopleDbContext.Add(country);
            _peopleDbContext.SaveChanges();
            return country;
        }

        //public Person Create(string name, string phonenumber, string city)
        //{
        //    throw new NotImplementedException();
        //}


        public List<Country> Read()
        {
            return _peopleDbContext.Countries.ToList();
        }

        public Country Read(int id)
        {

            return _peopleDbContext.Countries.SingleOrDefault(country => country.CountryId == id);
        }

        public bool Update(Country country)
        {
            if(country != null) { 
            _peopleDbContext.Update(country);
            _peopleDbContext.SaveChanges();
            return true;
            }
            return false;
        }


        public bool Delete(Country country)
        {
            if (country != null)
            {
                _peopleDbContext.Remove(country);
                _peopleDbContext.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
