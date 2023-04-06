using System;
using System.Collections.Generic;



namespace ArrayTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine( FizzBuzz(15));
            Console.WriteLine(FizzBuzz(9));
            Console.WriteLine(FizzBuzz(5));
            Console.WriteLine(FizzBuzz(17));
        }

        public string FizzBuzz(int x)
        {
            if (x % 3 == 0 && x % 5 == 0)
            {
                return "fizzbuzz";
            }
            else if (x % 3 == 0)
            {
                return "fizz";
            }
            else if (x % 5 == 0)
            {
                return "buzz";
            }
            else
            {
                return "Not divisible by 3 or 5";
            }
            
        }
    }
}
