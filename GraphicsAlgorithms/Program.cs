using System;

namespace GraphicsAlgorithms
{
    public class Program
    {
        static void Main(string[] args)
        {
            DdaLine.Calculate(1, 1, 18, 6);
            Console.WriteLine();
            BresenhamLine.Calculate(1, 1, 18, 6);
            Console.WriteLine();
            BresenhamLine.Calculate(8, 1, 5, 19);
            Console.WriteLine();
        }
    }
}
