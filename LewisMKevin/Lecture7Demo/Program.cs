using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture7Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Pizza simplePizza = new Pizza();

            Console.WriteLine("Simple Pizza: {0}", simplePizza);

            Pizza megaMeatPizza = new Pizza(Size.Large, 1, 10, 20);

            Console.WriteLine("Mega Meat Pizza: {0}", megaMeatPizza);

            Pizza phonePizza = PhoneOrder();

            Console.WriteLine("Phone Pizza: {0}", phonePizza);

            Console.ReadKey();
        }

        public static Pizza PhoneOrder()
        {
            Size inputSize = Size.Large;
            Console.WriteLine("How large would you like your pizza:");
            string input = Console.ReadLine();
            if(input.ToLower() == "small")
            {
                inputSize = Size.Small;
            }
            if (input.ToLower() == "medium")
            {
                inputSize = Size.Medium;
            }

            int cheese = GetTopping("cheese");
            int ham = GetTopping("ham");
            int pepperoni = GetTopping("pepperoni");

            return new Pizza(inputSize, cheese, pepperoni, ham);
        }

        public static int GetTopping(string toppingName)
        {
            Console.WriteLine("How many {0} toppings would you like:", toppingName);
            return Int32.Parse(Console.ReadLine());

        }
    }
}
