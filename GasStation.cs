using System;
using System.Collections.Generic;

namespace Garage
{
    public class GasStation : IStation<IGasVehicle>
    {
        public int Capacity { get; set; }
        public void Refuel(List<IGasVehicle> vehicles)
        {
            foreach (IGasVehicle vehicle in vehicles)
            {
                Console.WriteLine($"The {vehicle} has been refueled with 200 gallons of gas.");
            }
        }
    }
}