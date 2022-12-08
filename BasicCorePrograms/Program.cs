using BasicCorePrograms;

namespace BasicCoreProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1.leapyear\n2.FlipCoin\n3.LargestOfThreeNumber");
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

                    default:
                        Console.WriteLine("enter the valid choice");
                        break;
                }
            }
        }
    }
}


