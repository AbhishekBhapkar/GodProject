using GodProject.Dtos.Fight;
using GodProject.Models;

namespace GodProject.Services.FightService
{
    public interface IFightService
    {
       Task<ServiceResponse<AttackResultDto>> WeaponAttack(WeaponAttackDto request);       
       Task<ServiceResponse<AttackResultDto>> SkillAttack(SkillAttackDto request);     
       Task<ServiceResponse<FightResultsDto>> Fight(FightRequestDto request);   
       Task<ServiceResponse<List<HighScoreDto>>> GetHighscore();     


    }
}