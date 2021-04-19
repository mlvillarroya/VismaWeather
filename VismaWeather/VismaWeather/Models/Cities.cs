using System.Collections.Generic;

namespace VismaWeather.Models
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class Municipio
    {
        public string CODIGOINE { get; set; }
        public string ID_REL { get; set; }
        public string COD_GEO { get; set; }
        public string CODPROV { get; set; }
        public string NOMBRE_PROVINCIA { get; set; }
        public string NOMBRE { get; set; }
        public int POBLACION_MUNI { get; set; }
        public double SUPERFICIE { get; set; }
        public int PERIMETRO { get; set; }
        public string CODIGOINE_CAPITAL { get; set; }
        public string NOMBRE_CAPITAL { get; set; }
        public string POBLACION_CAPITAL { get; set; }
        public string HOJA_MTN25 { get; set; }
        public double LONGITUD_ETRS89_REGCAN95 { get; set; }
        public double LATITUD_ETRS89_REGCAN95 { get; set; }
        public string ORIGEN_COORD { get; set; }
        public int ALTITUD { get; set; }
        public string ORIGEN_ALTITUD { get; set; }
        public int DISCREPANTE_INE { get; set; }
    }

    public class CityBreadcrumb
    {
        public string name { get; set; }
        public string url { get; set; }
        public string title { get; set; }
    }

    public class CityRoot
    {
        public string title { get; set; }
        public string provincia { get; set; }
        public string codprov { get; set; }
        public string metadescripcion { get; set; }
        public string keywords { get; set; }
        public List<Municipio> municipios { get; set; }
        public List<CityBreadcrumb> breadcrumb { get; set; }
    }


}
