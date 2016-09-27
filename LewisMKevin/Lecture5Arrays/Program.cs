using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture5Arrays
{
    class Program
    {
        public enum Flips { Heads, Tails};

        static void Main(string[] args)
        {
            const int COIN_FLIPS = 10000;

            Random generator = new Random();

            int numberOfHeads = 0;
            int numberOfTails = 0;
            int numberOfFlips = 0;

            int[] array = new int[COIN_FLIPS];

            #region business logic
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
            #endregion

            PrintOutput(array, numberOfHeads, numberOfTails);

            Console.ReadKey();
        }

        static Flips CoinFlip(Random generator)
        {
            if (generator.Next(2) == 0)
            {
                return Flips.Heads;
            }
            else
            {
                return Flips.Tails;
            }
        }

        static void PrintOutput(int[] flips, int heads, int tails)
        {

            Console.WriteLine("Coin Flip History");

            foreach (int element in flips)
            {
                if (element == 0)
                {
                    Console.WriteLine("Heads");
                }
                else
                {
                    Console.WriteLine("Tails");
                }
            }

            Console.WriteLine("Total Flips: {0}", flips.Length);
            Console.WriteLine("Heads: {0}, Percentage: {1:P2}", heads, heads / (double)flips.Length);
            Console.WriteLine("Tails: {0}, Percentage: {1:P2}", tails, tails / (double)flips.Length);
        }
    }
}
