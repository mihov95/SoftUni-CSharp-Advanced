using System;
using _01._Car;

namespace _02._Car_Extension
{
    class CarExtension
    {
        static void Main(string[] args)
        {
            var myCar = new Car();

            myCar.Make = "VW";
            myCar.Model = "MK3";
            myCar.Year = 1992;
            myCar.FuelQuantity = 200;
            myCar.FuelConsumption = 200;
            myCar.Drive(2000);
            Console.WriteLine(myCar.WhoAmI());
        }
    }
}
