using System;

namespace ArraySwap
{
    internal class ArrayManager
    {
        #region Array 1D
        public int[] Create(int lenght, int min, int max)
        {
            int[] arr = new int[lenght];
            Random rand = new Random();

            for (int i = 0; i < lenght; i++)
            {
                arr[i] = rand.Next(min, max);
            }
            return arr;
        }

        public void Print(int[] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                Console.Write($"{arr[i]}\t");
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        public int GetMin(int[] arr)
        {
            int min = arr[0];

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            return min;
        }

        public int GetMinInd(int[] arr)
        {
            int minInd = 0;

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                if (arr[i] < arr[minInd])
                {
                    minInd = i;
                }
            }
            return minInd;
        }

        public int GetMax(int[] arr)
        {
            int max = arr[0];

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            return max;
        }

        public int GetMaxInd(int[] arr)
        {
            int maxInd = 0;

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                if (arr[i] > arr[maxInd])
                {
                    maxInd = i;
                }
            }
            return maxInd;
        }

        public int[] Swap(int[] arr, int val1Ind, int val1, int val2Ind, int val2)
        {
            arr[val1Ind] = val2;
            arr[val2Ind] = val1;
            return arr;
        }
        #endregion

        #region Array 2D
        public int[,] Create(int height, int width, int min, int max)
        {
            int[,] arr = new int[height, width];
            Random rand = new Random();

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    arr[i, j] = rand.Next(min, max);
                }
            }
            return arr;
        }

        public void Print(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"{arr[i, j]}\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public int GetMin(int[,] arr)
        {
            int min = arr[0, 0];

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] < min)
                    {
                        min = arr[i, j];
                    }
                }
            }
            return min;
        }

        public Index GetMinIndexes(int[,] arr)
        {
            Index indx = new Index();

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] < arr[indx.Index1, indx.Index2])
                    {
                        indx.Index1 = i;
                        indx.Index2 = j;
                    }
                }
            }
            return indx;
        }

        public int GetMax(int[,] arr)
        {
            int max = arr[0, 0];

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] > max)
                    {
                        max = arr[i, j];
                    }
                }
            }
            return max;
        }

        public Index GetMaxIndexes(int[,] arr)
        {
            Index indx = new Index();

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] > arr[indx.Index1, indx.Index2])
                    {
                        indx.Index1 = i;
                        indx.Index2 = j;
                    }
                }
            }
            return indx;
        }

        public int[,] Swap(int[,] arr, Index val1Indx, int val1, Index val2Indx, int val2)
        {
            arr[val1Indx.Index1, val1Indx.Index2] = val2;
            arr[val2Indx.Index1, val2Indx.Index2] = val1;
            return arr;
        }
        #endregion
    }

    class Index
    {
        public int Index1;
        public int Index2;
    }
}
