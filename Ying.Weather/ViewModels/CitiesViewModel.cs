using Stylet;
using StyletIoC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ying.Weather.Models;
using Ying.Weather.Utils;
using Ying.Weather.Extends;
using System.Windows;
using System.Threading.Tasks;

namespace Ying.Weather.ViewModels
{
    public class CitiesViewModel : BaseViewModel
    {
        private readonly IEventAggregator _eventAggregator;
        public List<CityInfo> CityInfos { get; set; }
        public CityInfo SelectCity { get; set; }
        public CitiesViewModel(IWindowManager windowManager, IContainer container, IEventAggregator eventAggregator) : base(windowManager, container)
        {
            _eventAggregator = eventAggregator;
        }

        protected override void OnInitialActivate()
        {
            Task.Run(() =>
            {
                CityInfos = CityUtil.GetCityInfos()?.OrderBy(p => p.Id).ToList()?.ToTree(
                    (e, c) => {
                        return c.Pid == 0;
                    },
                    (r, c) =>
                    {
                        return r.Id == c.Pid;
                    },
                    (r, datalist) =>
                    {
                        r.Childs ??= new List<CityInfo>();
                        r.Childs.AddRange(datalist);
                    });
            }).Wait(2000);
        }

        public void CityChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            try
            {
                SelectCity = (CityInfo)e.NewValue;
                _eventAggregator?.PublishOnUIThread(SelectCity.City_code, "CityChannel");
            }
            catch { }
        }
    }
}
