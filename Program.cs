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

        public static string FizzBuzz(int x)
        {
            var answer = "";
            if (x % 3 == 0)
            {
                answer = "fizz";
            }
            
            if (x % 5 == 0)
            {
                answer += "buzz";
            }

            return answer;
            
        }
    }
}
