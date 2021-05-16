using System;
using System.Collections.Generic;
using System.Text;

namespace WaterContainer.Console
{
    public class Functions
    {
        public static int CalcMostWater(int[] array)
        {
            int container = 0;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    var calc = Math.Min(array[i], array[j]) * (j - i);

                    if (container < calc)
                    {
                        container = calc;
                    }
                }
            }

            return container;
        }
    }
}
