using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Devices.Geolocation;

namespace UWPWeather.Models
{
    class LocationManager
    {
        public async static Task<Geoposition> GetPositionAsync()
        {
            if (await Geolocator.RequestAccessAsync() != GeolocationAccessStatus.Allowed) throw new Exception();
            
            return await new Geolocator { DesiredAccuracyInMeters = 0 }.GetGeopositionAsync();
        }
    }
}
