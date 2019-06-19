using System;
using _01._Car;

namespace _03._Car_Constructors
{
    class CarConstructors
    {
        static void Main(string[] args)
        {
            var make = Console.ReadLine();
            var model = Console.ReadLine();
            var year = int.Parse(Console.ReadLine());
            var fuelQuantity = double.Parse(Console.ReadLine());
            var fuelConsumption = double.Parse(Console.ReadLine());

            var firstCar = new Car();
            var secondCar = new Car(make,model,year);
            var thirdCar = new Car(make,model,year,fuelQuantity,fuelConsumption);

        }
    }
}
