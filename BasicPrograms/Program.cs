using System;
namespace BasicPrograms;
public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("creating some basic programs");
        Console.WriteLine("select program which you want to do \n 1.Swap NUmbers\n 2.EvenOrOdd\n 3.Find largest " +
            "Number\n 4.Quotientand Remainder\n 5.VowelOrCosonant\n 6.leap Year\n 7.Flipcoin\n 8.Power of 2");
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
            case 4:
                {
                    QuotientAndRemainder quotientAndRemainder = new QuotientAndRemainder();
                    quotientAndRemainder.findQuotientAndRemainder();
                    break;
                }
            case 5:
                VowelOrCosonant vowelOrConsonant = new VowelOrCosonant();
                vowelOrConsonant.CheckVowelOrConsonant();
                break;
            case 6:
               
                LeapYear leapYear = new LeapYear();
                leapYear.InputYear();
                break;
            case 7:
                FlipCoin coin = new FlipCoin();
                coin.percentageOfHeadVsTail();
                break;
            case 8:
                PowerOfTwo powerOfTwo = new PowerOfTwo();
                powerOfTwo.CalculatePower();
                break;
            default:
            Console.WriteLine("Invalid option selected.");
                break;
        }


    }

}