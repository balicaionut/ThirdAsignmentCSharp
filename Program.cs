using System;
using ThirdAsignmentCSharp.Exercise01;

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
					
					Continue();
					return true;
				case "2":
					
					Continue();
					return true;
				case "3":
					
					Continue();
					return true;
				case "4":
					
					Continue();
					return true;
				case "5":
					
					Continue();
					return true;
				case "6":
					
					Continue();
					return true;
				case "7":
					
					Continue();
					return true;
				case "8":
					
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
