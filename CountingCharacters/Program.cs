using System;

namespace CountingCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a word: ");
            string inputString = Console.ReadLine();
            int length = inputString.Length;

            Console.WriteLine("Enter a character: ");
            string inputChar = Console.ReadLine();
            string inputStringWithoutInputChar = inputString.Replace(inputChar, "");
            int stringLengthWithoutInputChar = inputStringWithoutInputChar.Length;


        }
    }
}
