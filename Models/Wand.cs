using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HarryPotterAPI.Models
{
    /// <summary>
    /// Represents a wand in the Wizarding World.
    /// </summary>
    public class Wand
    {
        /// <summary>
        /// The wood the wand is made of.
        /// </summary>
        [JsonProperty("wood")]
        public string Wood { get; init; }

        /// <summary>
        /// The core of the wand.
        /// </summary>
        [JsonProperty("core")]
        public string Core { get; init; }

        /// <summary>
        /// The length of the wand.
        /// </summary>
        [JsonProperty("length")]
        public float? Length { get; init; }
    }
}
