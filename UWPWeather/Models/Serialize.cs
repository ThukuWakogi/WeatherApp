using Newtonsoft.Json;

namespace UWPWeather.Models
{
    public static class Serialize
    {
        public static string ToJson(this WeatherModel self) => JsonConvert.SerializeObject(self, Converter.Settings);
    }
}
