using BasicCorePrograms;

namespace BasicCoreProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1.leapyear\n2.FlipCoin");
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

                    default:
                        Console.WriteLine("enter the valid choice");
                        break;
                }
            }
        }
    }
}


