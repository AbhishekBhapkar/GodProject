using AutoMapper;
using GodProject.Dtos.Character;
using GodProject.Models;

namespace GodProject
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Character,GetCharacterDto>();
            CreateMap<AddCharacterDto,Character>();
        }
    }
}