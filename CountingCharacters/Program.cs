using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;

namespace CountingCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a word: ");
            string inputString = Console.ReadLine();
            Dictionary<char, int> charsInString = new Dictionary<char, int>();

            //the following loop attempts to reduce the amount of iterations by removing characters that have already been evaluated
            //is not case-insensitve and includes non-alphabetical characters for now
            while (inputString.Length > 0)
            {
                int counter = 0;
                for (int i = 0; i < inputString.Length; i++)
                {
                    if (inputString[0] == inputString[i])
                    {
                        counter++;
                    }
                }
                charsInString.Add(inputString[0], counter);
                inputString = inputString.Replace(inputString[0].ToString(), "");
            }

            foreach (KeyValuePair<char, int> charInString in charsInString)
            {
                Console.WriteLine(charInString.Key + " : " + charInString.Value);
            }
        }
    }
}
