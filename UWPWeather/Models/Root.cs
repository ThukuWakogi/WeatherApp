using Newtonsoft.Json;

namespace UWPWeather.Models
{
    public class Root
    {
        public static Root FromJson(string json) => JsonConvert.DeserializeObject<Root>(json, Converter.Settings);
    }
}
