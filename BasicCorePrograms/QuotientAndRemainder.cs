using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    internal class QuotientAndRemainder
    {
        int num1, num2, remainder, Quotient;

        public void Remainder()
        {
            Console.WriteLine("enter the two number");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
            remainder = num1 % num2;
            Console.WriteLine("the remainder is =" + remainder);
            Quotient = num1 / num2;
            Console.WriteLine("the quotient is =" + Quotient);


        }
    }
}
