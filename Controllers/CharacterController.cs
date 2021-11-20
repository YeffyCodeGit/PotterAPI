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
    /// Controls all endpoints related to getting data on all the characters in the Wizarding World.
    /// </summary>
    [ApiController]
    [Produces("application/json")]
    public class CharacterController : ControllerBase
    {
        /// <summary>
        /// Gets all the characters in the Wizarding World.
        /// </summary>
        /// <returns>Collection of all the characters.</returns>
        [HttpGet("/characters/all")]
        public async Task<IEnumerable<Character>> GetAllCharacters() => await JsonUtilities.ReadJsonAsObjectArrayAsync<Character>("./Data/characters.json");

        
        /// <summary>
        /// Returns a JSON object of the requested character.
        /// </summary>
        /// <param name="name">Name of the character.</param>
        /// <returns>The character requested by the user.</returns>
        [HttpGet("/characters")]
        public async Task<Character> GetCharacter(string name)
        {
            IEnumerable<Character> characters = await GetAllCharacters();

            return characters?.FirstOrDefault(c => c.Name == name);
        }
    }
}
