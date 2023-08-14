using System.ComponentModel.DataAnnotations;

namespace DDD.Prac.Model.Request
{
    public class CreateCountryRequest
    {
        [Required]
        [RegularExpression("^[a-zA-Z]+$")] 
        public string Country_Name { get;  set; }
        [Required]
        public string Country_code { get;  set; }  
       
    }
}
