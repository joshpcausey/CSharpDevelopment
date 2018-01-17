using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorizor
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = GetNumberFromUser();

            Calculator.PrintFactors(number);
            Calculator.IsPerfectNumber(number);
            Calculator.IsPrimeNumber(number);

            Console.WriteLine("Press any key to quit...");
            Console.ReadKey();
        }

        /// <summary>
        /// Prompt the user for an integer.  Make sure they enter a valid integer!
        /// 
        /// See the String Input lesson for TryParse() examples
        /// </summary>
        /// <returns>the user input as an integer</returns>
        static int GetNumberFromUser()
        {
            Console.WriteLine("Enter an integer: ");
            string userInputString = Console.ReadLine();
            int result;
            bool tryedParse = int.TryParse(userInputString, out result);
            if (tryedParse)
            {
                return result;
            }
            else
            {
                return GetNumberFromUser();
            }
        }
    }

    class Calculator
    {
        /// <summary>
        /// Given a number, print the factors per the specification
        /// </summary>
        public static void PrintFactors(int number)
        {
            for(int i = 1; i <= number; i++)
            {
                if(number%i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        /// <summary>
        /// Given a number, print if it is perfect or not
        /// </summary>
        public static void IsPerfectNumber(int number)
        {
            int totalFactorials = 0;
            for(int i = 1; i < number; i++)
            {
                if(number%i == 0)
                {
                    totalFactorials += i;
                }
            }
            if(totalFactorials == number)
            {
                Console.WriteLine("Is perfect");
            }
            else
            {
                Console.WriteLine("It is not perfect");
            }
        }

        /// <summary>
        /// Given a number, print if it is prime or not
        /// </summary>
        public static void IsPrimeNumber(int number)
        {
            int numberOfFactorials = 0;
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    numberOfFactorials += 1;
                }
            }
            if (numberOfFactorials == 0)
            {
                Console.WriteLine("Is Prime");
            }
            else
            {
                Console.WriteLine("Is not prime");
            }
        }
    }
}
