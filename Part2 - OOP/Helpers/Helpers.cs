using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part2___OOP.Helpers
{
    public class Helpers
    {
        static public string EnumsToString<T>(string divider = " ")
        {
            return string.Join(divider, Enum.GetNames(typeof(T)));
        }

        static public string ToUpperCamelCase(string sentence)
        {
            if (string.IsNullOrEmpty(sentence))
                return string.Empty;

            TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
            string[] words = sentence.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < words.Length; i++)
            {
                // Capitalize the first letter and make the rest of the word lowercase
                words[i] = textInfo.ToTitleCase(words[i].ToLower());
            }

            // Concatenate the words back into a single string
            return string.Join(string.Empty, words);
        }
    }
}
