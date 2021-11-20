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
    /// Controls all the endpoints related to getting data on the different wizarding schools.
    /// </summary>
    [ApiController]
    [Produces("application/json")]
    public class SchoolsController : ControllerBase
    {
        /// <summary>
        /// Gets all the schools in the wizarding world.
        /// </summary>
        /// <returns>A collection of all the wizarding schools.</returns>
        [HttpGet("/schools/all")]
        public async Task<IEnumerable<School>> GetAllSchools() => await JsonUtilities.ReadJsonAsObjectArrayAsync<School>("./Data/schools.json");
        
        /// <summary>
        /// Returns a JSON object of the requested school.
        /// </summary>
        /// <param name="name">The name of the school.</param>
        /// <returns>The school requested by the user.</returns>
        [HttpGet("/schools")]
        public async Task<School> GetHouse(string name)
        {
            IEnumerable<School> houses = await GetAllSchools();

            return houses?.FirstOrDefault(h => h.Name == name);
        }
    }
}
