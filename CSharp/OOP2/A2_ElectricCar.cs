using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    internal class A2_ElectricCar:A2_Car
    {
        public int BatteryCapacity { get; set; }

        public A2_ElectricCar(string vehicleType,string Brand,int BatteryCapacity):base(vehicleType,Brand) {
            
            this.BatteryCapacity = BatteryCapacity;
            Console.WriteLine("ElectricVehicle constructor called...");
        }

        public void DisplayElectricCar()
        {
            Console.WriteLine($"BatteryCapacity = {BatteryCapacity}");
        }
    }
}
