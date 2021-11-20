using HarryPotterAPI.Models;
using HarryPotterAPI.Utilities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HarryPotterAPI.Controllers
{
    /// <summary>
    /// Controls all the endpoints related to getting data on all of Voldemort's horcruxes.
    /// </summary>
    [ApiController]
    [Produces("application/json")]
    public class HorcruxesController : ControllerBase
    {
        /// <summary>
        /// Gets all of Voldemort's horcruxes.
        /// </summary>
        /// <returns>A collection of all the horcruxes.</returns>
        [HttpGet("/horcruxes/all")]
        public async Task<IEnumerable<Horcrux>> GetAllHorcruxes() => await JsonUtilities.ReadJsonAsObjectArrayAsync<Horcrux>("./Data/horcruxes.json");

        
        /// <summary>
        /// Returns a JSON object of the requested horcruxes.
        /// </summary>
        /// <param name="name">The name of the horcrux.</param>
        /// <returns>The horcrux requested by the user.</returns>
        [HttpGet("/horcruxes")]
        public async Task<Horcrux> GetHorcrux(string name)
        {
            IEnumerable<Horcrux> horcruxes = await GetAllHorcruxes();

            return horcruxes?.FirstOrDefault(h => h.Name == name);
        }
    }
}
