using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using CsvHelper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MutliFace.WebService.Controllers
{
    [ApiController]
    [Route("persons")]
    public class PersonsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetPersons()
        {
            TextReader reader = new StreamReader("File.csv");
            var csvReader = new CsvReader(reader);
            var records = csvReader.GetRecords<PersonDto>();
            return Ok(records.ToList());
        }
    }
}
