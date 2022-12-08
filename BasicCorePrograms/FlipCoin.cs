using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class Flipcoin

    {
        double HeadCount = 0, TailCount = 0, PercentageOfHead = 0, PercentageOfTail = 0;
        public void CheckHeadAndTail()
        {
            Console.WriteLine("enter the number of times to flip coin");
            double NumOfCount = Convert.ToDouble(Console.ReadLine());
            for (int i = 0; i < NumOfCount; i++)
            {
                Random randobj = new Random();
                double randomnumber = randobj.NextDouble();
                if (randomnumber < 0.5)
                {
                    TailCount++;
                    Console.WriteLine("tail");
                }
                else
                {
                    HeadCount++;
                    Console.WriteLine("head");

                }
            }
            Console.WriteLine("total head count=" + HeadCount);
            Console.WriteLine("total tail count=" + TailCount);
            PercentageOfHead = HeadCount / NumOfCount * 100;
            PercentageOfTail = TailCount / NumOfCount * 100;

            Console.WriteLine("percentage of head=" + PercentageOfHead);
            Console.WriteLine("percentage of tail=" + PercentageOfTail);



        }
    }
}
