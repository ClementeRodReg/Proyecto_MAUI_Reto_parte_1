
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_MAUI_Reto_parte_1.Models
{
    public class AirQualityModel
    {
        public float latitude { get; set; }
        public float longitude { get; set; }
        public float generationtime_ms { get; set; }
        public int utc_offset_seconds { get; set; }
        public string timezone { get; set; }
        public string timezone_abbreviation { get; set; }
        public float elevation { get; set; }
        public Current_Units current_units { get; set; }
        public Current current { get; set; }
    }

    public class Current_Units_Air
    {
        public string time { get; set; }
        public string interval { get; set; }
        public string pm10 { get; set; }
        public string pm2_5 { get; set; }
        public string carbon_monoxide { get; set; }
        public string nitrogen_dioxide { get; set; }
        public string sulphur_dioxide { get; set; }
        public string ozone { get; set; }
    }

    public class Current_Air
    {
        public string time { get; set; }
        public int interval { get; set; }
        public float pm10 { get; set; }
        public float pm2_5 { get; set; }
        public float carbon_monoxide { get; set; }
        public float nitrogen_dioxide { get; set; }
        public float sulphur_dioxide { get; set; }
        public float ozone { get; set; }
    }

}
apps - fileview.texmex_20231026.01_p0
AirQualiryModel.txt
Mostrando AirQualiryModel.txt.