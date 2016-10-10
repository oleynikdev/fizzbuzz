using System;

namespace FizzBuzzWithUnitTests
{
   public class Program
    {
        static void Main(string[] args)
        {

            Print();
        }

        public static void Print()
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(GetResult(i));
            }
        }

        public static string GetResult(int i)
        {
            string result = null;
            
            if (i % 3 == 0)
                result = "Fizz";

            if (i % 5 == 0)
                result += "Buzz";
            
            return result ?? i.ToString();
        }
    }
}
