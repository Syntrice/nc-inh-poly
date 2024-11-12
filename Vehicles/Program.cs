namespace Vehicles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car redCar = new Car("Fast 500", "Carmaker Company");
            Car siestaFord = new Car("Siesta", "Ford");
            Motorcycle bicycle = new Motorcycle("Trike", "Bike Co. Ltd", true);


            redCar.StartEngine();
            redCar.Drive();

            siestaFord.StartEngine();
            siestaFord.Drive();

            bicycle.StartEngine();
            bicycle.Drive();    

        }
    }
}
