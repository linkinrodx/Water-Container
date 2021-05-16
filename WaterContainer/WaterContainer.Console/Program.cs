using System;

namespace WaterContainer.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 };
            int[] array2 = new int[] { 1, 1 };
            int[] array3 = new int[] { 4, 3, 2, 1, 4 };
            int[] array4 = new int[] { 1, 2, 1 };

            var test1 = Functions.CalcMostWater(array1);
            var test2 = Functions.CalcMostWater(array2);
            var test3 = Functions.CalcMostWater(array3);
            var test4 = Functions.CalcMostWater(array4);
        }
    }
}
