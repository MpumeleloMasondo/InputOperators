using System;
using System.Collections.Generic;
using System.Linq;

namespace InputOperators
{
    public class InputOperators
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter text to be analysed");
           
            string input = Console.ReadLine();

            Console.WriteLine(@"Enter which operators to do on the supplied text, ‘1’ for a duplicate character
                                check, ‘2’ to count the number of vowels, ‘3’ to check if there are more vowels or non vowels, or any
                                combination of ‘1’, ‘2’ and ‘3’ to perform multiple checks.");

            string operators = Console.ReadLine();

            DuplicateCheck(input.ToLower().ToCharArray(), operators);
            VowelsCount(input.ToLower().ToCharArray(), operators);
            VowelsCountCompare(input.ToLower(), operators);

            Console.ReadLine();

        }
        
        public static void DuplicateCheck(char[] input, string operators)
        {
            if (operators.Contains("1"))
            {
                string duplicates = string.Empty;
                int count;

                for (int i = 0; i < input.Length; i++)
                {
                    count = 1;
                    for (int j = i + 1; j < input.Length; j++)
                    {
                        if (input[i] == input[j] && input[i] != ' ')
                        {
                            count++;
                            input[j] = '0';
                        }
                    }

                    if (count > 1 && input[i] != '0')
                    {
                        duplicates += input[i];
                    }
                }

                if (!string.IsNullOrEmpty(duplicates))
                    Console.WriteLine($"Found the following duplicates: {duplicates}");
                else
                    Console.WriteLine("No duplicate values were found");

            }
        }

        public static void VowelsCount(char[] input, string operators)
        {
            if (operators.Contains("2"))
            {
                List<char> vowels = new List<char>() { 'a', 'e', 'i', 'o', 'u' };
                string inputVowels = string.Empty;

                for (int i = 0; i < input.Length; i++)
                {
                    if (vowels.Contains(input[i]) && input[i] != ' ' && !inputVowels.Contains(input[i]))
                    {
                        inputVowels += input[i];
                    }
                }

                int total = input.Count(c => vowels.Contains(c));

                if (inputVowels.Length > 0)
                    Console.WriteLine($"The number of vowels is {inputVowels.Length}");
                else
                    Console.WriteLine("No vowels were found");

            }
        }

        public static void VowelsCountCompare(string input, string operators)
        {
            if (operators.Contains("3"))
            {
                string duplicates = string.Empty;
                List<char> vowels = new List<char>() { 'a', 'e', 'i', 'o', 'u' };

                int vowelsTotal = input.Count(c => vowels.Contains(c));
                int nonVowelsTotal = input.Replace(" ", "").Length - vowelsTotal;

                if (vowelsTotal > nonVowelsTotal)
                    Console.WriteLine("The text has more vowels than non vowels");
                else if (vowelsTotal < nonVowelsTotal)
                    Console.WriteLine("The text has more non vowels than vowels");
                else
                    Console.WriteLine("The text has an equal amount of vowels and non vowels");

            }
        }
    }
}
