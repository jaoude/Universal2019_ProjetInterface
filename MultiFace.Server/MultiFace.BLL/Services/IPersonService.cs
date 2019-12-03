using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MultiFace.BLL.Dtos;
using static MultiFace.Common.Enum;

namespace MultiFace.BLL.Services
{
    public interface IPersonService<Type>
    {
        Task<IEnumerable<PersonDto>> GetPersonsAsync(CancellationToken ct);

    }
}
