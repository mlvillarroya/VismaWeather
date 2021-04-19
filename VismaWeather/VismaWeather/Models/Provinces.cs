using System.Collections.Generic;

namespace VismaWeather.Models
{

    public class Provincia
    {
        public string CODPROV { get; set; }
        public string NOMBRE_PROVINCIA { get; set; }
        public string CODAUTON { get; set; }
        public string COMUNIDAD_CIUDAD_AUTONOMA { get; set; }
        public string CAPITAL_PROVINCIA { get; set; }
    }

    public class ProvinciaBreadcrumb
    {
        public string name { get; set; }
        public object url { get; set; }
        public string title { get; set; }
    }

    public class ProvinciaRoot
    {
        public string title { get; set; }
        public List<Provincia> provincias { get; set; }
        public List<ProvinciaBreadcrumb> breadcrumb { get; set; }
        public string metadescripcion { get; set; }
        public string keywords { get; set; }
    }
}

