using System;
using System.Linq;

namespace StringUtilitiesLib
{
    public class StringUtils
    {
        public static string Reverse(string input)
        {
            if (input == null) return null;
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        public static bool IsPalindrome(string input)
        {
            if (string.IsNullOrEmpty(input)) return false;

            // Clean the input: remove non-alphanumeric characters and make lowercase
            string cleaned = new string(input.Where(char.IsLetterOrDigit).ToArray()).ToLower();

            // Reverse the CLEANED string
            char[] charArray = cleaned.ToCharArray();
            Array.Reverse(charArray);
            string reversed = new string(charArray);

            // Compare the cleaned string with its reversed version
            return cleaned == reversed;
        }

        public static int CountVowels(string input)
        {
            if (string.IsNullOrEmpty(input)) return 0;
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            return input.ToLower().Count(c => vowels.Contains(c));
        }

        public static string SafeTruncate(string input, int maxLength)
        {
            if (string.IsNullOrEmpty(input) || maxLength >= input.Length) return input;
            if (maxLength <= 0) return "";
            return input.Substring(0, maxLength) + "...";
        }
    }
}