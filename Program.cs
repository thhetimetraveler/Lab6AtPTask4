using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6AtPTask4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a natural number to check if it is prime: ");
            int number = int.Parse(Console.ReadLine());

            if (number <= 1)
            {
                Console.WriteLine("The number is not prime.");
            }
            else
            {
                bool isPrime = IsPrime(number, 2);
                Console.WriteLine($"The number {number} is {(isPrime ? "prime" : "not prime")}.");
            }
        }

        static bool IsPrime(int number, int divisor)
        {
            if (divisor > Math.Sqrt(number))
            {
                return true;
            }

            if (number % divisor == 0)
            {
                return false;
            }

            return IsPrime(number, divisor + 1);
        }
    }
}
