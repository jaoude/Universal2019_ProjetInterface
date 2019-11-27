using MultiFace.DAL.Entities;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace MultiFace.DAL.Repositories
{
    public interface IPersonRepository
    {
        Task<Person> GetPersonAsync(int id, CancellationToken ct);
        Task<IEnumerable<Person>> GetPersonsAsync(CancellationToken ct);
    }
}
