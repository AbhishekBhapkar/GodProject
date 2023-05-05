using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GodProject.Dtos.Fight;
using GodProject.Models;
using GodProject.Services.FightService;
using Microsoft.AspNetCore.Mvc;

namespace GodProject.Controllers
{
   
    
    [ApiController]
    [Route("controller")]
    public class FightController : ControllerBase
    {
        private readonly IFightService _fightService;

        public FightController(IFightService fightService)
        {
            _fightService = fightService;
        }

        [HttpPost("Weapon")]
        public async Task<ActionResult<ServiceResponse<AttackResultDto>>> WeaponAttack(WeaponAttackDto request)
        {
            return Ok(await _fightService.WeaponAttack(request));
        }

        [HttpPost("Skill")]
        public async Task<ActionResult<ServiceResponse<AttackResultDto>>> SkillAttack(SkillAttackDto request)
        {
            return Ok(await _fightService.SkillAttack(request));
        }
        
        [HttpPost("Fight")]
        public async Task<ActionResult<ServiceResponse<FightResultsDto>>> Fight(FightRequestDto request)
        {
            return Ok(await _fightService.Fight(request));
        }
        
        [HttpGet("Fight")]
        public async Task<ActionResult<ServiceResponse<List<HighScoreDto>>>> GetHighScore()
        {
            return Ok(await _fightService.GetHighscore());
        }
        
              
    }
}