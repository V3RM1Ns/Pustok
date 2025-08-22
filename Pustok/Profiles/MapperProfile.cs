using AutoMapper;
using Pustok.Models;
using Pustok.ViewModels;

namespace Pustok.Profiles
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Book, BookDetailVm>()
           
        }
    }
}