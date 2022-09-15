using System.Runtime.InteropServices;
using System;
using System.Text;
using System.Security.Cryptography.X509Certificates;

namespace FindNumberSequences
{
    public class Lab
    {
        public static void Main(string[] args)
        {
            const string input = "29535123p48723487597645723645";
            if (string.IsNullOrEmpty(input)) return;
            
            ulong substringSum = 0;

            for (int startIndex = 0; startIndex < input.Length; startIndex++)
            {
                int endIndex = GetNextIndexForMachingDigit(input, startIndex);
                if (endIndex > 0)
                {
                    string outputSubstring = GetSubstringFromStartToEndIndex(input, startIndex, endIndex);

                    if (DoesStringOnlyContainNumbers(outputSubstring))
                    {
                        substringSum += ulong.Parse(outputSubstring);

                        PrintColoredSubstring(input, startIndex, outputSubstring.Length);
                    }
                }
            }
            Console.WriteLine($"\nThe sum is: {substringSum}");
        }
        public static int GetNextIndexForMachingDigit(string input, int startIndex)
        {
            if (string.IsNullOrEmpty(input)) return -1;
            if (startIndex < 0 || startIndex > input.Length) return -1;
            
            return input.IndexOf(input[startIndex], startIndex + 1);
        }

        public static string GetSubstringFromStartToEndIndex(string input, int start, int end)
        {
            if (string.IsNullOrEmpty(input)) throw new ArgumentException("Empty or null", "input");
            if (start < 0 || end >= input.Length) throw new ArgumentException("Indeces was outside the length of input");
            
            return input.Substring(start, end - start + 1);
        }

        public static bool DoesStringOnlyContainNumbers(string outputSubstring)
        {
            if (string.IsNullOrEmpty(outputSubstring)) return false;

            return outputSubstring.All(c => char.IsDigit(c));          
        }

        private static void PrintColoredSubstring(string input, int start, int length)
        {           
            Console.Write(input.Substring(0, start));
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(input.Substring(start, length));
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(input.Substring(start + length));
        }
    }
}