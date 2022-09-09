using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace gamma_console.Models
{
    public class Member
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("fullName")]
        public string FullName { get; set; }
        [JsonProperty("team")]
        public string Team { get; set; }
        [JsonProperty("favoriteMovies")]
        public List<string> FavoriteMovies { get; set; }
    }
}
