using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            // User Input

            Console.Write("Enter a positive integer: ");
            string userInt = Console.ReadLine();

            int numStars;
            bool validUserInput = false;

            // User Input Validation

            if (int.TryParse(userInt, out numStars))
            {
                if (numStars > 0)
                {
                    validUserInput = true;
                }
                else
                {
                    Console.WriteLine("Please enter a positive integer.");
                    Console.ReadKey();
                }
            }

            ShowSquareofStars(numStars, validUserInput);
            Console.ReadKey();
        }

        private static void ShowSquareofStars(int numStars, bool validUserInput)
        {
            if (validUserInput)
            {
                string star = " ";
                for (int row = 0; row < numStars; row++)
                {
                    star = star + "* ";
                }
                for (int col = 0; col < numStars; col++)
                {
                    Console.WriteLine(star);
                }
            }
        }
    }
}
