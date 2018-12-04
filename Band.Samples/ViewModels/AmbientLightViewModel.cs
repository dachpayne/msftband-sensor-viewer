using System;

using Band.Samples.Helpers;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Band.Samples.ViewModels
{
    public class AmbientLightViewModel : SensorViewModelBase<Microsoft.Band.Sensors.IBandAmbientLightReading>
    {

         
        public AmbientLightViewModel()
        {
            
        }



        public override async void Initialize()
        {
            Microsoft.Band.IBandInfo[] pairedBands = await Microsoft.Band.BandClientManager.Instance.GetBandsAsync();
            await Services.BandService.ConnectBandAsync(pairedBands[0]);
            _sensor = Services.BandService.BandClient.SensorManager.AmbientLight;

            _sensor.ReadingChanged += async (sensor, reading) =>
            {
                await CoreApplication.MainView.CoreWindow.Dispatcher.RunAsync(CoreDispatcherPriority.Normal,
           () =>
           {
               Brightness = reading.SensorReading.Brightness;

           });
            };

            base.Initialize();
        }

        private int _brightness;

        public int Brightness
        {
            get => _brightness;
            set => Set(ref _brightness, value);
        }



    }
}
