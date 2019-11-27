using AutoMapper;

namespace MultiFace.BLL.Helpers
{
    public interface IAutoMapperService
    {
        IMapper Mapper { get; }
    }
}
