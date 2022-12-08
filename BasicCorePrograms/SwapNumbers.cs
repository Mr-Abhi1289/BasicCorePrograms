using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    internal class SwapNumbers
    {
        int num1, num2, temp;
        public void swap()
        {
            Console.WriteLine("enter the first nuumber");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the second nuumber");
            num2 = Convert.ToInt32(Console.ReadLine());

            temp = num1;
            num1 = num2;
            num2 = temp;

            Console.WriteLine("Numbers after Swapping ");
            Console.WriteLine(num1);
            Console.WriteLine(num2);




        }
    }
}
