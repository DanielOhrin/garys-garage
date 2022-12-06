using System;
using System.Collections.Generic;

namespace Garage
{
    public class Station<T>
    {
        public void Refuel(List<T> vehicles)
        {
            foreach (T vehicle in vehicles)
            {
                Console.WriteLine($"The {vehicle} has been refueled with 200 gallons of gas.");
            }
        }
    }
}