using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MultiFace.DAL.Entities;
using MultiFace.BLL.Helpers;
using MultiFace.BLL.Dtos;
using MultiFace.DAL.UnitOfWork;
using static MultiFace.Common.Enum;


namespace MultiFace.BLL.Services
{
    public class PersonServiceCsv : IPersonService<PersonServiceCsv>
    {
        protected readonly IFileLoader _fileLoaderCsv;
        protected readonly IAutoMapperService _mapper;

        public PersonServiceCsv(IFileLoader fileLoaderCsv, IAutoMapperService mapper)
        {
            _fileLoaderCsv = fileLoaderCsv;
            _mapper = mapper;
        }

        public async Task<IEnumerable<PersonDto>> GetPersonsAsync(CancellationToken ct)
        {
            IEnumerable<Person> persons = await _fileLoaderCsv.LoadFileAsync(@"C:\Users\g-gui\Documents\okok.csv", ct);
            IEnumerable<PersonDto> personsDto = _mapper.Mapper.Map<IEnumerable<PersonDto>>(persons);
            return personsDto.ToList();
        }
    }
}
