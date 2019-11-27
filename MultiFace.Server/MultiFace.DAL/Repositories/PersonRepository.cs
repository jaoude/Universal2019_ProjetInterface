using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MultiFace.DAL.ApplicationDbContext;
using MultiFace.DAL.Entities;

namespace MultiFace.DAL.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        private AppDbContext _context;
        public PersonRepository(AppDbContext _con)
        {
            _context = _con;
        }
        public async Task<Person> GetPersonAsync(int id, CancellationToken ct)
        {
            return await _context.Set<Person>().FirstOrDefaultAsync(ct);
        }

        public async Task<IEnumerable<Person>> GetPersonsAsync(CancellationToken ct)
        {
            return await _context.Set<Person>().ToListAsync(ct);
        }
    }
}
