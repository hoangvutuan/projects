using System;

namespace MovingAverage
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            MovingAverageWindow movingAverageWindow = new MovingAverageWindow(3);

            double res = movingAverageWindow.Next(1);
            Console.WriteLine($"Step 1: {res}");

            res = movingAverageWindow.Next(10);
            Console.WriteLine($"Step 2: {res}");

            res = movingAverageWindow.Next(3);
            Console.WriteLine($"Step 3: {res}");

            res = movingAverageWindow.Next(5);
            Console.WriteLine($"Step 4: {res}");
        }
    }
}
