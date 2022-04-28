using System;

namespace ArraySwap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayManager arrayMngr1 = new ArrayManager();
            int[] arr1D = arrayMngr1.Create(8, 0, 99);
            arrayMngr1.Print(arr1D);
            int min1D = arrayMngr1.GetMin(arr1D);
            int min1DInd = arrayMngr1.GetMinInd(arr1D);
            int max1D = arrayMngr1.GetMax(arr1D);
            int max1DInd = arrayMngr1.GetMaxInd(arr1D);
            arr1D = arrayMngr1.Swap(arr1D, min1DInd, min1D, max1DInd, max1D);
            arrayMngr1.Print(arr1D);
            Console.WriteLine();

            Index min2DInd = new Index();
            Index max2DInd = new Index();
            int[,] arr2D = arrayMngr1.Create(5, 7, 0, 99);
            arrayMngr1.Print(arr2D);
            int min2D = arrayMngr1.GetMin(arr2D);
            min2DInd = arrayMngr1.GetMinIndexes(arr2D);
            int max2D = arrayMngr1.GetMax(arr2D);
            max2DInd = arrayMngr1.GetMaxIndexes(arr2D);
            arr2D = arrayMngr1.Swap(arr2D, min2DInd, min2D, max2DInd, max2D);
            arrayMngr1.Print(arr2D);
        }
    }
}
