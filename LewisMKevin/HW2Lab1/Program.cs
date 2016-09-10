using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            // print a message to the screen
            Console.WriteLine("Hello out there.");
            Console.WriteLine("I will add two numbers for you.");
            Console.WriteLine("Enter one number and press enter, then enter second number and press enter:");

            // declare two integer variables
            int n1, n2;
            double sum;
            double mult;

            string userInput;
            userInput = Console.ReadLine();
            n1 = Int32.Parse(userInput);
            n2 = Int32.Parse(Console.ReadLine());

            // calculate the sum of these two numbers
            sum = n1 + n2;
            mult = n1 * n2;

            // print a message along with the sum of the two numbers

            Console.WriteLine("The sum of those two numbers is");
            Console.WriteLine(sum);
            Console.WriteLine("The product of those two numbers is");
            Console.WriteLine(Multiply(n1, n2));


            Console.WriteLine("The division is {0}, sum {1}, mult {2}, div{0}.", sum / mult, sum, mult);

            //Just to pause the screen.
            Console.ReadLine();
        }

        static double Multiply(double x, double y)
        {
            return x * y;
        }
    }
}
