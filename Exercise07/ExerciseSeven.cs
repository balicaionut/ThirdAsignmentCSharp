using System;

namespace ThirdAsignmentCSharp.Exercise07
{
    class ExerciseSeven
    {
        static public void SentenceToWordsArray()
        {
            Console.WriteLine();
            Console.WriteLine($"Please write any sentence: ");
            String sentence = Console.ReadLine();

            int len = sentence.Length;

            //Loop that counts the number of words
            int v = 0;
            for (int i = 0; i < len; i++)
            {
                if (sentence[i] == ' ')
                {
                    v += 1;
                }
            }
            v += 1;

            Console.WriteLine();
            Console.WriteLine($"The sentence has {v} words.");
            Console.WriteLine();

            //Initializing the new string array that will store the words
            String[] strArray = new string[v];

            //One for loop and an if-else that reads the sentence
            //and storres the wards by building them character by character
            //until it meets a space or the end of the sentence
            int k = 0;
            for (int i = 0; i < len; i++)
            {
                if (sentence[i] != ' ')
                    strArray[k] = strArray[k] + sentence[i];
                else
                    k++;
            }

            //On for loop and an if-elseif-else condition tree
            //that displays a visualy formated array of the string vector.
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