using AutoMapper;
using MultiFace.DAL.Entities;
using MultiFace.BLL.Dtos;

namespace MultiFace.BLL.Helpers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Person, PersonDto>();
        }
    }
}
