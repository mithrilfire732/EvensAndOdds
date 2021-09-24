using System;

namespace EvensAndOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an integer: ");
            var answer = Console.ReadLine();
            var number = Convert.ToInt32(answer);
            if (number % 2 == 0)
            {
                Console.WriteLine($"The number {number} is even");
            }
            else if (number % 2 != 0)
            {
                Console.WriteLine($"The number {number} is odd");
            }
        }
    }
}