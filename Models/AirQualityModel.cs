﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_MAUI_Reto_parte_1.Models
{
    internal class AirQualityModel
    {
        public float latitude { get; set; }
        public float longitude { get; set; }
        public float generationtime_ms { get; set; }
        public int utc_offset_seconds { get; set; }
        public string timezone { get; set; }
        public string timezone_abbreviation { get; set; }
        public float elevation { get; set; }
        public Current_Units_AirQuality current_units { get; set; }
        public Current_AirQuality current { get; set; }
        public Hourly_Units_AirQuality hourly_units { get; set; }
        public Hourly_AirQuality hourly { get; set; }
    }

    public class Current_Units_AirQuality
    {
        public string time { get; set; }
        public string interval { get; set; }
        public string european_aqi { get; set; }
    }

    public class Current_AirQuality
    {
        public string time { get; set; }
        public int interval { get; set; }
        public int european_aqi { get; set; }
    }

    public class Hourly_Units_AirQuality
    {
        public string time { get; set; }
        public string pm10 { get; set; }
        public string pm2_5 { get; set; }
        public string carbon_monoxide { get; set; }
        public string ozone { get; set; }
        public string european_aqi { get; set; }
    }

    public class Hourly_AirQuality
    {
        public string[] time { get; set; }
        public float?[] pm10 { get; set; }
        public float?[] pm2_5 { get; set; }
        public float?[] carbon_monoxide { get; set; }
        public float?[] ozone { get; set; }
        public int?[] european_aqi { get; set; }
    }

}
