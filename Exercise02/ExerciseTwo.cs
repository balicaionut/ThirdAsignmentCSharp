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

            //This is a loop that takes the input from the user and inserts it into the array
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"Please insert the values for position {i}: ");
                arr[i] = int.Parse(Console.ReadLine());
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine($"The arrey has the following elements:");
            Console.WriteLine();

            //This is a loop that displays the array
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($" {arr[i]}");
            }
            Console.WriteLine();
            Console.WriteLine();

            int max = 0;
            //This is a loop that searches for the maximum value
            for (int i = 0; i < arr.Length; i++)
            {
                if (max <= arr[i])
                    max = arr[i];
            }

            int[] arrPos = new int[10];
            int pos = 0;
            //The following segment has a loop that searches for the position where the maximum value is
            //and writes the postions in another arrey that will be read in the next loop
            for (int i = 0; i < arr.Length; i++)
            {
                if (max == arr[i])
                {
                    arrPos[pos] = i + 1;
                    pos++;
                }
            }
            arrPos[pos + 1] = 0;

            string posMax = "";
            //In this loop we convert the positions arrey into a string with spaces
            // in order to help us to write it to the console
            for (int i = 0; i < arrPos.Length; i++)
            {
                if (arrPos[i] != 0)
                {
                    posMax = posMax + arrPos[i].ToString() + " ";
                    pos++;
                }
            }
            Console.WriteLine($"The maximum value is: {max} and is found at the positions: {posMax}");
            Console.WriteLine();

            int min = max;
            //This is a loop that searches for the minimum value
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (min >= arr [i])
                    min = arr[i];
            }

            arrPos = new int[10];
            pos = 0;
            //The following segment has a loop that searches for the position where the minimum value is
            //and writes the postions in another arrey that will be read in the next loop
            for (int i = 0; i < arr.Length; i++)
            {
                if (min == arr[i])
                {
                    arrPos[pos] = i + 1;
                    pos++;
                }
            }
            arrPos[pos + 1] = 0;

            string posMin = "";
            //In this loop we convert the positions arrey into a string with spaces
            // in order to help us to write it to the console
            for (int i = 0; i < arrPos.Length; i++)
            {
                if (arrPos[i] != 0)
                {
                    posMin = posMin + arrPos[i].ToString() + " ";
                    pos++;
                }
            }
            Console.WriteLine($"The minimum value is: {min} and is found at the positions: {posMin}");
            Console.WriteLine();
        }
    }
}