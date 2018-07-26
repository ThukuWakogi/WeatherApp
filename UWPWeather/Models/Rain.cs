using Newtonsoft.Json;

namespace UWPWeather.Models
{
    public class Rain
    {
        [JsonProperty("3h")]
        public double The3H { get; set; }
    }
}
