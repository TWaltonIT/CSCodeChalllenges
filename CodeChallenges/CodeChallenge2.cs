using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CodeChallenges
{
    internal class CodeChallenge2
    {
        static void Main(string[] args)
        {
            int limit = 4000000;
            int sumEven = SumEvenFibonacci(limit);
            Console.WriteLine($"The sum of even Fibonacci numbers is: {sumEven}");

            Console.WriteLine();
            int index = TenDigitFibonacci();
            Console.WriteLine($"The index of the first term in the sequence to have 10 digits is: {index}");

            Console.WriteLine();
            int collatz = LongestCollatz();
            Console.WriteLine($"The starting number under 1000 that produces the longest chain is: {collatz}");


        }

        public static int SumEvenFibonacci(int limit) 
            
        {
            int fib1 = 1;
            int fib2 = 2;
            int evenSum = 0;

            while (fib1 <= limit)
            {
                if (fib2 % 2 == 0)
                {
                    evenSum += fib2;
                }

                int nextFib = fib1 + fib2;
                fib1 = fib2;
                fib2 = nextFib;

            }
            return evenSum;

        }

        public static int TenDigitFibonacci()
        {
                
            int fib1 = 1;
            int fib2 = 1;
            int index = 2;
            List<int> fibList = new List<int> { fib1, fib2 };

            while (true)
            {
                int nextFib = fib1 + fib2;
            if (nextFib.ToString().Length >= 10)
            {
                return index;
            }
                fibList.Add(nextFib);
                index++;
                fib1 = fib2;
                fib2 = nextFib;
                
            }
            
        }

        public static int LongestCollatz()
        {

            int numLongest = 0;
            int longestSeq = 0;

            for (int startingNum = 2; startingNum < 1000; startingNum++)
            {
                int num = startingNum;
                int sequenceLength = 1;

                while (num != 1)
                {
                    if (num % 2 == 0)
                    {
                        num = num / 2;
                    }
                    else
                    {
                        num = (3 * num) + 1;
                    }
                    sequenceLength++;
                }

                if (sequenceLength > longestSeq)
                {
                    longestSeq = sequenceLength;
                    numLongest = startingNum;
                }
            }
            return numLongest;
            }
            
        }
                
    }



