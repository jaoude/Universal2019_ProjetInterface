using Microsoft.AspNetCore.Mvc;
using MultiFace.BLL.Services;
using System.Threading;
using System.Threading.Tasks;

namespace MultiFace.Api.Controllers
{
    [Route("api/persons")]
    [ApiController]
    public class PersonsController : ControllerBase
    {
        private readonly IPersonService _personService;
        public PersonsController(IPersonService personService)
        {
            _personService = personService;
        }

        [HttpGet]
        public async Task<IActionResult> GetPersons(CancellationToken ct)
        {
            var personsDto = await _personService.GetPersonsAsync(ct);
            return Ok(personsDto);
        }


        [HttpGet]
        [Route("{id}", Name = "GetPerson")]
        public async Task<IActionResult> GetPerson(int id, CancellationToken ct)
        {
            var personDto = await _personService.GetPersonAsync(id, ct);
            return Ok(personDto);
        }
    }
}
