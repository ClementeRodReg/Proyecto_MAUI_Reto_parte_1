using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_MAUI_Reto_parte_1
{
    public class EndPoint
    {
        //Conexión de la Api de GeoApi.
        public static string GetGeoApifyEndPoint(string cityName)
        {
            //return $"https://api.geoapify.com/v1/geocode/search?text=bilbao&format=json&apiKey=fa735f63a7194a57b23820d8343024b9";
            return $"https://api.geoapify.com/v1/geocode/search?text={cityName}&format=json&apiKey={Config.GeoApifyKey}";
        }

        //Conexión de la Api de MarineWeather.
        public static string getMarineWeatherEndPoint(float lat, float lon)
        {
            var url = $"https://marine-api.open-meteo.com/v1/marine?latitude={lat}&longitude={lon}&current=wave_height,wave_direction,wave_period&hourly=wave_height,wave_direction,wave_period&daily=wave_height_max,wave_direction_dominant,wave_period_max&timezone=auto";
            return url;
        }

        //Conexión de la Api de Weather App.
        public static string GetWeatherEndPoint(float lat, float lon)
        {
            //var urld = $"https://api.open-meteo.com/v1/forecast?latitude={lat}&longitude={lon}&current=temperature_2m,relativehumidity_2m,is_day&hourly=temperature_2m&daily=weathercode,temperature_2m_max,temperature_2m_min,uv_index_max&timezone=Europe%2FLondon";
            var url = $"https://api.open-meteo.com/v1/forecast?latitude={lat}&longitude={lon}&current=temperature_2m,relativehumidity_2m,is_day,precipitation,rain&hourly=temperature_2m&daily=weathercode,temperature_2m_max,temperature_2m_min,uv_index_max&timezone=Europe%2FLondon";
            return url;
        }

        //Conexión de la Api de AirQuality.

    }
}
