using MultiFace.DAL.Repositories;

namespace MultiFace.DAL.UnitOfWork
{
    public interface IUnitOfWork
    {
        IPersonRepository Persons { get; }
    }
}
