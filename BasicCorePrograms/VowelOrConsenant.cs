using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    internal class VowelOrConsenant
    {
        public void vowel()
        {
            {
                char ch;
                Console.Write("Please Enter an Alphabet (A-Z or a-z) : ");
                ch = Convert.ToChar(Console.ReadLine().ToLower());
                int i = ch;
                if (i >= 48 && i <= 57)
                {
                    Console.WriteLine(" Please enter an alphabet not a number");
                }
                else
                {
                    switch (ch)
                    {
                        case 'a':
                            Console.WriteLine("Entered alphabet is vowel");
                            break;
                        case 'i':
                            Console.WriteLine("Entered alphabet is vowel");
                            break;
                        case 'o':
                            Console.WriteLine("Entered alphabet is vowel");
                            break;
                        case 'u':
                            Console.WriteLine("Entered alphabet is vowel");
                            break;
                        case 'e':
                            Console.WriteLine("Entered alphabet is vowel");
                            break;
                        default:
                            Console.WriteLine("Entered alphabet is a Consonant");
                            break;
                    }
                }

            }
        }
    }
}
