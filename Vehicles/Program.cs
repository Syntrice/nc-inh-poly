namespace Vehicles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car redCar = new Car("Fast 500", "Carmaker Company");
            Car siestaFord = new Car("Siesta", "Ford");

            Motorcycle bicycle1 = new Motorcycle("Trike", "Bike Co. Ltd", true);
            Motorcycle bicycle2 = new Motorcycle("Trike", "Bike Co. Ltd", true);

            bicycle2.SwapEngine(500, FuelType.Diesel);

            bicycle1.StartEngine();
            bicycle2.StartEngine();

            bicycle1.Drive();
            bicycle2.Drive();

            //redCar.StartEngine();
            //redCar.Drive();

            //siestaFord.StartEngine();
            //siestaFord.Drive();

            //bicycle.StartEngine();
            //bicycle.Drive();    

        }
    }
}
