using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SimpleStringExecrises
{
    static class SimpleStringRealization
    {
        /// <summary>
        /// Return string in reverse format
        /// </summary>
        /// <param name="input">what to reverse<param>
        /// <returns>reversed string</returns>
        public static string Reverse(string input)
        {
            string result = string.Empty;
            for (int i = 0; i < input.Length; i++)
            {
                result += input.Substring(input.Length - i - 1, 1);
            }
            return result;
        }

        /// <summary>
        /// Capitalize words in line
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string Capitalize(string input)
        {
            var words = input.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < words.Length; i++)
                words[i] = char.ToUpper(words[i][0]) + words[i].Substring(1);
            return string.Join(" ", words);
        }

        public static bool IsPalindrom(string input)
        {
            Regex regex = new Regex(@"[\W]");
            input = regex.Replace(input, "");
            input = input.ToLower();
            /*for (int i = 0; i < input.Length/2; i++)
            {
                if (input[i] != input[input.Length - i - 1])
                {
					return false;
                }
            }
			return true;*/
            return input == Reverse(input);
        }

        /// <summary>
        /// return longest common substring
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns></returns>
        public static string LongestCommonSubstring(string first, string second)
        {
            int n = first.Length, m = second.Length;
            int[,] matrix = new int[n, m];
            int maxI = 0;
            int lenLongest = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (first[i] == second[j])
                    {
                        matrix[i, j] = (i == 0 || j == 0)
                            ? 1
                            : matrix[i - 1, j - 1] + 1;
                        if (matrix[i, j] > lenLongest)
                        {
                            lenLongest = matrix[i, j];
                            maxI = i;
                        }
                    }
                }
            }
            return first.Substring(maxI + 1 - lenLongest, lenLongest);
        }

    }
}
