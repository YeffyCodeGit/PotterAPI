using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HarryPotterAPI.Models
{
    public class Character
    {
        [JsonProperty("name")]
        public string Name { get; init; }

        [JsonProperty("actor")]
        public string Actor { get; init; }

        [JsonProperty("house")]
        public string House { get; init; }

        [JsonProperty("gender")]
        public string Gender { get; init; }

        [JsonProperty("blood_status")]
        public string BloodStatus { get; init; }

        [JsonProperty("is_death_eater")]
        public bool IsDeathEater { get; init; }

        [JsonProperty("patronus")]
        public string Patronus { get; init; }

        [JsonProperty("wand")]
        public Wand[] Wands { get; init; }
    }
}
