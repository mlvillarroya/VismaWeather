using Newtonsoft.Json;
using System.Collections.Generic;


namespace VismaWeather.Models
{

    public class StateSky
    {
        public string description { get; set; }
        public string id { get; set; }
    }

    public class Temperaturas
    {
        public string max { get; set; }
        public string min { get; set; }
    }

    public class Attributes
    {
        public string fecha { get; set; }
        public string orto { get; set; }
        public string ocaso { get; set; }
        public string periodo { get; set; }
    }

    public class Viento
    {
        [JsonProperty("@attributes")]
        public Attributes Attributes { get; set; }
        public string direccion { get; set; }
        public string velocidad { get; set; }
    }

    public class Hoy
    {
        [JsonProperty("@attributes")]
        public Attributes Attributes { get; set; }
        public List<string> estado_cielo { get; set; }
        public List<string> precipitacion { get; set; }
        public List<string> prob_precipitacion { get; set; }
        public List<string> prob_tormenta { get; set; }
        public List<string> nieve { get; set; }
        public List<string> prob_nieve { get; set; }
        public List<string> temperatura { get; set; }
        public List<string> sens_termica { get; set; }
        public List<string> humedad_relativa { get; set; }
        public List<Viento> viento { get; set; }
        public List<string> racha_max { get; set; }
    }

    public class Manana
    {
        [JsonProperty("@attributes")]
        public Attributes Attributes { get; set; }
        public List<string> estado_cielo { get; set; }
        public List<string> precipitacion { get; set; }
        public List<string> prob_precipitacion { get; set; }
        public List<string> prob_tormenta { get; set; }
        public List<string> nieve { get; set; }
        public List<string> prob_nieve { get; set; }
        public List<string> temperatura { get; set; }
        public List<string> sens_termica { get; set; }
        public List<string> humedad_relativa { get; set; }
        public List<Viento> viento { get; set; }
        public List<string> racha_max { get; set; }
    }

    public class Pronostico
    {
        public Hoy hoy { get; set; }
        public Manana manana { get; set; }
    }

    public class Temperatura
    {
        public string maxima { get; set; }
        public string minima { get; set; }
        public List<string> dato { get; set; }
    }

    public class SensTermica
    {
        public string maxima { get; set; }
        public string minima { get; set; }
        public List<string> dato { get; set; }
    }

    public class HumedadRelativa
    {
        public string maxima { get; set; }
        public string minima { get; set; }
        public List<string> dato { get; set; }
    }

    public class ProximosDia
    {
        [JsonProperty("@attributes")]
        public Attributes Attributes { get; set; }
        public object prob_precipitacion { get; set; }
        public object cota_nieve_prov { get; set; }
        public object estado_cielo { get; set; }
        public object viento { get; set; }
        public object racha_max { get; set; }
        public Temperatura temperatura { get; set; }
        public SensTermica sens_termica { get; set; }
        public HumedadRelativa humedad_relativa { get; set; }
        public string uv_max { get; set; }
    }

    public class WeatherBreadcrumb
    {
        public string name { get; set; }
        public string url { get; set; }
        public string title { get; set; }
    }

    public class WeatherRoot
    {
        public Municipio municipio { get; set; }
        public string fecha { get; set; }
        public StateSky stateSky { get; set; }
        public string temperatura_actual { get; set; }
        public Temperaturas temperaturas { get; set; }
        public string humedad { get; set; }
        public string viento { get; set; }
        public string lluvia { get; set; }
        public object imagen { get; set; }
        public Pronostico pronostico { get; set; }
        public List<ProximosDia> proximos_dias { get; set; }
        public List<WeatherBreadcrumb> breadcrumb { get; set; }
        public string keywords { get; set; }
    }

}
