using Stylet;
using StyletIoC;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Ying.Weather.Models;
using Ying.Weather.Utils;

namespace Ying.Weather.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        public CitiesViewModel CitiesViewModel { get; set; }
        public WeatherDataViewModel WeatherDataViewModel { get; set; }
        public WeaResModel WeaResModel { get; set; }
        public string CityKey { get; set; }
        public MainViewModel(IWindowManager windowManager, IContainer container) : base(windowManager, container)
        {
        }

        protected override void OnInitialActivate()
        {
            CitiesViewModel = _container.Get<CitiesViewModel>();
            CitiesViewModel.ConductWith(this);

            WeatherDataViewModel = _container.Get<WeatherDataViewModel>();
            WeatherDataViewModel.ConductWith(this);
        }
    }
}
