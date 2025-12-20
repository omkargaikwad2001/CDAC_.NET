using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P6_OOP2
{
    internal class A4_Car
    {
        public string Color {  get; set; }
        public string Make { get; set; }
        public A4_Engine EngineObj { get; set; }

        //for aggregation
        //public A4_Car(string Color,string Make) {
        //    this.Color = Color; 
        //    this.Make = Make;
        //}

        //for composition
        public A4_Car(string Color, string Make, A4_Engine EngineObj)
        {
            this.Color = Color;
            this.Make = Make;
            this.EngineObj = EngineObj;
        }
        public void StartCar()
        {
            EngineObj.StartEngine();
            Console.WriteLine("Engine CC = "+EngineObj.CC);
            Console.WriteLine("Car color = "+Color+" Make = "+Make);
            Console.WriteLine("Car started...");
        }
    }
}
