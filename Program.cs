using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yoav_Faran_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int c = 0;
            Console.WriteLine("enter numbers between 0 to 1000 (prime number check)");
            int x = Convert.ToInt32(Console.ReadLine());
           if (PrimeTest(x))
            {
                c++;
            }
            int y = Convert.ToInt32(Console.ReadLine());
            if (PrimeTest(y))
            {
                c++;
            }
            int z = Convert.ToInt32(Console.ReadLine());
            if (PrimeTest(z))
            {
                c++;
            }
            if (c == 3)
            {
                int sum = x + y + z;
                Console.WriteLine($"{x}, {y}, {z} = {sum}");
            }
            else
            {
                Console.WriteLine("Not Primary Numbers");
            }
   

        }

        private static bool PrimeTest(int x)
        {
            while (x > 1000 || x < 0)
            {
                Console.WriteLine("enter a number between 0 to 1000 (prime number check)");
                x = Convert.ToInt32(Console.ReadLine());
            }
            if (x == 1)
            {
                Console.WriteLine("This is NOT a prime number");
                return false;
            }
            else
            {
                int i = 2;
                while (x % i != 0)
                {
                    i++;
                }
                if (i == x)
                {
                    Console.WriteLine("This is Prime");
                    return true;
                }
                else
                {
                    Console.WriteLine("This is NOT a prime number");
                    return false;
                }
            }
        }
    }
}
