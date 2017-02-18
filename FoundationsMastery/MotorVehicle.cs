using System;

namespace FoundationsMastery
{
    public class MotorVehicle
    {
        private string fuelType { get; set; }
        private int fuelTankCapacity { get; set; }

        public MotorVehicle()
        {
            fuelType = "gasoline";
            fuelTankCapacity = 20;
        }

        public string GetFuelType()
        {
            return fuelType;
        }

        public void SetFuelType(string type)
        {
            if (type.ToLower() == "gasoline" || type.ToLower() == "diesel")
            {
                fuelType = type;
            }
            else
            {
                throw new ArgumentException("This fuel type argument is invalid.");
            }
        }

        public int GetFuelTankCapacity()
        {
            return fuelTankCapacity;
        }

        public void SetFuelTankCapacity(int capacity)
        {
            fuelTankCapacity = capacity;
        }
    }
}
