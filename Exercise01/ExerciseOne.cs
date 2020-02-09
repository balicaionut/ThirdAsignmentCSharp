using System;

namespace ThirdAsignmentCSharp.Exercise01
{
    class ExerciseOne
    {
		public static void DisplayVectorThree()
		{
			Console.WriteLine();
			Console.WriteLine($"The program contains a predeclared vector containing some double values");
			Console.WriteLine($"and goes trough each element and displays it to the console.");
			Console.WriteLine();

			double[] arr;
			
			arr = new double[3];

			arr[0] = 48.4862;
			arr[1] = 13.56829;
			arr[2] = 8.8956451;

			//the for loop reads each position of the vector and displays it
			for (int i = 0; i < arr.Length; i++)
				Console.WriteLine($"Element at index {i}: {arr[i]}");
		}
    }
}