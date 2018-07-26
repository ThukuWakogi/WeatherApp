using Newtonsoft.Json;
using System;
using System.IO;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace UWPWeather.Models
{
    public class OpenWeatherMapProxy
    {
        public async static Task<WeatherModel> GetWeatherAsync(double lat, double lon)
        {
            var http = new HttpClient();
            var response = await http.GetAsync(String.Format("http://api.openweathermap.org/data/2.5/weather?lat=1.24&lon=36.67&APPID=5f3c1b2ba02841edc930859b028fe9a8&units=imperial"));
            var result = await response.Content.ReadAsStringAsync();
            //var serializer = new DataContractJsonSerializer(typeof(WeatherModel));
            //var ms = new MemoryStream(Encoding.UTF8.GetBytes(result));
            var data = JsonConvert.DeserializeObject<WeatherModel>(result);

            return data;
        }
    }
}
