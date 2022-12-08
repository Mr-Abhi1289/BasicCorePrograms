namespace BasicCoreProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1.leapyear");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        LeapYear year = new LeapYear();
                        year.findleap();
                        break;

                    default:
                        Console.WriteLine("enter the valid choice");
                        break;
                }
            }
        }
    }
}


