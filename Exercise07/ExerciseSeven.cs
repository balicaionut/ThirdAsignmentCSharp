using System;

namespace ThirdAsignmentCSharp.Exercise07
{
    class ExerciseSeven
    {
        static public void SentenceToWordsArray()
        {
            Console.WriteLine();
            Console.WriteLine($"Please write any sentence: ");
            String str = Console.ReadLine();

            int len = str.Length;
            char[] charArray = new char[len];

            for (int i = 0; i < len; i++)
            {
                charArray[i] = str[i];
            }

            int v = 0;
            for (int i = 0; i < len; i++)
            {
                if (charArray[i] == ' ')
                {
                    v += 1;
                }
            }
            v += 1;

            Console.WriteLine();
            Console.WriteLine($"The sentence has {v} words.");
            Console.WriteLine();

            String[] strArray = new string[v];
            int k = 0;
            for (int i = 0; i < len; i++)
            {
                if (charArray[i] != ' ')
                    strArray[k] = strArray[k] + str[i];
                else
                    k++;
            }
            
            Console.WriteLine($"The string vector is: ");
            for (int i = 0; i < v; i++)
            {
                if (i == 0)
                    Console.Write($"[{strArray[i]}");
                else if (i == v - 1)
                    Console.Write($",{strArray[i]}]");
                else
                    Console.Write($",{strArray[i]}");
            }
            Console.WriteLine();
        }
    }
}