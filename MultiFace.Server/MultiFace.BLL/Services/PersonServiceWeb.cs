using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MultiFace.DAL.Entities;
using MultiFace.BLL.Helpers;
using MultiFace.BLL.Dtos;
using MultiFace.DAL.UnitOfWork;
using static MultiFace.Common.Enum;
using System.Net.Http;

namespace MultiFace.BLL.Services
{
    public class PersonServiceWeb : IPersonService<PersonServiceWeb>
    {
        protected readonly IWebServiceLoader _loader;
        public PersonServiceWeb(IWebServiceLoader loader)
        {
            _loader = loader;
        }

        public async Task<IEnumerable<PersonDto>> GetPersonsAsync(CancellationToken ct)
        {
            IEnumerable<PersonDto> personsDto = await _loader.LoadWebServiceAsync("https://localhost:5001/persons", ct);
            return personsDto.ToList();
        }
    }
}
