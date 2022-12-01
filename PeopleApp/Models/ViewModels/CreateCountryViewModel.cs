using PeopleApp.Models.Data;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace PeopleApp.Models.ViewModels
{
    public class CreateCountryViewModel
    {
        [Display(Name = "Country Name")]
        [Required]
        public string? CountryName { get; set; }


        public List<string> CityList {

            get
            {
                return new List<string>
                {
                    "Karlskrona",
                    "Kirunna",
                    "Boden",
                    "Borås",
                    "Gävle",
                    "Umeå",
                    "Lund",
                    "JönKöping",
                    "Norrköping",
                    "Helsihgborg",
                    "Linköping",
                    "Örebro",
                    "Västerås",
                    "Växjö",
                    "Upplands",
                    "Väsby",
                    "Sollentuna",
                    "Södertälje",
                    "Uppsala",
                    "Malmö",
                    "Göteborg",
                    "Stockholm"
                };
            }
        
        
        }

    }
}
