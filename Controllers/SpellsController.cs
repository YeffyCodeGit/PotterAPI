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
    /// <summary>
    /// Controls all the endpoints related to getting data on the different spells in the Wizarding World.
    /// </summary>
    [ApiController]
    [Produces("application/json")]
    public class SpellsController : ControllerBase
    {
        /// <summary>
        /// Gets all the (known) spells in the Wizarding World.
        /// </summary>
        /// <returns>A collection of all the spells.</returns>
        [HttpGet("/spells/all")]
        public async Task<IEnumerable<Spell>> GetAllSpells() => await JsonUtilities.ReadJsonAsObjectArrayAsync<Spell>("./Data/spells.json");
        
        /// <summary>
        /// Returns a JSON object of the requested house.
        /// </summary>
        /// <param name="name">The name of the house.</param>
        /// <returns>The house requested by the user.</returns>
        [HttpGet("/spells")]
        public async Task<Spell> GetHouse(string name)
        {
            IEnumerable<Spell> houses = await GetAllSpells();

            return houses?.FirstOrDefault(h => h.Name == name);
        }
    }
}
