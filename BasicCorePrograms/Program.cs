using BasicCorePrograms;

namespace BasicCoreProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1.leapyear\n2.FlipCoin\n3.LargestOfThreeNumber\n4.EvenOrOdd\n5.QuotientAndRemainder\n6.SwapNumber");
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
                    

                    default:
                        Console.WriteLine("enter the valid choice");
                        break;
                }
            }
        }
    }
}


