using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture10PassByReference
{
    class Program
    {
        static void Main(string[] args)
        {
            int value = 10;

            Console.WriteLine("Starting value = {0}", value);

            PassByValue(value);
            Console.WriteLine("After pass by value = {0}", value);

            PassByReference(ref value);
            Console.WriteLine("After pass by reference = {0}", value);

            Console.ReadKey();
        }

        static void PassByValue(int value)
        {
            value = 15;
        }

        static void PassByReference(ref int value)
        {
            value = 20;
        }
    }
}
