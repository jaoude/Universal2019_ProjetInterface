using MultiFace.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiFace.BLL.Helpers
{
    public interface IFileLoader
    {
        public Task<IEnumerable<Person>> LoadFileAsync(string FilePath, CancellationToken ct);
    }
}
