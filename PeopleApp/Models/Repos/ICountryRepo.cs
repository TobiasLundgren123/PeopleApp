using PeopleApp.Models.Data;

namespace PeopleApp.Models.Repos
{
    public interface ICountryRepo
    {
        // C Create
        //Person Create(Person person);
        public Country Create(Country country); // set this to public later after removing interface:s public

        // R Read the people list
        public List<Country> Read();// set this to public later after removing interface:s public

        public Country Read(int id);// set this to public later after removing interface:s public


        // U Update the people list
        public bool Update(Country country);// set this to public later after removing interface:s public


        // D Delete a person from the list
        public bool Delete(Country country);
    }
}
