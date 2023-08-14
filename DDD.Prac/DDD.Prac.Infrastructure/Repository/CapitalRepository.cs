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
    public class CapitalRepository : ICapitalRepository
    {
        private readonly AppDbContext _appdbcontext; 
        public CapitalRepository(AppDbContext appDbContext )
        {
                _appdbcontext = appDbContext; 
        }
        public async Task AddCapital(Capital capital)
        {
            await _appdbcontext.Capitals.AddAsync(capital);  
            await _appdbcontext.SaveChangesAsync();  
        }

        public async Task<IList<Capital>> GetAllCapitals()
        {
            return await _appdbcontext.Capitals.ToListAsync(); 
        }

        public async Task<Capital> GetCapitalByCountryName(string countryname)
        {
            return await _appdbcontext.Capitals.Include(x=>x.Country).FirstOrDefaultAsync(x=>x.Country.Country_Name==countryname); 
        }
    }
}
