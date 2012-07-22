using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InheritanceSample
{
    class Car : Vehicle
    {
        public Car(string make, string model, string vin)
            : base(make, model, vin)
        {
        }

        public Car(string vin)
            : base(vin)
        {
        }

        public override string ToString()
        {
            return "Car: make = " + this.Make + ", model = " + this.Model + ", owner = " + this.Owner + ", vin = " + this.Vin;
        }

        public override void Start()
        {
            Console.WriteLine("Put put put: " + this);
        }

    }
}
