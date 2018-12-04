using System;

using Band.Samples.Helpers;
using Windows.ApplicationModel.Core;

namespace Band.Samples.ViewModels
{
    public class GsrViewModel : SensorViewModelBase<Microsoft.Band.Sensors.IBandGsrReading>
    {
  


        public override async void Initialize()
        {
            Microsoft.Band.IBandInfo[] pairedBands = await Microsoft.Band.BandClientManager.Instance.GetBandsAsync();
            await Services.BandService.ConnectBandAsync(pairedBands[0]);
            _sensor = Services.BandService.BandClient.SensorManager.Gsr;

            _sensor.ReadingChanged += async (sensor, reading) =>
            {
                await CoreApplication.MainView.CoreWindow.Dispatcher.RunAsync(Windows.UI.Core.CoreDispatcherPriority.Normal,
           () =>
           {
               SensorReading = reading.SensorReading;

           });
            };

            base.Initialize();
        }








        private Microsoft.Band.Sensors.IBandGsrReading _sensorReading;

        public Microsoft.Band.Sensors.IBandGsrReading SensorReading
        {
            get => _sensorReading;
            set => Set(ref _sensorReading, value);
        }
    }
}
