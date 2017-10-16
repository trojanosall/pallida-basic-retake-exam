﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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

            // var countedLetters = CountLetters("da_vinci_code.txt");
            // Console.WriteLine("0 occured {0} times in the file.", countedLetters["0"]);
            // Console.WriteLine("1 occured {0} times in the file.", countedLetters["1"]);
            // Console.WriteLine("x occured {0} times in the file.", countedLetters["x"]);

        }

        public static Dictionary<string, int> CountChars(string fileNameForFuncion)
        {
            string[] myArray = File.ReadAllLines(fileNameForFuncion);
            Array.Sort(myArray);

            var myDictionary = new Dictionary<string, int>();

            int numberOfZero = 0, numberOfOne = 0, numberOfX = 0;

            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] == "0")
                {
                    numberOfZero++;
                }
                else if (myArray[i] == "1")
                {
                    numberOfOne++;
                }
                else
                {
                    numberOfX++;
                }
            }

            myDictionary.Add("0", numberOfZero);
            myDictionary.Add("1", numberOfOne);
            myDictionary.Add("x", numberOfX);

            return myDictionary;
        }
    }
}