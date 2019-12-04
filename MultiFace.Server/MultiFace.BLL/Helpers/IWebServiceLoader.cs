using MultiFace.BLL.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiFace.BLL.Helpers
{
    public interface IWebServiceLoader
    {
        public Task<IEnumerable<PersonDto>> LoadWebServiceAsync(string Path, CancellationToken ct);
    }
}
