namespace BasicPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("creating some basic programs");
            SwapProgram swap = new SwapProgram();   
            swap.swapNumbers();
        }
    }
}