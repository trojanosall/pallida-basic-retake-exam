using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.InteropServices;

namespace CountChars
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a function that takes the filepath (e.g. "da_vinci_code.txt") as an input, reads the given file, and counts the occurences of 0, 1 and x characters in it.
            // The function should return a dictionary in which the searched characters are the keys and the number of their occurences are the values.
            // Use the uploaded da_vinci_code.txt file in this folder on GitHub to test your program.
            // For example:
            //
            // var countedLetters = CountLetters("da_vinci_code.txt");
            // Console.WriteLine("0 occured {0} times in the file.", countedLetters["0"]);
            // Console.WriteLine("1 occured {0} times in the file.", countedLetters["1"]);
            // Console.WriteLine("x occured {0} times in the file.", countedLetters["x"]);
            // 
            // Should print:
            // 0 occured 3393 times in the file.
            // 1 occured 3375 times in the file.
            // x occured 3232 times in the file.

            string fileName = @"da_vinci_code.txt";

            CountChars(fileName);

            var countedLetters = CountChars(fileName);
            Console.WriteLine("0 occured {0} times in the file.", countedLetters["0"]);
            Console.WriteLine("1 occured {0} times in the file.", countedLetters["1"]);
            Console.WriteLine("x occured {0} times in the file.", countedLetters["x"]);

            Console.ReadKey();

        }

        public static Dictionary<string, int> CountChars(string fileNameForFuncion)
        {

            var myDictionary = new Dictionary<string, int>();

            int numberOfZero = 0, numberOfOne = 0, numberOfX = 0;

            if (File.Exists(fileNameForFuncion))
            {
                using (StreamReader sr = File.OpenText(fileNameForFuncion))
                {
                    string content = "";



                    List<string> myContent = new List<string>();

                    while ((content = sr.ReadLine()) != null)
                    {
                        myContent.Add(content.ToLower().Replace(" ", ""));
                    }

                    for (int i = 0; i < myContent.Count; i++)
                    {
                        string tempListElement = myContent[i];

                        for (int j = 0; j < tempListElement.Length; j++)
                        {
                            if (tempListElement[j] == '0')
                            {
                                numberOfZero += 1;
                            }
                            else if (tempListElement[j] == '1')
                            {
                                numberOfOne += 1;
                            }
                            else
                            {
                                numberOfX += 1;
                            }
                        }
                    }
                }
            }
            myDictionary.Add("0", numberOfZero);
            myDictionary.Add("1", numberOfOne);
            myDictionary.Add("x", numberOfX);

            return myDictionary;

        }

    }
}
