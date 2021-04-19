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

        public ObservableCollection<Provincia> Provinces { get; set; }

        public MainPageViewModel()
        {
            ElTiempoAPI = new ElTiempoAPI();
            Provinces = new ObservableCollection<Provincia>();
            LoadProvinces();
        }
        public async void LoadProvinces()
        {
            var provinciaRoot = await ElTiempoAPI.GetProvinces();
            foreach (var provincia in provinciaRoot.provincias)
            {
                Provinces.Add(provincia);
            }
        }

    }

}

