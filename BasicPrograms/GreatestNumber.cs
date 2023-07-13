using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    public  class GreatestNumber
    {
        public void  Numbers(int a, int b,int c)
        {
            if (a >= b && a >= c)
                Console.WriteLine("{0} is largest number", a);
            else if (b >= a && b >= c)
                Console.WriteLine("{0} is largest number", b);
            else
                Console.WriteLine("{0}is largest number", c);        
        }
        
    }
}
