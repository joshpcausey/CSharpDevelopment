using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Execute();
            Console.ReadLine();
        }

        static void Execute()
        {
            //TODO:  Implement FizzBuzz
            int finalNumber = 1000000000;
            for(int i = 1; i <= finalNumber; i++)
            {
                if(i%3 == 0 && i%5 == 0)
                {
                    Console.WriteLine(i + " FizzBuzz");
                }
                else if(i%5 == 0)
                {
                    Console.WriteLine(i + " Buzz");
                }
                else if(i%3 == 0)
                {
                    Console.WriteLine(i + " Fiz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
