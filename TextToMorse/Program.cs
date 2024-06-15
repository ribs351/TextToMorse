using System;
using System.Text;
using TextToMorse.Commons;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter your text here: ");
                string? input;
                do
                {
                    input = Console.ReadLine();
                    if (string.IsNullOrEmpty(input))
                    {
                        Console.WriteLine("You must input something!");
                        Console.WriteLine("Enter your text here: ");
                    }
                } while (string.IsNullOrEmpty(input));

                (var binaryString, var morseString, var binaryMorseString) = StringConversion(input);
                Console.WriteLine($"\nBinary: {binaryString}");
                Console.WriteLine($"Morse: {morseString}");
                Console.WriteLine($"Binary To Morse: {binaryMorseString}\n");
            }
        }

        private static (string binaryString, string morseString, string binaryMorseString) StringConversion(string input)
        {
            var binaryString = new StringBuilder();
            var morseString = new StringBuilder();
            var binaryMorseString = new StringBuilder();

            foreach (var c in input.ToUpper()) // To uppercase because in morse code it doesn't matter if it's lowercase or uppercase
            {
                if (Mapping.morseCodeDictionary.ContainsKey(c))
                {
                    morseString.Append(Mapping.morseCodeDictionary[c] + " ");

                    string binary = Convert.ToString(c, 2).PadLeft(8, '0');
                    binaryString.Append(binary + " ");
                    foreach (char b in binary)
                    {
                        binaryMorseString.Append(Mapping.binaryMorseDictionary[b]);
                    }
                    binaryMorseString.Append(" ");
                }

                else
                {
                    return ("Invalid character detected.", string.Empty, string.Empty);
                }
            }

            return (binaryString.ToString().Trim(), morseString.ToString().Trim(), binaryMorseString.ToString().Trim());
        }
    }
}