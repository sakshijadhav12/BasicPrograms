using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    internal class Factors
    {
        public void PrintPrimeFactors()
        {
            Console.Write("Enter the number to find prime factors: ");
            int N = Convert.ToInt32(Console.ReadLine());
            int i = 2;
            Console.Write("Prime factors of " + N + " are: ");
            while (N > 1)
            {
                if (N % i == 0)
                {
                    Console.Write(i + " ");
                    N /= i;
                }
                else
                {
                    i++;
                }

            }
          
            Console.WriteLine();

        }
    }    
}
