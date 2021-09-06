using System;
using System.Collections.Generic;

namespace MinimumStepsKnight
{
    class Program
    {
        public class Cell
        {
            public int x, y;
            public int dis;
            public Cell(int x, int y, int dis)
            {
                this.x = x;
                this.y = y;
                this.dis = dis;
            }

        }

        static bool IsInside(int x, int y, int n)
        {
            if (x >= 0 && x < n && y >= 0 && y < n)
                return true;
            return false;
        }

        private static int MinStepToReachTarget(int[] knightPos, int[] targetPos, int n)
        {
            int[] dx = { -2, -1, 1, 2, -2, -1, 1, 2 };
            int[] dy = { -1, -2, -2, -1, 1, 2, 2, 1 };

            Queue<Cell> q = new Queue<Cell>();

            q.Enqueue(new Cell(knightPos[0], knightPos[1], 0));

            Cell t;
            int x, y;
            bool[,] visit = new bool[n, n];

            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {
                    visit[i,j] = false;
                }

            visit[knightPos[0], knightPos[1]] = true;

            while  (q.Count != 0)
            {
                t = q.Peek();
                q.Dequeue();

                if (t.x == targetPos[0] && t.y == targetPos[1])
                    return t.dis;

                for (int i = 0; i < 8; i++)
                {
                    x = t.x + dx[i];
                    y = t.y + dy[i];

                    if (IsInside(x, y, n) && !visit[x,y])
                    {
                        visit[x, y] = true;
                        q.Enqueue(new Cell(x, y, t.dis + 1));
                    }
                }
            }
            return int.MaxValue;
        }

        static void Main(string[] args)
        {
            //int a = 5;
            //int sum = 2;
            //sum += a;
            //Console.WriteLine("Hello World 1!");

            //int n = 8;
            //int[] knightPos = { 0, 0 };
            //int[] targetPos = { 7, 7 };

            int n = 30;
            int[] knightPos = { 0, 0 };
            int[] targetPos = { 29, 29 };
            Console.WriteLine(MinStepToReachTarget(knightPos, targetPos, n));
        }
    }
}
