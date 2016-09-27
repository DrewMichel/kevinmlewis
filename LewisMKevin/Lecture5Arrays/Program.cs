using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture5Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            const int COIN_FLIPS = 8;

            Random generator = new Random();

            int numberOfHeads = 0;
            int numberOfTails = 0;
            int numberOfFlips = 0;

            int[] array = new int[COIN_FLIPS];

            for (int x = 0; x < COIN_FLIPS; x++)
            {
                array[x] = generator.Next(2);

                if(array[x] == 0)
                {
                    numberOfHeads++;
                }
                else 
                {
                    numberOfTails++;
                }
                numberOfFlips++;
            }

            Console.WriteLine("Coin Flip History");

            foreach(int element in array)
            {
                if(element == 0)
                {
                    Console.WriteLine("Heads");
                }
                else
                {
                    Console.WriteLine("Tails");
                }
            }

            Console.WriteLine("Total Flips: {0}", numberOfFlips);
            Console.WriteLine("Heads: {0}, Percentage: {1:P2}", numberOfHeads, numberOfHeads / (double)COIN_FLIPS);
            Console.WriteLine("Tails: {0}, Percentage: {1:P2}", numberOfTails, numberOfTails / (double)COIN_FLIPS);

            Console.ReadKey();
        }
    }
}
