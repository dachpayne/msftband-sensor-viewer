using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Windows.UI.Xaml.Navigation;
using Band.Samples.Helpers;
using Microsoft.Band;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Band.Samples.ViewModels
{
    public class AccelerometerViewModel : SensorViewModelBase<Microsoft.Band.Sensors.IBandAccelerometerReading>
    {


        public override async void Initialize()
        {
            Microsoft.Band.IBandInfo[] pairedBands = await Microsoft.Band.BandClientManager.Instance.GetBandsAsync();
            await Services.BandService.ConnectBandAsync(pairedBands[0]);
            _sensor = Services.BandService.BandClient.SensorManager.Accelerometer;

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

        private Microsoft.Band.Sensors.IBandAccelerometerReading _sensorReading;

        public Microsoft.Band.Sensors.IBandAccelerometerReading SensorReading
        {
            get => _sensorReading;
            set => Set(ref _sensorReading, value);
        }
    }
}
