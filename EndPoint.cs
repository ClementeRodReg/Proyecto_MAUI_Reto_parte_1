using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_MAUI_Reto_parte_1
{
    public class EndPoint
    {

        public static string GetGeoApifyEndPoint(string cityName)
        {
            //return $"https://api.geoapify.com/v1/geocode/search?text=bilbao&format=json&apiKey=fa735f63a7194a57b23820d8343024b9";
            return $"https://api.geoapify.com/v1/geocode/search?text={cityName}&format=json&apiKey={Config.GeoApifyKey}";
        }



        public static string getMarineWeatherEndPoint(float lat, float lon)
        {
            var url = $"https://marine-api.open-meteo.com/v1/marine?latitude=54.3213&longitude=10.1348&current=wave_height,wave_direction,wave_period&hourly=wave_height,wave_direction,wave_period&daily=wave_height_max,wave_direction_dominant,wave_period_max&timezone=auto";
            url = $"https://marine-api.open-meteo.com/v1/marine?latitude={lat}&longitude={lon}&current=wave_height,wave_direction,wave_period&hourly=wave_height,wave_direction,wave_period&daily=wave_height_max,wave_direction_dominant,wave_period_max&timezone=auto";
            return url;
        }

    }
}
