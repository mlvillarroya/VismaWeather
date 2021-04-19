using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using VismaWeather.Models;

namespace VismaWeather.Services
{
    public class ElTiempoAPI
    {
        public async Task<ProvinciaRoot> GetProvinces()
        {
            var client = new HttpClient();
            var response = await client.GetStringAsync("https://www.el-tiempo.net/api/json/v2/provincias");
            return JsonConvert.DeserializeObject<ProvinciaRoot>(response);
        }
        public async Task<CityRoot> GetCities(string cODPROV)
        {
            var client = new HttpClient();
            var response = await client.GetStringAsync("https://www.el-tiempo.net/api/json/v2/provincias/" + cODPROV + "/municipios");
            return JsonConvert.DeserializeObject<CityRoot>(response);
        }
        public async Task<WeatherRoot> GetWeather(string cODPROV, string cODCITY)
        {
            var client = new HttpClient();
            string uri = "https://www.el-tiempo.net/api/json/v2/provincias/" + cODPROV + "/municipios/" + cODCITY;
            var response = await client.GetStringAsync(uri);
            return JsonConvert.DeserializeObject<WeatherRoot>(response);
        }

    }
}
