using DDD.Prac.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Prac.Domain.IRepository
{
    public interface ICapitalRepository
    {
        Task<IList<Capital>> GetAllCapitals();

        Task<Capital> GetCapitalByCountryName(string countryname);

        Task AddCapital(Capital capital); 
    }
}
