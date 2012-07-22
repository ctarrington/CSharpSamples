using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InheritanceSample
{
    abstract class Vehicle
    {
        private string theOwner;
        private string theVin;

        public string Make { get; set; }
        public string Model { get; set; }

        public string Owner
        {
            get
            {
                return theOwner;
            }
            set
            {
                theOwner = value.ToUpper();
            }
        }

        public string Vin
        {
            get { return theVin; }
            private set { theVin = value.ToUpper(); }
        }

        public Vehicle(string make, string model, string vin)
        {
            this.Make = make;
            this.Model = model;
            this.Owner = "Fred";
            this.Vin = vin;
        }

        public Vehicle(string vin)
        {
            this.Vin = vin;
        }

        public override string ToString()
        {
            return "Vehicle: make = " + this.Make + ", model = " + this.Model + ", owner = " + this.Owner + ", vin = " + this.Vin;
        }

        public abstract void Start();
    }
}
