using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MultiFace.BLL.Dtos;

namespace MultiFace.BLL.Services
{
    public interface IPersonService
    {
        Task<PersonDto> GetPersonAsync(int id, CancellationToken ct);
        Task<IEnumerable<PersonDto>> GetPersonsAsync(CancellationToken ct);
    }
}
