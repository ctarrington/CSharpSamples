using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InheritanceSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("Dodge", "Dart", "abc123445");
            car.Owner = "Rex";
            car.Owner = "Joe";
            System.Console.WriteLine("car = " + car);
            System.Console.WriteLine("car.Vin = " + car.Vin);

            Car honda = new Car("xqwerty") { Make = "Honda", Model = "CRX", Owner = "Joe" };
            Car prelude = new Car("g675qw2") { Make = "Honda", Model = "Prelude", Owner = "Ted" };
            Car legacy = new Car("a12w3") { Make = "Subaru", Model = "Legacy", Owner = "Fred" };
            Truck f150 = new Truck("h1234") { Make = "Ford", Model = "F150", Owner = "Vince" };

            List<Vehicle> vehicles = new List<Vehicle> { honda, prelude, legacy, f150, };
            vehicles.ForEach(vehicle => vehicle.Start());
        }
    }
}
