using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace UWPWeather.Models
{
    public class Wind
    {
        [JsonProperty("speed")]
        public double Speed { get; set; }

        [JsonProperty("deg")]
        public double Deg { get; set; }
    }
}