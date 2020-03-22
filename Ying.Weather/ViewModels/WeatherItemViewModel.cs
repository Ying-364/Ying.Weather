using Stylet;
using StyletIoC;
using System;
using System.Collections.Generic;
using System.Text;
using Ying.Weather.Models;

namespace Ying.Weather.ViewModels
{
    public class WeatherItemViewModel : BaseViewModel
    {
        public WeatherInfo WeatherInfo { get; set; }
        public WeatherItemViewModel(IWindowManager windowManager, IContainer container) : base(windowManager, container)
        {
        }
    }
}
