using System;
using System.Collections.Generic;

namespace Garage
{
    public class BatteryStation : IStation<IElectricVehicle>
    {
        public int Capacity { get; set; }
        public void Refuel(List<IElectricVehicle> vehicles)
        {
            foreach (IElectricVehicle vehicle in vehicles)
            {
                Console.WriteLine($"The {vehicle} has been refueled with 200 gallons of gas.");
            }
        }
    }
}