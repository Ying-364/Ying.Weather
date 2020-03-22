﻿using Stylet;
using StyletIoC;
using System;
using System.Collections.Generic;
using System.Text;
using Ying.Weather.Models;
using Ying.Weather.Utils;

namespace Ying.Weather.ViewModels
{
    public class WeatherDataViewModel : BaseViewModel, IHandle<string>
    {
        private readonly IEventAggregator _eventAggregator;
        public WeaResModel WeaResModel { get; set; }
        public BindableCollection<WeatherItemViewModel> WeatherItemViewModels { get; set; }
        public WeatherDataViewModel(IWindowManager windowManager, IContainer container, IEventAggregator eventAggregator) : base(windowManager, container)
        {
            _eventAggregator = eventAggregator;
            _eventAggregator.Subscribe(this, "CityChannel");
            WeatherItemViewModels = new BindableCollection<WeatherItemViewModel>();
        }

        public void Handle(string message)
        {
            Execute.OnUIThreadSync(async() =>
            {
                WeaResModel = await WeatherUtil.GetWeathers(message);

                if (WeaResModel?.Data?.Forecast != null)
                {
                    WeatherItemViewModels.Clear();

                    foreach (var item in WeaResModel.Data.Forecast)
                    {
                        var ivm = _container.Get<WeatherItemViewModel>();
                        ivm.WeatherInfo = item;
                        WeatherItemViewModels.Add(ivm);
                    }
                }
            });
        }
    }
}