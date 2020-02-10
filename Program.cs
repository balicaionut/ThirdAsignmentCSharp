using System;
using ThirdAsignmentCSharp.Exercise01;
using ThirdAsignmentCSharp.Exercise02;
using ThirdAsignmentCSharp.Exercise03;
using ThirdAsignmentCSharp.Exercise04;
using ThirdAsignmentCSharp.Exercise05;
using ThirdAsignmentCSharp.Exercise06;
using ThirdAsignmentCSharp.Exercise07;
using ThirdAsignmentCSharp.Exercise08;

namespace SecondAsignmentCSharp
{
	class Program
	{
		static void Main(string[] args)
		{
			bool showMenu = true;
			while (showMenu)
			{
				showMenu = BoolMenu();
			}
		}

		private static bool BoolMenu()
		{
			Menu.MainMenu();
			switch (Console.ReadLine())
			{
				case "1":
					ExerciseOne.DisplayVectorThree();
					Continue();
					return true;
				case "2":
					ExerciseTwo.MinMaxInArray();
					Continue();
					return true;
				case "3":
					ExerciseThree.NegativePosition();
					Continue();
					return true;
				case "4":
					ExerciseFour.StringToArray();
					Continue();
					return true;
				case "5":
					ExerciseFive.EvenToUpper();
					Continue();
					return true;
				case "6":
					ExerciseSix.AdditionDoubleToVector();
					Continue();
					return true;
				case "7":
					ExerciseSeven.SentenceToWordsArray();
					Continue();
					return true;
				case "8":
					ExerciseEight.EqualCharMatrix();
					Continue();
					return true;
				case "0":
					return false;
				default:
					Console.WriteLine(" Error: invalid selection");
					Continue();
					return true;
			}
		}
		private static void Continue()
		{
			Console.WriteLine();
			Console.WriteLine($" press any key to continue");
			Console.WriteLine();
			Console.ReadKey();
		}
	}
}
