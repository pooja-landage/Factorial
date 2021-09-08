using System;

namespace Pratice22Factorial
{
    class Program
    {
        private static int fact;

        static void Main(string[] args)
        {
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("\t          ========================================Factorial=======================================");
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Enter a postive number!!");
            int n = Convert.ToInt32(Console.ReadLine());
            long fact = GetFactorial(n);
            Console.WriteLine("{0} factorial is {1}", n, fact);

        }
        private static long GetFactorial(int number)

        {

            if (number == 0)
            {
                return 1;
            }

            return number * GetFactorial(number - 1);

        }
    }
}
