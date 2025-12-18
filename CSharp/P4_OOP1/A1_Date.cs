using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_OOP1
{
    internal class A1_Date
    {
        private int dd;
        private int mm;
        private int yy;

        //This is using getter and setter

        public int Dd
        {
            get { return dd; }
            set { dd = value; }
        }
        public int Mm
        {
            get { return mm; }
            set { mm = value; }
        }
        public int Yy
        {
            get { return yy; }
            set { yy = value; }
        }

        static A1_Date() {
            Console.WriteLine("This is static constructor...");
        }

        public A1_Date()
        {
            this.dd = 0;
            this.mm = 0;
            this.yy = 0;

            Console.WriteLine("This is default constructor...");
        }

        public A1_Date(int dd, int mm, int yy)
        {
            this.dd= dd;
            this.mm= mm;
            this.yy= yy;

            Console.WriteLine("This is para constructor...");
        }
        

        //another syntax
        //public int Dd { get; set; }
        //public int Mm { get; set; }
        //public int Yy { get; set; }

        public void display()
        {
            //Console.WriteLine(Dd+" "+Mm+" "+Yy);
            Console.WriteLine(dd+" "+mm+" "+yy);
        }

    }
}
