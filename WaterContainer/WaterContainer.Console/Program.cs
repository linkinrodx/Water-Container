using System;
using System.Linq;

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

            //var test1 = Functions.CalcMostWater(array1);
            //var test2 = Functions.CalcMostWater(array2);
            //var test3 = Functions.CalcMostWater(array3);
            //var test4 = Functions.CalcMostWater(array4);

            Begin:
            System.Console.WriteLine("Welcome to the WATER CONTAINER CHALLENGE!!!");

            System.Console.WriteLine("\nChoose an option to enter an array:");

            System.Console.WriteLine("# 1: [1, 8, 6, 2, 5, 4, 8, 3, 7]");
            System.Console.WriteLine("# 2: [1, 1]");
            System.Console.WriteLine("# 3: [4, 3, 2, 1, 4]");
            System.Console.WriteLine("# 4: [1, 2, 1]");

            System.Console.WriteLine("# 5: Enter your own numbers...");

            var option = System.Console.ReadLine();

            switch (option.Trim())
            {
                case "1":
                    System.Console.WriteLine("\n# 1: [1, 8, 6, 2, 5, 4, 8, 3, 7]");
                    System.Console.WriteLine("Result: " + Functions.CalcMostWater(array1).ToString());
                    break;
                case "2":
                    System.Console.WriteLine("\n# 2: [1, 1]");
                    System.Console.WriteLine("Result: " + Functions.CalcMostWater(array2).ToString());
                    break;
                case "3":
                    System.Console.WriteLine("\n# 3: [4, 3, 2, 1, 4]");
                    System.Console.WriteLine("Result: " + Functions.CalcMostWater(array3).ToString());
                    break;
                case "4":
                    System.Console.WriteLine("\n# 4: [1, 2, 1]");
                    System.Console.WriteLine("Result: " + Functions.CalcMostWater(array4).ToString());
                    break;
                case "5":
                    System.Console.WriteLine("\nPush your own numbers like this example: 1,2,3,4");
                    var ownNumbers = System.Console.ReadLine();

                    try
                    {
                        var arrayOwnNumbers = ownNumbers.Split(',');
                        int[] array5 = Array.ConvertAll(arrayOwnNumbers, int.Parse);

                        System.Console.WriteLine("\n# 5: [" + ownNumbers.Trim() + "]");
                        System.Console.WriteLine("Result: " + Functions.CalcMostWater(array5).ToString());
                    }
                    catch (Exception)
                    {
                        System.Console.WriteLine("\nTry again...");
                        System.Console.Clear();
                        goto Begin;
                    }
                    break;
                default:
                    System.Console.WriteLine("\nTry again...");
                    System.Console.Clear();
                    goto Begin;
            }

            System.Console.WriteLine("\nDo you want to try it again? (y/n)");
            
            var again = System.Console.ReadLine();

            if (again.Trim() == "y")
            {
                System.Console.Clear();
                goto Begin;
            }
        }
    }
}
