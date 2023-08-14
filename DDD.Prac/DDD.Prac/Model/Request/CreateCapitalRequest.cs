using System.ComponentModel.DataAnnotations;

namespace DDD.Prac.Model.Request
{
    public class CreateCapitalRequest
    {
        [Required]
        [RegularExpression("^[a-zA-Z]+$")] 
        public string Name { get; set; }
        [Required]
        public  int Country_Id { get; set; }
    }
}
