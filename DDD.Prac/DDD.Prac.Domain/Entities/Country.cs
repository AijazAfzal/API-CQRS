using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Prac.Domain.Entities
{
    public class Country
    {
        [Key]
        public int Id { get;private set; } 

        public string Country_Name { get; private set; }

        public string Country_code { get; private set; } 

        public Country SetCountry(string Countryname,string countrycode) 
        {
            Country_Name = Countryname; 
            Country_code = countrycode; 
            return this; 
        }


    }
}
