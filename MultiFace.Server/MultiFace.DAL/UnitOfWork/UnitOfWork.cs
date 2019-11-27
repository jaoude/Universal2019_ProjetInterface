using System;
using MultiFace.DAL.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace MultiFace.DAL.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IServiceProvider _serviceProvider;
        public UnitOfWork(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public IPersonRepository Persons => _serviceProvider.GetService<IPersonRepository>();
    }
}
