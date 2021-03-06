using Plugin.BLE;
using Plugin.BLE.Abstractions.Contracts;
using System.Collections.ObjectModel;
using System.Diagnostics;

/// <summary>
/// Summary description for Class1
/// </summary>
/// 
namespace ProsApp.Bluetooth
{

    public class Vanilla
	{
		Plugin.BLE.Abstractions.Contracts.IBluetoothLE BLE;
		Plugin.BLE.Abstractions.Contracts.IAdapter Adapter;
		ObservableCollection<IDevice> diveList; 
		public void Setup() //can become contructor 
		{
			var ble =     CrossBluetoothLE.Current;
			var adapter = CrossBluetoothLE.Current.Adapter;

			BLE = ble; 
			Adapter = adapter;
		}
		
		public void Bluetooth()
        {
			var state = BLE.State;

			BLE.StateChanged += (s, e) =>
			{
				Debug.WriteLine($"The bluetooth state changed to {e.NewState}"); 
			}; 
        }

		/*public void ScanAdapt()
        {
			Adapter.DeviceDiscovered += (s, a) => deviceList.Add(a.Device);
			await Adapter.StartScanningForDevicesAsync();
		}*/

	}
}
