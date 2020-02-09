using System;

namespace ThirdAsignmentCSharp.Exercise05
{
    class ExerciseFive
    {
        public static void EvenToUpper()
        {
            Console.WriteLine();
            Console.WriteLine($"The following string is transformed to have the even positions written with uppercase:");
            Console.WriteLine();
            
            String str = "String to even position UPERCASE!";
            Console.WriteLine(str);

            int len = str.Length;
            char[] charArray = new char[len];

            //the loop will go trough each position of the string
            //and will transform the element with index 0 (position 1) into lowercase
            //after, if the element index is even (position odd) will transform it into lowercase
            //and else the position will be even and the character will be transformed into uppercase
            for (int i = 0; i < charArray.Length; i++)
            {
                if (i == 0)
                    charArray[i] = char.ToLower(str[i]);
                else if (i > 1 && i % 2 == 0)
                    charArray[i] = char.ToLower(str[i]);
                else
                    charArray[i] = char.ToUpper(str[i]);
            }

            String newStr = new string(charArray);

            Console.WriteLine();
            Console.WriteLine($"Transformed:");
            Console.WriteLine();
            Console.WriteLine(newStr);
            Console.WriteLine();
        }
    }
}