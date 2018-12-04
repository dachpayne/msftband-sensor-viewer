using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
using Microsoft.Band;
using System.Reflection;
using Windows.Gaming.Input;
using Microsoft.Band.Sensors;

namespace Band.Samples.Services
{
    static class BandService
    {
        private static IBandClient _bandClient = null;
        public static IBandClient BandClient => _bandClient;

        public async static void GetPairedBandsAsync()
        {
           
        }



        public static IBandSensor<IBandSensorReading> GetSensor<T>() where T : IBandSensorReading
        {

           

            Type myType = BandClient.SensorManager.GetType();
            var props = myType.GetProperties();


            foreach (var p in props)
            {
                var type = p.PropertyType;
                var subtype = type.GetType();

                Debug.WriteLine("Type  : " + subtype);
            }
            //foreach (PropertyInfo prop in props)
            //{
            //    object type = prop.GetType();

            //    // Do something with propValue
            //    Debug.WriteLine("Found Target Sensor: " + nameof(T));
            //}





            return null;
        }



        public static async Task ConnectBandAsync(IBandInfo band)
        {
            if (band == null) throw new ArgumentException("Argument cannot be null", nameof(band));

            try
            {
                _bandClient = await BandClientManager.Instance.ConnectAsync(band);
            }
            catch (Exception e)
            {
                var param = new
                {
                    Message = "Failed to ",
                    Title = "Couldn't connect to Band",
                    Exception = ""
                };
            }
            

        }

    }
}
