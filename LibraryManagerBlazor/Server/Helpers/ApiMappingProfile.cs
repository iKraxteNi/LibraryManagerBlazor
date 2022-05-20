using AutoMapper;
using LibraryManagerBlazor.Shared.DTOs;
using LibraryManagerBlazor.Shared.Entities;

namespace LibraryManagerBlazor.Server
{
    public class ApiMappingProfile : Profile
    {
        public ApiMappingProfile()
        {
            CreateMap<Book,BookDTO>().ReverseMap();
            CreateMap<Customer,CustomerDTO>().ReverseMap();
            CreateMap<Cover,CoverDTO>().ReverseMap();
            CreateMap<Category,CategoryDTO>().ReverseMap();

        }
    }
}
