using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GodProject.Dtos.Character;

namespace GodProject.Models
{
    public class ServiceResponse<T>
    {
        public T? Data { get; set; }
        public bool Success { get; set; } = true;
        public string Message { get; set; } = string.Empty;


    }
}