using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_MAUI_Reto_parte_1.Models
{
    public class WeatherModel
    {
        public float latitude { get; set; }
        public float longitude { get; set; }
        public float generationtime_ms { get; set; }
        public int utc_offset_seconds { get; set; }
        public string timezone { get; set; }
        public string timezone_abbreviation { get; set; }
        public float elevation { get; set; }
        public Current_Units_Weather current_units { get; set; }
        public Current_Weather current { get; set; }
        public Hourly_Units_Weather hourly_units { get; set; }
        public Hourly_Weather hourly { get; set; }
        public Daily_Units_Weather daily_units { get; set; }
        public Daily_Weather daily { get; set; }
    }

    public class Current_Units_Weather
    {
        public string time { get; set; }
        public string interval { get; set; }
        public string temperature_2m { get; set; }
        public string relativehumidity_2m { get; set; }
        public string is_day { get; set; }
        public string precipitation { get; set; }
        public string rain { get; set; }
    }

    public class Current_Weather
    {
        public string time { get; set; }
        public int interval { get; set; }
        public float temperature_2m { get; set; }
        public int relativehumidity_2m { get; set; }
        public int is_day { get; set; }
        public float precipitation { get; set; }
        public float rain { get; set; }
    }

    public class Hourly_Units_Weather
    {
        public string time { get; set; }
        public string temperature_2m { get; set; }
    }

    public class Hourly_Weather
    {
        public string[] time { get; set; }
        public float[] temperature_2m { get; set; }
    }

    public class Daily_Units_Weather
    {
        public string time { get; set; }
        public string weathercode { get; set; }
        public string temperature_2m_max { get; set; }
        public string temperature_2m_min { get; set; }
        public string uv_index_max { get; set; }
    }

    public class Daily_Weather
    {
        public string[] time { get; set; }
        public int[] weathercode { get; set; }
        public float[] temperature_2m_max { get; set; }
        public float[] temperature_2m_min { get; set; }
        public float[] uv_index_max { get; set; }
    }
}
