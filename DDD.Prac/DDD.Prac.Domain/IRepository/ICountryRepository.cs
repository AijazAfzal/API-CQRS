using DDD.Prac.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Prac.Domain.IRepository
{
    public interface ICountryRepository
    {
        Task<IList<Country>> GetAllCountries();

        Task<Country> GetCountryByCode(string code); 

        Task AddCountry(Country country); 
    }
}
