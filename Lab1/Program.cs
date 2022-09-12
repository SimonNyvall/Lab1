using System.Runtime.InteropServices;
using System;
using System.Text;

namespace Lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string input = "29535123p48723487597645723645";      
            if (string.IsNullOrEmpty(input)) return;
            
            ulong substringSum = 0;

            for (int startIndex = 0; startIndex < input.Length; startIndex++)
            {
                int endIndex = GetNextIndexForMachingNumber(input, startIndex);
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
        static int GetNextIndexForMachingNumber(string input, int startIndex)
        {
            return input.IndexOf(input[startIndex], startIndex + 1);
        }

        static string GetSubstringFromStartToEndIndex(string input, int start, int end)
        {
            return input.Substring(start, end - start + 1);
        }

        static bool DoesStringOnlyContainNumbers(string outputSubstring)
        {
            if (outputSubstring.All(c => char.IsDigit(c))) return true;
            return false;        
        }

        static void PrintColoredSubstring(string input, int start, int length)
        {           
            Console.Write(input.Substring(0, start));
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(input.Substring(start, length));
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(input.Substring(start + length));
        }
    }
}