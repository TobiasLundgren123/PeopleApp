using PeopleApp.Models.Data;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace PeopleApp.Models.ViewModels
{
    public class CreateCityViewModel
    {
        [Display(Name = "CityName")]
        [Required]
        public string? CityName { get; set; }


        //public List<string> PeopleLista {

        //    get
        //    {
        //        return new List<string>
        //        {
        //            "CreateCityViewModel1",
        //            "CreateCityViewModel2",
        //            "CreateCityViewModel3"
        //        };
        //    }
        
        
        //}

        //public List<Person> PeopleList
        //{

        //    get
        //    {
        //        return PeopleList;
        //    }


        //}

    }
}
