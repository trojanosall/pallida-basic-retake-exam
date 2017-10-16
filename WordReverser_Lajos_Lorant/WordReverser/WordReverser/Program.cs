using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordReverser
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a function that takes a sentence as an input, reverses the letters in every word (but not reverses the words order in the sentence), and returns the sentence with the reversed words.
            // You shouldn't care about upper or lower case letters.
            // Example:
            //
            // string reversedWords = WordReverser("lleW ,enod taht saw ton taht drah");
            // Console.WriteLine(reversedWords);
            //
            // Should print:
            // Well done, that was not that hard.

            string sentence = "lleW ,enod taht saw ton taht drah";

            string reversedWords = WordReverser(sentence);

            Console.WriteLine(reversedWords);

            Console.ReadKey();
        }

        public static string WordReverser(string sentenceForFuncion)
        {
            string[] wordsArray = sentenceForFuncion.Split(' ');
            string[] newWordsArray = new string [wordsArray.Length];
            

            for (int i = 0; i < wordsArray.Length; i++)
            {
                string tempWord = wordsArray[i];

                newWordsArray[i] = Reverse(tempWord);
            }

            string reversedSentece = ConvertStringArrayToString(newWordsArray);
            return reversedSentece;
        }

        public static string Reverse(string text)
        {
            char[] cArray = text.ToCharArray();
            string reverse = String.Empty;
            for (int i = cArray.Length - 1; i > -1; i--)
            {
                reverse += cArray[i];
            }
            return reverse;
        }

        public static string ConvertStringArrayToString(string[] array)
        {
            StringBuilder builder = new StringBuilder();
            foreach (string value in array)
            {
                builder.Append(value);
                builder.Append('.');
            }
            return builder.ToString();
        }

    }
}
