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
    public class SpellsController : ControllerBase
    {
        [HttpGet("/spells/all")]
        public async Task<IEnumerable<Spell>> GetAllSpells() => await JsonUtilities.ReadJsonAsObjectArrayAsync<Spell>("./Data/spells.json");
    }
}
