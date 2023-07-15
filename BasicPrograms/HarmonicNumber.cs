using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    internal class HarmonicNumber
    {
        public void CalculateHarmonicValue()
        {
            Console.Write("Enter the value of N: ");
            int N = int.Parse(Console.ReadLine());

            if (N != 0)
            {
                double harmonic = 0.0;
                for (int i = 1; i <= N; i++)
                {
                    harmonic += 1.0 / i;
                }

                Console.WriteLine("The " + N + "th Harmonic Value is: " + harmonic);
            }
            else
            {
                Console.WriteLine("Invalid input. N should be a non-zero value.");
            }
        } 
    }   
}






