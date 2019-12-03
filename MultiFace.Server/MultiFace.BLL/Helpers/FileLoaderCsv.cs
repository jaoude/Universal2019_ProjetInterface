using CsvHelper;
using MultiFace.BLL.Dtos;
using MultiFace.DAL.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiFace.BLL.Helpers
{
    public class FileLoaderCsv : IFileLoader
    {
        public async Task<IEnumerable<Person>> LoadFileAsync(string filePath, CancellationToken ct)
        {
            TextReader reader = new StreamReader(filePath);
            var csvReader = new CsvReader(reader);
            return await Task.Run(() => csvReader.GetRecords<Person>(), ct);
        }
    }
}
