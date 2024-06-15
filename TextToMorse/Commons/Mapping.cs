using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextToMorse.Commons
{
    public class Mapping
    {
        public static Dictionary<char, string> morseCodeDictionary = new Dictionary<char, string>
        {
            { 'A', ".-" }, { 'B', "-..." }, { 'C', "-.-." },
            { 'D', "-.." }, { 'E', "." }, { 'F', "..-." },
            { 'G', "--." }, { 'H', "...." }, { 'I', ".." },
            { 'J', ".---" }, { 'K', "-.-" }, { 'L', ".-.." },
            { 'M', "--" }, { 'N', "-." }, { 'O', "---" },
            { 'P', ".--." }, { 'Q', "--.-" }, { 'R', ".-." },
            { 'S', "..." }, { 'T', "-" }, { 'U', "..-" },
            { 'V', "...-" }, { 'W', ".--" }, { 'X', "-..-" },
            { 'Y', "-.--" }, { 'Z', "--.." },
            { '0', "-----" }, { '1', ".----" }, { '2', "..---" },
            { '3', "...--" }, { '4', "....-" }, { '5', "....." },
            { '6', "-...." }, { '7', "--..." }, { '8', "---.." },
            { '9', "----." }
        };
        public static Dictionary<char, string> binaryMorseDictionary = new Dictionary<char, string>
        {
            { '0', "-----" },
            { '1', ".----" }
        };
    }
}
