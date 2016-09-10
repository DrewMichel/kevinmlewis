/// @author: Kevin Lewis <kevin@kevinmlewis.com>
/// Demonstration of Methods and String methods


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture3Demo1
{
    class Program
    {
        static void Main(string[] args)
        {
            string nflTeam = "San Diego Chargers";

            //Static cases
            Console.WriteLine("Equals with the Broncos = {0}", nflTeam.Equals("Denver Broncos"));
            Console.WriteLine("Equals with the Chargers = {0}", nflTeam.Equals("San Diego Chargers"));

            //dynamic based on running the code.
            Console.WriteLine("Enter the team that you would like to compare:");
            string inputTeam = Console.ReadLine();
            Console.WriteLine("Does the set string {0} equal the input string {1} = {2}",
                nflTeam, inputTeam, nflTeam.Equals(inputTeam));

            //Use the [] indexer method get the first and last characters.
            char firstLetter = nflTeam[0];
            char lastLetter = nflTeam[nflTeam.Length - 1];

            Console.WriteLine("First letter ({0}), last letter ({1})", firstLetter, lastLetter);

            //Substring method both 
            Console.WriteLine("The {0} are from {1}.", nflTeam.Substring(10), nflTeam.Substring(0,9));

            //use the index of method
            Console.WriteLine("The index of the first space {0}.", nflTeam.IndexOf(" "));
            Console.WriteLine("The index of Diego is {0}.", nflTeam.IndexOf("Diego"));

            //new strings are created the original remains intact.
            Console.WriteLine("UpperCase({0}), Original({1}).", nflTeam.ToUpper(), nflTeam);
            string lowerNflTeam = nflTeam.ToLower();
            Console.WriteLine("LowerCase({0}), Original({1}).", lowerNflTeam, nflTeam);


            Console.ReadKey();
        }
    }
}
