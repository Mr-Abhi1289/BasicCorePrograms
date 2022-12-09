using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProblems
{
    internal class HarmonicNumber
    {
        public void Harmonic()
        {
            
            Console.WriteLine("Enter Harmonic Number");
            int HarmonicNum = Convert.ToInt32(Console.ReadLine());
            double result = 1.0;
           


            for (int i = 2; i <= HarmonicNum; i++)
            {
                Console.WriteLine($"1/{i}");
                result = result+1 / (double)i;

            }
            Console.WriteLine("nth Harmonic value = " + result);
        }
    }
}