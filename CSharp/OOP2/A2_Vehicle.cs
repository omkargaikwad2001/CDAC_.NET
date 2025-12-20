using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    internal class A2_Vehicle
    {
        public string VehicleType {  get; set; }

        public A2_Vehicle(string vehicleType)
        {
            this.VehicleType = vehicleType;
            Console.WriteLine("Vehicle constructor called...");
        }

        public void DisplayVehicle()
        {
            Console.WriteLine($"Vehicle Type = {VehicleType}");
        }
    }
}
