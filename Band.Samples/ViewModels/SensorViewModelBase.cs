using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Band.Samples.Helpers;
using Band.Samples.Services;
using Microsoft.Band.Sensors;
using Windows.UI.Xaml.Navigation;

namespace Band.Samples.ViewModels
{
    public class SensorViewModelBase<T> : Observable where T : Microsoft.Band.Sensors.IBandSensorReading
    {
        public Microsoft.Band.Sensors.IBandSensor<T> _sensor = null;

        


        public virtual async void  Initialize()
        {
            if(_sensor == null)
            {
                var dialog = new Windows.UI.Popups.MessageDialog("The requested sensor was not found.", "Band Error");
                IsSupported = false;
                await dialog.ShowAsync();
                return;


                //Supported Types
               
            }



            IsSupported = _sensor.IsSupported;
            ReportingIntervals = _sensor.SupportedReportingIntervals;

            await _sensor.StartReadingsAsync();

        }


        public async void Cleanup()
        {
            if (_sensor != null)
            {
                try
                {
                    await _sensor.StopReadingsAsync();
                }
                catch (Exception e) { }
            }
        }

        #region Reporting Intervals

        private IEnumerable<TimeSpan> _reportingIntervals;
        public IEnumerable<TimeSpan> ReportingIntervals
        {
            get => _reportingIntervals;
            set => Set(ref _reportingIntervals, value);
        }

        private TimeSpan _reportingInterval;
        public TimeSpan ReportingInterval
        {
            get => _reportingInterval;
            set
            {
                Set(ref _reportingInterval, value);
                SetReportingInterval(value);
            }
        }

        private void SetReportingInterval(TimeSpan interval)
        {
            try
            {
                _sensor.ReportingInterval = interval;
            }
            catch (Exception e)
            {
                //ignore invalid reporting requests
            }
        }
        #endregion





        private bool _isSupported;

        public bool IsSupported
        {
            get => _isSupported;
            set => Set(ref _isSupported, value);
        }


        

    }
}
