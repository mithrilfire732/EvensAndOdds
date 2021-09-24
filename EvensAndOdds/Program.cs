using System;

namespace EvensAndOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            var RunSum = 0;
            //generate all the numbers between 1-50
            for (var num = 0; num <= 50; num++)
            {
                //if statement determining mod5 or mod7
                if (num % 7 == 0 || num % 5 == 0)
                {
                    //add them to running tally
                    RunSum = RunSum + num;
                }
            }
            // print final sum
            Console.WriteLine($"{RunSum}");



            var comma = "";
            for (var cnt = 1; cnt <= 25; cnt++)
            {
                Console.Write($"{comma} {cnt}");
                comma = ",";
            }

            for (var idx = 0; idx < 5; idx++)
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
            int[] nbrs2 = { 3023, 8760, 1112, 8232, 8107 };

            var high = 0;
            var low = 10000;
            var sum = 0;

            foreach (var n in nbrs2)
            {
                sum += n;
                if (n > high)
                {
                    high = n;
                }
                if (n < low)
                {
                    low = n;
                }
            }
            var BigSumOf4 = sum - low;
            var SmallSumOf4 = sum - high;
            Console.WriteLine($"The largest sum is {BigSumOf4} and the smallest sum is {SmallSumOf4}.");

            int[] nbrs = {

                   754, 233, 509, 792, 700, 596, 833, 658, 998, 742,

                   187, 754, 308, 914, 489, 867, 717, 586, 929, 467,

                   460, 241, 770, 324, 599, 259, 120, 800, 336, 609,

                   690, 134, 598, 249, 282, 574, 334, 956, 659, 214,

                   435, 643, 809, 874, 906, 620, 328, 369, 426, 561

                };
            var highest = 0;
            var lowest = 1000;
            foreach (var n in nbrs)
            {
                if (n > highest)
                {
                    highest = n;
                }
                if (n < lowest)
                {
                    lowest = n;
                }
            }
            Console.WriteLine($"The largest number is {highest} and the smallest number is {lowest}.");

        }
    }
}