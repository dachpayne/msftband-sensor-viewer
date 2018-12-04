using System;

using Band.Samples.Helpers;
using Band.Samples.Services;
using Microsoft.Band;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Band.Samples.ViewModels
{
    public class AltimeterViewModel : SensorViewModelBase<Microsoft.Band.Sensors.IBandAltimeterReading>
    {
         
        public AltimeterViewModel()
        {
        }


        public override async void Initialize()
        {
            Microsoft.Band.IBandInfo[] pairedBands = await Microsoft.Band.BandClientManager.Instance.GetBandsAsync();
            await Services.BandService.ConnectBandAsync(pairedBands[0]);
            _sensor = Services.BandService.BandClient.SensorManager.Altimeter;

            _sensor.ReadingChanged += async (sensor, reading) =>
            {
                await CoreApplication.MainView.CoreWindow.Dispatcher.RunAsync(CoreDispatcherPriority.Normal,
           () =>
           {
               SensorReading = reading.SensorReading;

           });
            };

            base.Initialize();
        }


         





        private Microsoft.Band.Sensors.IBandAltimeterReading _sensorReading;

        public Microsoft.Band.Sensors.IBandAltimeterReading SensorReading
        {
            get => _sensorReading;
            set => Set(ref _sensorReading, value);
        }



    }
}
