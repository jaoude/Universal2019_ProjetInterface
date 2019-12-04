using MultiFace.BLL.Dtos;
using MultiFace.DAL.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiFace.BLL.Helpers
{
    public class WebServiceLoader:IWebServiceLoader
    {
        public async Task<IEnumerable<PersonDto>> LoadWebServiceAsync(string Path, CancellationToken ct)
        {
            using var client = new HttpClient();
            var result = await client.GetAsync(Path,ct);
            string s = await result.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<IEnumerable<PersonDto>>(s);
        }
    }
}
