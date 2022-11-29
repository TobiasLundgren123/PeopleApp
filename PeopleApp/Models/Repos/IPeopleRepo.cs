using PeopleApp.Models.Data;

namespace PeopleApp.Models.Repos
{
    public interface IPeopleRepo
    {
        // C Create
        //Person Create(Person person);
        public Person Create(Person person); // set this to public later after removing interface:s public

        // R Read the people list
        public List<Person> Read();// set this to public later after removing interface:s public

        public Person Read(int id);// set this to public later after removing interface:s public


        // U Update the people list
        public bool Update(Person person);// set this to public later after removing interface:s public


        // D Delete a person from the list
        public bool Delete(Person person);
    }
}
