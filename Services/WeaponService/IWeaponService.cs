using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GodProject.Dtos.Character;
using GodProject.Dtos.Weapon;
using GodProject.Models;

namespace GodProject.Services.WeaponService
{
    public interface IWeaponService
    {
        Task<ServiceResponse<GetCharacterDto>> AddWeapon (AddWeaponDto newWeapon);
    }
}