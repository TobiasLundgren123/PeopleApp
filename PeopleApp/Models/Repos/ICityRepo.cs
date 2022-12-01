using PeopleApp.Models.Data;

namespace PeopleApp.Models.Repos
{
    public interface ICityRepo
    {
        // C Create
        //Person Create(Person person);
        public City Create(City city); // set this to public later after removing interface:s public

        // R Read the people list
        public List<City> Read();// set this to public later after removing interface:s public

        public City Read(int id);// set this to public later after removing interface:s public


        // U Update the people list
        public bool Update(City city);// set this to public later after removing interface:s public


        // D Delete a person from the list
        public bool Delete(City city);
    }
}
