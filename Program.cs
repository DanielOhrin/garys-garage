using System;
using System.Collections.Generic;

namespace Garage
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero fxs = new Zero
            {
                MainColor = "blue"
            };
            Zero fx = new Zero
            {
                MainColor = "white"
            };
            Tesla modelS = new Tesla
            {
                MainColor = "titanium white"
            };

            List<IElectricVehicle> electricVehicles = new List<IElectricVehicle>() {
                fx, fxs, modelS
            };


            Ram ram = new Ram
            {
                MainColor = "black"
            };
            Cessna cessna150 = new Cessna
            {
                MainColor = "red"
            };

            List<IGasVehicle> gasVehicles = new List<IGasVehicle>() {
                ram, cessna150
            };

            /*******************STATIONS******************/

            GasStation jerrys = new GasStation();
            BatteryStation chargetopia = new BatteryStation();

            jerrys.Refuel(gasVehicles);
            chargetopia.Refuel(electricVehicles);
        }
    }
}