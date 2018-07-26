using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace UWPWeather.Models
{
    public class Clouds
    {
        [JsonProperty("all")]
        public long All { get; set; }
    }
}