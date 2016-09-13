using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture3Lamp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is the lamp fixer.");
            Console.WriteLine("Is the lamp plugged in?");
            string input = Console.ReadLine();

            if(input == "No")
            {
                Console.WriteLine("Plug in lamp");
            }
            else //input == "Yes"
            {
                Console.WriteLine("Is the bulb burned out?");
                input = Console.ReadLine();

                if(input == "No")
                {
                    Console.WriteLine("Repair lamp");
                }
                else // input == Yes
                {
                    Console.WriteLine("Replace bulb");
                }
            }
            Console.ReadKey();
        }
    }
}
