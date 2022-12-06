namespace Garage
{
    public class Cessna : Vehicle, IGasVehicle // Propellor light aircraft
    {
        public double FuelCapacity { get; set; }
        public double CurrentTankPercentage { get; set; }
        public void RefuelTank()
        {
            CurrentTankPercentage = 100;
        }
    }
}