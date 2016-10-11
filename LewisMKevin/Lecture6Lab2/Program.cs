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
                new Fraction(10, 30);

            Console.WriteLine(fraction.value());

            Fraction fraction2 = new Fraction();
            fraction2.setNumerator(-3);
            fraction2.setDenominator(-9);

            Console.WriteLine(fraction.Equals(fraction2));

            Console.WriteLine("Fraction: {0}",fraction);
            Console.WriteLine("Reduced: {0}",
                fraction.reduced());

            Console.ReadKey();
        }
    }
}
