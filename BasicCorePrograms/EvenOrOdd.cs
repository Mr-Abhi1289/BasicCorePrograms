using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    internal class EvenOrOdd
    {
        public void FindLargestNum()
        {
            int i;
            Console.Write("Enter a Number : ");
            i = Convert.ToInt32(Console.ReadLine());
            if (i % 2 == 0)
            {
                Console.WriteLine(" Number is an Even Number");

            }
            else
            {
                Console.WriteLine(" Number is an Odd Number");

            }



        }
    }
}
