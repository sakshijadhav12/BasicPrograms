using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 namespace BasicPrograms
    {
    internal class LeapYear
    {
        public void InputYear()
        {
            Console.WriteLine("Enter a year:");
            int year = Convert.ToInt32(Console.ReadLine());

            if (year >= 1000 && year <= 9999)
            {
                if (IsLeapYear(year))
                {
                    Console.WriteLine("{0} is a leap year.", year);
                }
                else
                {
                    Console.WriteLine("{0} is not a leap year.", year);
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a 4-digit year.");
            }
        }

        private bool IsLeapYear(int year)
        {
            return year % 4 == 0 && (year % 400 == 0 || year % 100 != 0);
        }
    }
 }       
    

    