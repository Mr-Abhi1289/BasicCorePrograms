using BasicCoreProblems;
using BasicCorePrograms;
using CorePrograms;

namespace BasicCoreProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1.leapyear\n2.FlipCoin\n3.LargestOfThreeNumber\n4.EvenOrOdd\n5.QuotientAndRemainder\n6.SwapNumber\n7.VowelsOrConsonant\n8.power2\n9.factors\n10.HarmonicNumbers");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        LeapYear year = new LeapYear();
                        year.findleap();
                        break;

                    case 2:
                        Flipcoin flip = new Flipcoin();
                        flip.CheckHeadAndTail();
                        break;

                    case 3:
                        LargestOfThreeNumbers LargeNUmbers = new LargestOfThreeNumbers();
                        LargeNUmbers.FindLargestNum();
                        break;

                    case 4:
                        EvenOrOdd num = new EvenOrOdd();
                        num.FindLargestNum();
                        break;

                    case 5:
                        QuotientAndRemainder res = new QuotientAndRemainder();
                        res.Remainder();
                        break;
                    case 6:
                        SwapNumbers swap = new SwapNumbers();
                        swap.swap();
                        break;
                    case 7:
                        VowelOrConsenant vowel = new VowelOrConsenant();
                        vowel.vowel();
                        break;
                    case 8:
                        powerof2 pow = new powerof2();
                        pow.power();
                        break;
                    case 9:
                        Factors fact = new Factors();
                        fact.findFactors();
                            break;
                    case 10:
                        HarmonicNumber harmo = new HarmonicNumber();
                        harmo.Harmonic();
                        break;
                        
                    default:
                        Console.WriteLine("enter the valid choice");
                        break;
                }
            }
        }
    }
}


