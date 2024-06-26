using System.Text;
using TextToMorse.Commons;

namespace TextToMorse.Utils;

public static class ConverterUtils
{
    public static string StringToMorse(string input)
    {
        var morseString = new StringBuilder();
        foreach (char c in input)
        {
            if (Mapping.morseCodeDictionary.ContainsKey(c))
            {
                morseString.Append(Mapping.morseCodeDictionary[c] + " ");
            }
        }
        return morseString.ToString().Trim();
    }

    public static (string decimalString, string decimalMorseString) DecimalToMorse(string input)
    {
        var decimalString = new StringBuilder();
        var decimalMorseString = new StringBuilder();
        foreach (char c in input)
        {
            var deci = Convert.ToString(c, 10).ToUpper();
            decimalString.Append(deci + " ");
            foreach (char d in deci)
            {
                decimalMorseString.Append(Mapping.morseCodeDictionary[d] + " ");
            }
            decimalMorseString.Append(" ");
        }
        return (decimalString.ToString().Trim(), decimalMorseString.ToString().Trim());
    }
    public static (string octalString, string octalMorseString) OctalToMorse(string input)
    {
        var octalMorseString = new StringBuilder();
        var octalString = new StringBuilder();
        foreach (char c in input)
        {
            var octal = Convert.ToString(c, 8).ToUpper();
            octalString.Append(octal + " ");
            foreach (char d in octal)
            {
                octalMorseString.Append(Mapping.morseCodeDictionary[d] + " ");
            }
            octalMorseString.Append(" ");
        }
        return (octalString.ToString().Trim(), octalMorseString.ToString().Trim());
    }
    public static (string hexString, string hexMorseString) HexToMorse(string input)
    {
        var hexMorseString = new StringBuilder();
        var hexString = new StringBuilder();
        foreach (var c in input)
        {
            var hexa = Convert.ToString(c, 16).ToUpper();
            hexString.Append(hexa + " ");
            foreach (char d in hexa)
            {
                hexMorseString.Append(Mapping.morseCodeDictionary[d] + " ");
            }
            hexMorseString.Append(" ");
        }
        
        return (hexString.ToString().Trim(), hexMorseString.ToString().Trim());
    }
}

