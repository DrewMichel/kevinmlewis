using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture3Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Toll Calculator");

            Console.WriteLine("Please select vehicle:");
            Console.WriteLine("1 - car");
            Console.WriteLine("2 - bus");
            Console.WriteLine("3 - truck");
            Console.WriteLine("4 - unknown");

            string input = Console.ReadLine();
            double toll = 0;

            switch(input)
            {
                case "1":
                    toll = 1.5;
                    break;
                case "2":
                    toll = 2.5;
                    break;
                case "3":
                    toll = 4.5;
                    break;
                default:
                    toll = 5;
                    break;
            }

            Console.WriteLine("Your toll is {0:c}",toll);
            Console.ReadKey();
        }
    }
}
