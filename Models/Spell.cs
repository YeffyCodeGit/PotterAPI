using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HarryPotterAPI.Models
{
    public class Spell
    {
        [JsonProperty("spell")]
        public string Name { get; init; }

        [JsonProperty("type")]
        public string Type { get; init; }

        [JsonProperty("incantation")]
        public string Incantation { get; init; }

        [JsonProperty("task")]
        public string Description { get; init; }
    }
}
