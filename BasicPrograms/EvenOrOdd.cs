using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    public class EvenOrOdd
    {
        public void check()
        {
            Console.WriteLine("enter number that you want to check");
            int Num = Convert.ToInt32(Console.ReadLine());
            if (Num % 2 == 0)
                Console.WriteLine("Given number is even");
            else
                Console.WriteLine(" Given number is odd");
        }

    }
}
