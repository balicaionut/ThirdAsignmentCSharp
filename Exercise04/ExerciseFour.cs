using System;

namespace ThirdAsignmentCSharp.Exercise04
{
    class ExerciseFour
    {
        public static void StringToArray()
        {
            Console.WriteLine();
            Console.WriteLine($"The following string:");
            Console.WriteLine();


            String str = "String to Array!";
            Console.WriteLine(str);

            int len = str.Length;
            char[] charArray = new char[len];

            Console.WriteLine();
            Console.WriteLine($"is converted into the following array:");
            Console.WriteLine();
            
            //this loop converts the string into an array of chars
            for (int i = 0; i < str.Length; i++)
            {
                charArray[i] = str[i];
            }

            //trhis loop reads and displays the array of chars
            for (int i = 0; i < charArray.Length; i++)
            {
                if(i == 0)
                    Console.Write($"[{charArray[i]}");
                else if(i == charArray.Length - 1)
                    Console.Write($"{charArray[i]}]");
                else
                    Console.Write($",{charArray[i]}");
            }
            Console.WriteLine();
        }
    }
}