using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using AutoMapper;
using GodProject.Data;
using GodProject.Dtos.Character;
using GodProject.Dtos.Weapon;
using GodProject.Models;
using Microsoft.EntityFrameworkCore;

namespace GodProject.Services.WeaponService
{
    public class WeaponService : IWeaponService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IMapper _mapper;
        private readonly DataContext _context;

        public WeaponService(DataContext context , IHttpContextAccessor httpContextAccessor , IMapper mapper)
        {
            _httpContextAccessor = httpContextAccessor;
            _mapper = mapper;
            _context = context;
            
        }
        public async Task<ServiceResponse<GetCharacterDto>> AddWeapon(AddWeaponDto newWeapon)
        {
            var response = new ServiceResponse<GetCharacterDto>();
        try
        {
           var character = await _context.Characters
           .FirstOrDefaultAsync( c=> c.Id == newWeapon.CharacterId && 
                c.User!.Id == int.Parse(_httpContextAccessor.HttpContext!.User
                    .FindFirstValue(ClaimTypes.NameIdentifier)!));        

            if(character is null)
            {
                response.Success = false;
                response.Message = "Character not found";
                return response;

            }       

            var weapon = new Weapon
            {
                Name = newWeapon.Name,
                Damage = newWeapon.Damage,
                Character = character
            };

            _context.Weapons.Add(weapon);
            await _context.SaveChangesAsync();

            response.Data = _mapper.Map<GetCharacterDto>(character);

            
        }
        catch (System.Exception ex)
        {
            
            response.Success = false;
            response.Message = ex.Message;
        }       
        return response;

        }
    }
}