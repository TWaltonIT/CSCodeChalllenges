﻿namespace Multiple3sand5s
{
    internal class Challenge1_Multiple3sAnd5s
    {
        static void Main(string[] args)
        {
            int sum = 0;

            for (int i = 1; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum += 1;
                }
            }

            Console.WriteLine($"The sum of all multiples of 3 or 5 below 1000 is: {sum}");
        }
    }
}
