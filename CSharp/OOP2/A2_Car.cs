using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    internal class A2_Car:A2_Vehicle
    {
        public string Brand {  get; set; }

        public A2_Car(String VehicleType,string Brand):base(VehicleType) {
            this.Brand = Brand;
            Console.WriteLine("Car constructor called...");
        }

        public void DisplayCar()
        {
            Console.WriteLine($"Car Brand = {Brand}");
        }
    }
}
