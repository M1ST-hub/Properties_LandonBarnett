namespace Properties_LandonBarnett
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Car car = new Car();
            car.Make = "Ford";
            car.Model = "Mustang";

            Console.WriteLine($"Make: {car.Make}, Model: {car.Model}");

            Car car2 = new Car();
            car2.Make = "Chevy";
            car2.Model = "Camero";

            Console.WriteLine($"Make: {car2.Make}, {car2.Model}");

        }
    }
}