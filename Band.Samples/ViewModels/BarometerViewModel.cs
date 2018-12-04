using System;

using Band.Samples.Helpers;

namespace Band.Samples.ViewModels
{
    public class BarometerViewModel : SensorViewModelBase<Microsoft.Band.Sensors.IBandBarometerReading>
    {
        public BarometerViewModel()
        {

        }



         
        private double _airPressure;
        public double AirPressure
        {
            get => _airPressure;
            set => Set(ref _airPressure, value);
        }

        private double _temperature;
        public double Temperature
        {
            get => _temperature;
            set => Set(ref _temperature, value);
        }



    }
}
