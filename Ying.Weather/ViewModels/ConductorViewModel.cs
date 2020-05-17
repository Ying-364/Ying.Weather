using Newtonsoft.Json;
using Stylet;
using StyletIoC;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Ying.Weather.Models;

namespace Ying.Weather.ViewModels
{
    public class ConductorViewModel : Conductor<IScreen>.StackNavigation
    {
        private readonly IWindowManager _windowManager;
        private readonly IContainer _container;

        public ConductorViewModel(IWindowManager windowManager, IContainer container)
        {
            _windowManager = windowManager;
            _container = container;
        }

        protected override void OnInitialActivate()
        {
            this.DisplayName = "sojson天气";
            this.ActivateItem(_container.Get<MainViewModel>());
        }

        public void CLoseWindow()
        {
            this.RequestClose();
        }
    }
}
