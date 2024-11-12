using Shapes;


namespace Vehicles
{
    internal abstract class Vehicle
    {

        public Engine EngineType { get; protected set; }

        public string MakeName { get; }
        public string Model {  get; }

        public int Speed { get; }

        public List<Shape> ComponentShapes { get; set; }

        public Vehicle(string model, string makeName, Engine engineType)
        {
            Model = model;
            MakeName = makeName;
            EngineType = engineType;
        }

        public void StartEngine()
        {
            EngineType.Start();
        }

        public abstract void SwapEngine(int horsepower, FuelType fuelType);

        public void Drive()
        {
            if (EngineType.Running)
            {
                Accelerate();
            }
            else
            {
                Console.WriteLine($"{MakeName} {Model} is not running.");
            }
        }

        public abstract void Accelerate(); 


    }
}
