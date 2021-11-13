using System;
using System.Collections.Generic;

namespace MovingAverage
{
    public class MovingAverageWindow
    {
        private Queue<int> queue;
        private int maxSize;
        private double sum;

        public MovingAverageWindow(int size)
        {
            queue = new Queue<int>();
            maxSize = size;
            sum = 0.0;
        }

        public double Next(int val)
        {
            if (queue.Count == maxSize)
            {
                int tmp = queue.Dequeue();
                sum -= tmp;
            }

            queue.Enqueue(val);
            sum += val;

            return sum / queue.Count;
        }
    }
}
