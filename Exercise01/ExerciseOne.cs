using System;

namespace ThirdAsignmentCSharp.Exercise01
{
    class ExerciseOne
    {
		public static void DisplayVectorThree()
		{
			double[] arr;
			
			arr = new double[3];

			arr[0] = 48.4862;
			arr[1] = 13.56829;
			arr[2] = 8.8956451;

			for (int i = 0; i < arr.Length; i++)
				Console.WriteLine($"Element at index {i}: {arr[i]}");
		}
    }
}
