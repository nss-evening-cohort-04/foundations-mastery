namespace FoundationsMastery
{
    public class Motorcycle : MotorVehicle
    {
        private int numberOfWheels { get; set; }
        public Motorcycle()
        {
            numberOfWheels = 2;
        }

        public int GetNumberOfWheels()
        {
            return numberOfWheels;
        }

        public void SetNumberOfWheels(int numWheels)
        {
            numberOfWheels = numWheels;
        }

        public override string PrintFacts()
        {
            string motorcycleFacts = "A motorcycle (also called a motorbike, bike, or cycle) is a two or three-wheeled motor vehicle.";
            return motorcycleFacts;
        }
    }
}
