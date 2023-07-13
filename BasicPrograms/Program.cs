using System;
namespace BasicPrograms;
public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("creating some basic programs");
        Console.WriteLine("select program which you want to do \n 1.Swap NUmbers\n 2.EvenOrOdd\n 3.Find largest Number");
        int option = Convert.ToInt32(Console.ReadLine());
        switch (option)
        {
          case 1:
                {
                    SwapProgram swap = new SwapProgram();
                    swap.swapNumbers();

                    break;
                }
         case 2:
                { EvenOrOdd evenOrOdd = new EvenOrOdd();
                    evenOrOdd.check();
                    break;
                }
         case 3:
                {
                    Console.WriteLine("enter numbers to check ");
                    int a=Convert.ToInt32(Console.ReadLine());
                    int b = Convert.ToInt32(Console.ReadLine());
                    int c = Convert.ToInt32(Console.ReadLine());
                    GreatestNumber greatestNumber = new GreatestNumber();
                    greatestNumber.Numbers(a, b, c);
                    break;
                }
            default:
            Console.WriteLine("Invalid option selected.");
                break;
        }


    }

}