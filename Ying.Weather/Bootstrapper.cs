using System;
using Stylet;
using StyletIoC;
using Ying.Weather.ViewModels;

namespace Ying.Weather
{
    public class Bootstrapper : Bootstrapper<ConductorViewModel>
    {
        protected override void ConfigureIoC(IStyletIoCBuilder builder)
        {
            // Configure the IoC container in here
        }

        protected override void Configure()
        {
            // Perform any other configuration before the application starts
        }

        protected override void OnStart()
        {
            base.OnStart();
#if DEBUG
            Stylet.Logging.LogManager.Enabled = true;
#endif
        }
    }
}
