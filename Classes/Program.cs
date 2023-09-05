namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Carmake = "Toyota";
            car.CarModel = "Camry";
            car.CarYear = 1995;

            Console.WriteLine($"Car make: {car.Carmake}");
            Console.WriteLine($"Car model: {car.CarModel}");
            Console.WriteLine($"Car year: {car.CarYear}");
        }
    }
}
