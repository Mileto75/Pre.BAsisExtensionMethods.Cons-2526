using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pre.BasisExtensionMethods.Cons.Extensions
{
    //static class for extension methods
    public static class StringExtensions
    {
        //define static methods with this parameter keyword
        public static int CountWords(this string words)
        {
            if (string.IsNullOrEmpty(words))
                return 0;
            var wordsArray = words.Split(" ");
            return wordsArray.Count();
        }
        public static int CountLetters(this string words)
        {
            if (string.IsNullOrEmpty(words))
                return 0;
            int numberOfLetters = 0;
            foreach (var character in words)
            {
                if (character != ' ')
                    numberOfLetters++;
            }
            return numberOfLetters;
        }
    }
}
