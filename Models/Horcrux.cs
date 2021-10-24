using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HarryPotterAPI.Models
{ 
    /// <summary>
    /// Represents any of Tom Riddle's horcruxes;
    /// </summary>
    public class Horcrux 
    {
        /// <summary>
        /// The name of the horcrux.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; init; }

        /// <summary>
        /// The victim killed in order to make the horcrux.
        /// </summary>
        [JsonProperty("victim")]
        public string Victim { get; init; }
        
        /// <summary>
        /// The place the horcrux was hidden.
        /// </summary>
        [JsonProperty("hiding_place")]
        public string HidingPlace { get; init; }

        /// <summary>
        /// The person who destroyed the horcrux.
        /// </summary>
        [JsonProperty("destroyed_by")]
        public string DestroyedBy { get; init; }

        /// <summary>
        /// The spell or weapon used to destroy the horcrux.
        /// </summary>
        [JsonProperty("destroyed_with")]
        public string DestroyedWith { get; init; }
    }
}
