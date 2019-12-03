using Microsoft.AspNetCore.Mvc;
using MultiFace.BLL.Services;
using System.Threading;
using System.Threading.Tasks;
using static MultiFace.Common.Enum;

namespace MultiFace.Api.Controllers
{
    [Route("api/persons")]
    [ApiController]
    public class PersonsController : ControllerBase
    {
        private readonly IPersonService<PersonServiceSql> _personServiceSql;
        private readonly IPersonService<PersonServiceCsv> _personServiceCsv;
        private readonly IPersonService<PersonServiceWeb> _personServiceWeb;

        public PersonsController(IPersonService<PersonServiceSql> personServiceSql, IPersonService<PersonServiceCsv> personServiceCsv,
            IPersonService<PersonServiceWeb> personServiceWeb)
        {
            _personServiceSql = personServiceSql;
            _personServiceCsv = personServiceCsv;
            _personServiceWeb = personServiceWeb;
        }


        [HttpGet]
        [Route("{requestType}")]
        public async Task<IActionResult> GetPersons(RequestType requestType,CancellationToken ct)
        {
            switch (requestType)
            {
                
                case (RequestType.Csv):
                    return Ok(await _personServiceCsv.GetPersonsAsync(ct));
                case (RequestType.Web):
                    return Ok(await _personServiceWeb.GetPersonsAsync(ct));
                case (RequestType.Sql):
                default:
                    return Ok(await _personServiceSql.GetPersonsAsync(ct));

            }
          
        }
    }
}
