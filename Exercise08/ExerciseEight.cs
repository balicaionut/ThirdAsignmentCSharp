using System;

namespace ThirdAsignmentCSharp.Exercise08
{
    class ExerciseEight
    {
        static public void EqualCharMatrix()
        {
            Console.WriteLine();
            Console.WriteLine($"Please write a sentence that has words of equal lenght: ");
            String sentence = Console.ReadLine();

            int len = sentence.Length;
            
            //Loop to count the number of words
            int v = 0;
            for (int i = 0; i < len; i++)
            {
                if (sentence[i] == ' ')
                {
                    v += 1;
                }
            }
            v += 1;
                        
            //Array of integers to store the lenght of words
            int[] intArrayNum = new int[v];

            int k = 0;
            int l = 0;
            for (int i = 0; i < len; i++)
            {
                if (sentence[i] != ' ')
                {
                    l++;
                    intArrayNum[k] = l;
                }
                else
                {
                    l = 0;
                    k++;
                }
            }

            //A loop that compares the first word with the rest of the words
            //and if any one of them is not equal the program ends.
            for (int i = 0; i < v; i++)
            {
                if (intArrayNum[0] != intArrayNum[i])
                {
                    Console.WriteLine();
                    Console.WriteLine("The words in the sentence do not have an equal lenght!");
                    Console.WriteLine();
                    Console.WriteLine(" ~ Hint! :)");
                    Console.WriteLine("Try this example: print chars after frase input");
                    return;
                }
            }

            //Initialize an int to store word lenght
            int w = intArrayNum[0];

            //Initialize a char matrix to store the chars
            char[,] equalStrings = new char[v, w];

            //I used a combination of if and 2 for's in order to write into each position of
            // the char matrix the corresponding char from the sentence.
            int x = 0;
            if (x < len)
            {
                for (int a = 0; a < v; a++)
                {
                    for (int b = 0; b < w; b++)
                    {
                        equalStrings[a, b] = sentence[x];
                        x++;
                    }
                    x++;
                }
            }
            
            Console.WriteLine();
            Console.WriteLine("The sentence is transformed into the following char matrix:");
            Console.WriteLine();

            //Two for loops that read and display the char matrix
            for (int i = 0; i < v; i++)
            {
                Console.Write($"Line {i + 1}:");
                for (int j = 0; j < w; j++)
                    Console.Write($" {equalStrings[i, j]} ");
                Console.WriteLine();
            }
            Console.WriteLine();
            
            //This exercise was hard to finish! :D
            //It could be way more elegant, but I am very tired. :(
        }
    }
}