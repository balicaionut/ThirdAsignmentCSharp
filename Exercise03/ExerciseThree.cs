using System;

namespace ThirdAsignmentCSharp.Exercise03
{
    class ExerciseThree
    {
		public static void NegativePosition()
		{
            Console.WriteLine();
            Console.WriteLine($"The following arrey has 5 positions that are preloaded and one value that is negative.");
            Console.WriteLine();
            
            int[] arr;
            arr = new int[5];
            arr[0] = 5;
            arr[1] = 7;
            arr[2] = 3;
            arr[3] = -2;
            arr[4] = 8;
            
            //This is a loop that displays the array
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($" {arr[i]}");
            }
            Console.WriteLine();
            Console.WriteLine();
            //This is a loop that searches for the negative value and displays it and its position
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                    Console.WriteLine($"The negative value is {arr[i]} and is found at the positions: {i + 1}");
            }
            Console.WriteLine();
        }
	}
}