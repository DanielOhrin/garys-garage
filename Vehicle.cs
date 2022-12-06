using System;
using System.Text;

namespace Garage
{
    public class Vehicle
    {
        public string MainColor { get; set; }
        public int MaximumOccupancy { get; set; }

        public virtual void Drive()
        {
            Console.WriteLine("Vrooom!");
        }
        public virtual void Turn(string direction)
        {
            Console.WriteLine($"The vehicle carefully turns {direction}.");
        }
        public virtual void Stop()
        {
            Console.WriteLine("The vehicle gently rolls to a stop!");
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder(MainColor);
            sb.Append($" {GetType().Name}");

            return sb.ToString();
        }
    }
}