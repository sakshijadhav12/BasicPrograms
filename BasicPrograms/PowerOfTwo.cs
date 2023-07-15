using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    internal class PowerOfTwo
    {
        public void CalculatePower()
        {
           Console.Write("Enter the power value\n please enter vaule between 0 to 30): ");
           int N = Convert.ToInt32(Console.ReadLine());

           if (N < 0 || N >= 31)
           {
            Console.WriteLine("Invalid input. Please enter a valid value for N.");
            
            }
           else
              Console.WriteLine("Powers of 2:");
             for (int i = 0; i <= N; i++)
              {
                int power = (int)Math.Pow(2, i);
                Console.WriteLine("2^" + i + " = " + power);
               }
            }
        }

    }

