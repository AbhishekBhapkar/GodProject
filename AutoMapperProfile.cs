using AutoMapper;
using GodProject.Dtos.Character;
using GodProject.Dtos.Fight;
using GodProject.Dtos.Skill;
using GodProject.Dtos.Weapon;
using GodProject.Models;

namespace GodProject
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Character,GetCharacterDto>();
            CreateMap<AddCharacterDto,Character>();
            CreateMap<Weapon,GetWeaponDto>();
            CreateMap<Skill,GetSkillDto>();
            CreateMap<Character,HighScoreDto>();
        }
    }
}