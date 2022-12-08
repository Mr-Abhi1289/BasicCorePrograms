using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    internal class LeapYear
    {
        public void findleap()

        {
            Console.WriteLine("enter the year");
            int year = Convert.ToInt32(Console.ReadLine());

            if (year % 4 == 0)
            {
                Console.WriteLine(year + " is a leap year");
            }
            else
            {
                Console.WriteLine(year + " is not a leapYear");
            }

        }
    }
}
