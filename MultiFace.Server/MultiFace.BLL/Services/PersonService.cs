using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MultiFace.DAL.Entities;
using MultiFace.BLL.Helpers;
using MultiFace.BLL.Dtos;
using MultiFace.DAL.UnitOfWork;

namespace MultiFace.BLL.Services
{
    public class PersonService : IPersonService
    {
        protected readonly IUnitOfWork _unit;
        protected readonly IAutoMapperService _mapper;
        public PersonService(IUnitOfWork unit, IAutoMapperService mapper)
        {
            _unit = unit;
            _mapper = mapper;
        }
        public async Task<PersonDto> GetPersonAsync(int id, CancellationToken ct)
        {
            Person persons = await _unit.Persons.GetPersonAsync(id, ct);
            PersonDto personsDto = _mapper.Mapper.Map<PersonDto>(persons);
            return personsDto;
        }

        public async Task<IEnumerable<PersonDto>> GetPersonsAsync(CancellationToken ct)
        {
            IEnumerable<Person> persons = await _unit.Persons.GetPersonsAsync(ct);
            IEnumerable<PersonDto> personsDto = _mapper.Mapper.Map<IEnumerable<PersonDto>>(persons);
            return personsDto.ToList();
            //https://localhost:44383/weatherforecast
        }
    }
}
