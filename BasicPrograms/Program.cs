using System;
namespace BasicPrograms;



public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("creating some basic programs");
        Console.WriteLine("select program which you want to do 1.Swap NUmbers\n 2.EvenOrOdd");
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
          default:
            Console.WriteLine("Invalid option selected.");
                break;
        }


    }

}