using AutoMapper;

namespace MultiFace.BLL.Helpers
{
    public class AutoMapperService : IAutoMapperService
    {
        public IMapper Mapper
        {
            get { return ObjectMapper.Mapper; }
        }
    }
}
