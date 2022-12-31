using System;

namespace Recursion_PPT1
{
    class Program
    {
        static void Main()
        {

        }

        #region Factorial
        static int Factorial_Loop(int n)
        {
            int result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }

        static int Factorial_Recursive(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            return n * Factorial_Recursive(n - 1);
        }
        #endregion

        #region Fibonacci
        static int Fibonacci_Loop(int nth)
        {
            int t1 = 0;
            int t2 = 1;
            if (nth == 1) return t1;
            if (nth == 2) return t2;
            int tn = 0;
            for (int i = 3; i <= nth; i++)
            {
                tn = t1 + t2;
                t1 = t2;
                t2 = tn;
            }
            return tn;
        }

        static int Fibonacci_Recursive(int nth)
        {
            int t1 = 0;
            int t2 = 1;
            if (nth == 1) return t1;
            if (nth == 2) return t2;
            return Fibonacci_Recursive(nth - 1) + Fibonacci_Recursive(nth - 2);
        }

        private const string V = "Hello";
        #endregion

        #region Nested loop
        static readonly int numberOfLoops = 2;
        static readonly int numberOfIterations = 2;
        static readonly int[] loops = new int[2];

        static void NestedLoop_Recursive(int index = 0)
        {
            if (index == numberOfLoops)
            {
                PrintLoop();
                return;
            }
            for (int counter = 0; counter < numberOfIterations; counter++)
            {
                loops[index] = counter;
                NestedLoop_Recursive(index + 1);
            }
        }
        static void PrintLoop()
        {
            for (int i = 0; i < numberOfLoops; i++)
            {
                Console.Write($"{loops[i]} ");
            }
            Console.WriteLine();
        }

        #endregion

        #region Subset of a set

        public const string SAMPLE_SET = "Hello";

        #endregion

        #region Paths in a Maze
        static readonly int[,] lab = new int[,]
        {
            {' ', ' ', ' ', '*', ' ', ' ', ' '},
            {'*', '*', ' ', '*', ' ', '*', ' '},
            {' ', ' ', ' ', ' ', ' ', ' ', ' '},
            {' ', '*', '*', '*', '*', '*', ' '},
            {' ', ' ', ' ', ' ', ' ', ' ', 'e'}
        };
        static void FindPath(int x = 0, int y = 0)
        {
            if ((y < 0) || (x < 0) ||
            (y >= lab.GetLength(1)) || (x >= lab.GetLength(0)))
            {
                return;
            }

            if (lab[x, y] == 'e')
            {
                Console.WriteLine("Found an exit!");
            }
            if (lab[x, y] != ' ')
            {
                return;
            }

            lab[x, y] = 's';

            FindPath(x, y - 1);
            FindPath(x - 1, y);
            FindPath(x, y + 1);
            FindPath(x + 1, y);

            lab[x, y] = ' ';
        }
        #endregion
    }
}
