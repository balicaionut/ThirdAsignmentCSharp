using System;

namespace ThirdAsignmentCSharp.Exercise02
{
    class ExerciseTwo
    {
        public static void MinMaxInArray()
        {
            int[] arr;
            arr = new int[10];
            Console.WriteLine();
            Console.WriteLine($"The following arrey has 10 elements that you have to introduce from the console");
            Console.WriteLine($"and will display the minimum and the maximum value and their respective positions.");
            Console.WriteLine();
            Console.WriteLine($"Please insert the values:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"value for position {i}: ");
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            Console.WriteLine($"The arrey has the following elements:");
            Console.WriteLine();
            for (int i = 0; i < arr.Length; i++)
                Console.Write($" {arr[i]}");



        }
    }
}
