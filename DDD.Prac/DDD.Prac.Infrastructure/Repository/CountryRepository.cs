using DDD.Prac.Domain.Entities;
using DDD.Prac.Domain.IRepository;
using DDD.Prac.Infrastructure.ApplicationDbContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Prac.Infrastructure.Repository
{
    public class CountryRepository : ICountryRepository
    {
        private readonly AppDbContext _appdbcontext; 
        public CountryRepository(AppDbContext appDbContext)
        {
                _appdbcontext = appDbContext; 
        }
        public async Task AddCountry(Country country)
        {
            await _appdbcontext.Countries.AddAsync(country);    
            await _appdbcontext.SaveChangesAsync(); 
        }

        public async Task<IList<Country>> GetAllCountries()
        {
            return await _appdbcontext.Countries.ToListAsync(); 
        }

        public async Task<Country> GetCountryByCode(string code)
        {
            return await _appdbcontext.Countries.FirstOrDefaultAsync(x=>x.Country_code==code); 
        }
    }
}
