using LiveCharts;
using Stylet;
using StyletIoC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Navigation;
using Ying.Weather.Models;
using Ying.Weather.Utils;

namespace Ying.Weather.ViewModels
{
    public class WeatherDataViewModel : BaseViewModel, IHandle<string>
    {
        private readonly IEventAggregator _eventAggregator;
        public WeaResModel WeaResModel { get; set; }
        public BindableCollection<WeatherItemViewModel> WeatherItemViewModels { get; set; }
        public ChartValues<double> LowValues { get; set; } = new ChartValues<double>();
        public ChartValues<double> HighValues { get; set; } = new ChartValues<double>();
        public List<string> Ymds => WeatherItemViewModels?.Select(p => p.WeatherInfo.Ymd)?.ToList();

        public Visibility ChartVisibility { get; set; } = Visibility.Hidden;
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
                WeatherItemViewModels?.Clear();
                LowValues?.Clear();
                HighValues?.Clear();
                GC.Collect();

                WeaResModel = await WeatherUtil.GetWeathers(message);

                if (WeaResModel?.Data?.Forecast != null)
                {
                    ChartVisibility = Visibility.Visible;
                    foreach (var item in WeaResModel.Data.Forecast)
                    {
                        var ivm = _container.Get<WeatherItemViewModel>();
                        ivm.WeatherInfo = item;
                        await Task.Delay(200);
                        WeatherItemViewModels.Add(ivm);
                        LowValues.Add(item.LowNum);
                        HighValues.Add(item.HighNum);
                    }
                }
                else
                {
                    ChartVisibility = Visibility.Hidden;
                }
            });
        }
    }
}
