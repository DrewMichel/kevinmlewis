using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture6Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Fraction fraction =
                new Fraction();

            fraction.setNumerator(10);
            fraction.setDenominator(30);

            Console.WriteLine(
                fraction.reduced());

            Console.ReadKey();
        }
    }
}
