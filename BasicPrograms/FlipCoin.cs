using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    internal class FlipCoin
    {   double head = 0;
        double tail = 0;
        double headPercentage, tailPercentage;
        public  void percentageOfHeadVsTail()
        {
            Console.WriteLine("Enter number of time to flip coin ");
             int num= Convert.ToInt32(Console.ReadLine());
            for (int i = 0;i<=num;i++) 
            { 
                Random random = new Random();
                double result = random.NextDouble();
                if (result > 0.5)
                    head++;
                else
                    tail++;
             }
            Console.WriteLine("head count is " + head);
            Console.WriteLine("tail count is " + tail);
            headPercentage =(head/num) * 100;
            Console.WriteLine("head percentage is" + headPercentage);
            tailPercentage =(tail/num) * 100;
            Console.WriteLine("tail percentage is " + tailPercentage);
        }









           
    }
}
