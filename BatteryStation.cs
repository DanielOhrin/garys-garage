namespace Garage
{
    public class BatteryStation : Station<IElectricVehicle>, IStation<IElectricVehicle>
    {
        public int Capacity { get; set; }
    }
}