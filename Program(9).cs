using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication150
{
    class Program
    {
        static long Factorial(int s)
        {
            if (s <= 1)
                return 1;

            return s * Factorial(s - 1);
        }
        static void Main(string[] args)
        {
             int[] numbers = new int[6];

            Console.WriteLine("enter 6 number:");

            for (int i = 0; i < 6; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("result:");

            for (int i = 0; i < 6; i++)
            {
                //Console.WriteLine($"Factorial {numbers[i]} = {Factorial(numbers[i])}");
                Console.WriteLine("Factorial " + numbers[i] + " = " + Factorial(numbers[i]));
            }

            Console.ReadKey();
        }
    }
}
