using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InheritanceSample
{
    class Truck : Vehicle
    {
        public Truck(string make, string model, string vin)
            : base(make, model, vin)
        {
        }

        public Truck(string vin)
            : base(vin)
        {
        }

        public override string ToString()
        {
            return "Truck: make = " + this.Make + ", model = " + this.Model + ", owner = " + this.Owner + ", vin = " + this.Vin;
        }

        public override void Start()
        {
            Console.WriteLine("Rumble rumble rumble: " + this);
        }
    }
}
