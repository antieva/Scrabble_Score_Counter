using System.Collections.Generic;
using System;

namespace ScrabbleScoreApp.Models
{
    public class ScrabbleScore
    {


        public static int Score(string myWord)
        {
            string[][] letters = new string[7][];
            letters[0] = new string[] {"A","E", "I", "O", "U", "L", "N", "R", "S", "T"};
            letters[1] = new string[] {"D", "G"};
            letters[2] = new string[] {"B", "C", "M", "P"};
            letters[3] = new string[] {"F", "H", "V", "W", "Y"};
            letters[4] = new string[] {"K"};
            letters[5] = new string[] {"J", "X"};
            letters[6] = new string[] {"Q", "Z"};
            int lettersLength = letters.Length;
            Console.WriteLine(letters[1][1]);
            Console.WriteLine(letters.Length);
            int score = 0;
            Console.WriteLine(letters.GetLength(0));
            for (int i = 0; i < lettersLength; i++) {
                for (int j = 0; j < letters[i].Length; j++) {
                    Console.WriteLine("Hello");
                    Console.WriteLine(letters[i].Length);
                    if (myWord.Contains(letters[i][j])) {
                        score += i + 1;
                    }
                }
            }
            return score;
        }
    }
}
