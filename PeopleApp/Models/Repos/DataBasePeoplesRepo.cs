using PeopleApp.Data;
using PeopleApp.Models.Data;
using System.Linq;

namespace PeopleApp.Models.Repos
{
    public class DataBasePeoplesRepo : IPeopleRepo
    {
        readonly PeopleDbContext _peopleDbContext;
        public DataBasePeoplesRepo(PeopleDbContext peopleDbContext)
        {
            _peopleDbContext = peopleDbContext;
        }

        public Person Create(Person person)
        {
            _peopleDbContext.Add(person);
            _peopleDbContext.SaveChanges();
            return person;
        }

        //public Person Create(string name, string phonenumber, string city)
        //{
        //    throw new NotImplementedException();
        //}


        public List<Person> Read()
        {
            return _peopleDbContext.Persons.ToList();
        }

        public Person Read(int id)
        {

            return _peopleDbContext.Persons.SingleOrDefault(person => person.PersonId == id);
        }

        public bool Update(Person person)
        {
            if(person != null) { 
            _peopleDbContext.Update(person);
            _peopleDbContext.SaveChanges();
            return true;
            }
            return false;
        }


        public bool Delete(Person person)
        {
            if (person != null)
            {
                _peopleDbContext.Remove(person);
                _peopleDbContext.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
