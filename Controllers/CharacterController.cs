using HarryPotterAPI.Models;
using HarryPotterAPI.Utilities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HarryPotterAPI.Controllers
{
    [ApiController]
    [Produces("application/json")]
    public class CharacterController : ControllerBase
    {
        [HttpGet("/characters/all")]
        public async Task<IEnumerable<Character>> GetAllCharacters() => await JsonUtilities.ReadJsonAsObjectArrayAsync<Character>("./Data/characters.json");
    }
}
