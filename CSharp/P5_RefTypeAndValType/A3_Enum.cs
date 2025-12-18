using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P5_RefTypeAndValType
{
    internal class A3_Enum
    {
        enum Days
        {
            MON,    // 0
            TUES,   // 1
            WED,    // 2
            THU,    // 3
            FRI,    // 4
            SAT,    // 5
            SUN     // 6
        }

        enum Months
        {
            JAN = 1,
            FEB,
            MAR,
            APR,
            MAY
        }
        static void Main1(string[] args)
        {
            Days d = Days.MON;
            Console.WriteLine(d);//name MON
            Console.WriteLine((int)d);//value 0
            
            Months m = Months.JAN;
            Console.WriteLine(m);
            Console.WriteLine((int)m);
        }
    }
}
