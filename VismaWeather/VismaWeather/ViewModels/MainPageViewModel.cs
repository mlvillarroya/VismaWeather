using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using VismaWeather.Models;
using VismaWeather.Services;

namespace VismaWeather.ViewModels
{
    public class MainPageViewModel : BaseViewModel
    {
        ElTiempoAPI ElTiempoAPI;

        private Provincia selecteProvince;
        public Provincia SelectedProvince
        {
            get { return selecteProvince; }
            set 
            { 
                selecteProvince = value;
                OnPropertyChanged();
                LoadCities(SelectedProvince.CODPROV);
            }
        }

        private Municipio selectedCity;

        public Municipio SelectedCity
        {
            get { return selectedCity; }
            set 
            { 
                selectedCity = value;
                OnPropertyChanged();
                LoadWeather();
            }
        }

        public ObservableCollection<Provincia> Provinces { get; set; }
        public ObservableCollection<Municipio> Cities { get; set; }

        public bool Ready { get; set; }

        private WeatherRoot weather;
        public WeatherRoot Weather
        {
            get { return weather; }
            set 
            { 
                weather = value;
                Ready = true;
                OnPropertyChanged();
                OnPropertyChanged("Ready");
            }
        }

        public MainPageViewModel()
        {
            ElTiempoAPI = new ElTiempoAPI();
            Provinces = new ObservableCollection<Provincia>();
            Cities = new ObservableCollection<Municipio>();
            Ready = false;
            LoadProvinces();
        }
        private async void LoadProvinces()
        {
            var provinciaRoot = await ElTiempoAPI.GetProvinces();
            foreach (var provincia in provinciaRoot.provincias)
            {
                Provinces.Add(provincia);
            }
        }

        private async void LoadCities(string CODPROV)
        {
            var cityRoot = await ElTiempoAPI.GetCities(CODPROV);
            foreach (var city in cityRoot.municipios)
            {
                Cities.Add(city);
            }
        }
        private async void LoadWeather()
        {
            string codCity = SelectedCity.CODIGOINE.TrimEnd(new Char[] { '0' });
            Weather = await ElTiempoAPI.GetWeather(SelectedCity.CODPROV, codCity);
        }


    }

}

