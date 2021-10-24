using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HarryPotterAPI.Models
{
    /// <summary>
    /// Represents any valid spell.
    /// </summary>
    public class Spell
    {
        /// <summary>
        /// The name of the spell.
        /// </summary>
        [JsonProperty("spell")]
        public string Name { get; init; }
       
        /// <summary>
        /// The type of the spell.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; init; }

        /// <summary>
        /// The incantation to cast the spell.
        /// </summary>
        [JsonProperty("incantation")]
        public string Incantation { get; init; }

        /// <summary>
        /// The description of what the spell does.
        /// </summary>
        [JsonProperty("task")]
        public string Description { get; init; }
    }
}
