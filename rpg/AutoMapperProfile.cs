using System.Linq;
using AutoMapper;
using rpg.Dtos.Character;
using rpg.Dtos.Skill;
using rpg.Dtos.Weapon;
using rpg.Models;

namespace rpg
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Character, GetCharacterDto>();    
            CreateMap<AddCharacterDto, Character>();   
            CreateMap<Weapon, GetWeaponDto>();   
            CreateMap<Skill, GetSkillDto>(); 
            CreateMap<Character, GetCharacterDto>()
                .ForMember(dto => dto.Skills, c => c.MapFrom(c => c.CharacterSkills.Select(cs => cs.Skill))); 
        } 
    }
}