using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdAsignmentCSharp.Exercise06
{
    class ExerciseSix
    {
		public static void AdditionDoubleToVector()
		{
			Console.WriteLine();
			Console.WriteLine($"The program has an array of 4 integer numbers that each will be added with a double number");
			Console.WriteLine($"and then, each result will be storred in another vector.");
			Console.WriteLine();

			int[] arrInt;
			arrInt = new int[4];

			arrInt[0] = 4;
			arrInt[1] = 1;
			arrInt[2] = 5;
			arrInt[3] = 8;

			Console.WriteLine($"The arrey has the following elements:");
			Console.WriteLine();

			//This is a loop that displays the integer array
			for (int i = 0; i < arrInt.Length; i++)
			{
				Console.Write($" {arrInt[i]}");
			}
			Console.WriteLine();
			Console.WriteLine();

			double nDouble = 42.7186539;
			Console.WriteLine($"The added number is: {nDouble}");
			Console.WriteLine();

			double[] arrDouble;
			arrDouble = new double[4];

			//This is a loop that reads each position from the integer array adds the declared double value to it
			//and storres the result in the corresponding position of the double array
			for (int i = 0; i < arrInt.Length; i++)
				arrDouble[i] = arrInt[i] + nDouble;

			Console.WriteLine($"The arrey has the following elements:");
			Console.WriteLine();

			//This is a loop that displays the double array
			for (int i = 0; i < arrDouble.Length; i++)
			{
				Console.Write($" {arrDouble[i]}");
			}
			Console.WriteLine();
		}
	}
}