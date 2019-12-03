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
    public class PersonServiceSql : IPersonService<PersonServiceSql>
    {
        protected readonly IUnitOfWork _unit;
        protected readonly IAutoMapperService _mapper;

        public PersonServiceSql(IUnitOfWork unit, IAutoMapperService mapper)
        {
            _unit = unit;
            _mapper = mapper;
        }

        public async Task<IEnumerable<PersonDto>> GetPersonsAsync(CancellationToken ct)
        {
            IEnumerable<Person> persons = await _unit.Persons.GetPersonsAsync(ct);
            IEnumerable<PersonDto> personsDto = _mapper.Mapper.Map<IEnumerable<PersonDto>>(persons);
            return personsDto.ToList();
        }
    }
}
