using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Prac.Domain.Entities
{
    public class Capital
    {
        [Key]
        public int Id { get; private set; }

        public string Name { get; private set; } 

        public virtual int? Country_Id { get; private set; }
        [ForeignKey("Country_Id")]
        public virtual Country? Country { get; set; }

        public Capital SetCapital(string name,int countryid)
        {
            Name = name;
            Country_Id = countryid; 
            return this; 
        }
    }
}
