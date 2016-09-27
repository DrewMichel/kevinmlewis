using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture5FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("{0} {1} {2}", args[2], args[1], args[0]);

            for(int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.Write("FizzBuzz ");
                }
                else if (i % 3 == 0)
                {
                    Console.Write("Fizz ");
                }
                else if (i % 5 == 0)
                {
                    Console.Write("Buzz ");
                }
                else
                {
                    Console.Write(i + " ");
                }
            }
            Console.ReadKey(); 
        }
    }
}
