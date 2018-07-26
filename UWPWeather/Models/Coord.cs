using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace UWPWeather.Models
{
    public class Coord
    {
        [JsonProperty("lon")]
        public double Lon { get; set; }

        [JsonProperty("lat")]
        public double Lat { get; set; }
    }
}