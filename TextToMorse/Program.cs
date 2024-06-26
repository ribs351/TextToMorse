using TextToMorse.Utils;

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
                        Console.WriteLine("You must input something!\nEnter your text here: \n");
                    }
                    else if (input.Any(c => !char.IsLetterOrDigit(c)))
                    {
                        Console.WriteLine("Invalid character detected.\nEnter your text here: \n");
                    }
                }
                while (string.IsNullOrEmpty(input) || input.Any(c => !char.IsLetterOrDigit(c)));
                input = input.ToUpper();
                var morseString = ConverterUtils.StringToMorse(input);
                var (hexString, hexMorseString) = ConverterUtils.HexToMorse(input);
                var (decimalString, decimalMorseString) = ConverterUtils.DecimalToMorse(input);
                var (octalString, octalMorseString) = ConverterUtils.OctalToMorse(input);
                
                Console.WriteLine($"\nMorse String: {morseString}");

                Console.WriteLine($"\nDecimal String: {decimalString}");
                Console.WriteLine($"\nDecimal Morse String: {decimalMorseString}");
                
                Console.WriteLine($"\nOctal String: {octalString}");
                Console.WriteLine($"\nOctal Morse String: {octalMorseString}");
                
                Console.WriteLine($"\nHex String: {hexString}");
                Console.WriteLine($"\nHex Morse String: {hexMorseString}");
            }
        }
    }
}