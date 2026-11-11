using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace SearchNarutoAPI.Models
{
    public class CharacterResponse
    {
        [JsonPropertyName("characters")]
        public List<Character> Characters { get; set; } = new();
    }
}