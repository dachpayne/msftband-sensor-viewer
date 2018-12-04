using System;
using System.Windows.Input;
using Band.Samples.Helpers;
using Microsoft.Band;

namespace Band.Samples.ViewModels
{
    public class MainViewModel : Observable
    {

        public ICommand ConnectBandCommand { get; private set; }


        public MainViewModel()
        {
            ConnectBandCommand = new RelayCommand(async () =>
            {
                IBandInfo[] pairedBands = await BandClientManager.Instance.GetBandsAsync();

                if (pairedBands == null || pairedBands.Length == 0)
                {
                    var dialog = new Windows.UI.Popups.MessageDialog("You need a paired band to use this. \n \n Pair on in Bluetooth Settings","No Paired Band");
                    dialog.ShowAsync();
                    return;
                }


                await Services.BandService.ConnectBandAsync(pairedBands[0]);
                var sensor = Services.BandService.GetSensor<Microsoft.Band.Sensors.IBandAmbientLightReading>();



            }, () => { return true;});
        }
    }
}
