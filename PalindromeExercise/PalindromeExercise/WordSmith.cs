using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsAPalidrome(string word)
        {
            int words = word.Length - 1;
            for (int i = 0; i < word.Length / 2; i++)
            {
                if (word[i] != word[words - i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
