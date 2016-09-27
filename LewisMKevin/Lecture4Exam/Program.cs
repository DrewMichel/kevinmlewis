using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture4Exam
{
    class Program
    {
        const int A_GRADE = 90;
        const int B_GRADE = 80;
        const int C_GRADE = 70;
        const int D_GRADE = 60;

        static void Main(string[] args)
        {
            int numberOfA = 0;
            int numberOfB = 0;
            int numberOfC = 0;
            int numberOfD = 0;
            int numberOfF = 0;
            int totalGrades = 0;

            Console.WriteLine("Please enter a number between 0 - 100.  Enter negative to quit:");
            string input = Console.ReadLine();
            int grade = Int32.Parse(input);

            while(grade >= 0)
            {
                if(grade >= A_GRADE)
                {
                    numberOfA++;
                }
                else if(grade >= B_GRADE)
                {
                    numberOfB++;
                }
                else if (grade >= C_GRADE)
                {
                    numberOfC++;
                }
                else if(grade >= D_GRADE)
                {
                    numberOfD++;
                }
                else
                {
                    numberOfF++;
                }
                totalGrades++;

                Console.WriteLine("Please enter a number between 0 - 100.  Enter negative to quit:");
                input = Console.ReadLine();
                grade = Int32.Parse(input);
            }

            if(totalGrades == 0)
            {
                Console.WriteLine("No grades inputted.");
            }
            else //totalGrades >= 1
            {
                double percentA = numberOfA / Convert.ToDouble(totalGrades);
                double percentB = numberOfB / (double)totalGrades;
                double percentC = numberOfC / (double)totalGrades;
                double percentD = numberOfD / (double)totalGrades;
                double percentF = numberOfF / (double)totalGrades;

                percentA *= 100;
                percentB *= 100;
                percentC *= 100;
                percentD *= 100;
                percentF *= 100;

                Console.WriteLine("The total number of grades enter is {0}", totalGrades);
                Console.WriteLine("Number of A's: {0} which is {1}%", numberOfA, percentA);
                Console.WriteLine("Number of B's: {0} which is {1}%", numberOfB, percentB);
                Console.WriteLine("Number of C's: {0} which is {1}%", numberOfC, percentC);
                Console.WriteLine("Number of D's: {0} which is {1}%", numberOfD, percentD);
                Console.WriteLine("Number of F's: {0} which is {1}%", numberOfF, percentF);

            }
            Console.ReadKey();


        }
    }
}
