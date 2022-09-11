{
    const string input = "29535123p48723487597645723645";
    if (string.IsNullOrEmpty(input)) return;

    var startAndEndIndexOfSubStrings = new List<(int startIndex, int endIndex)>();

    ulong sumOfSubstrings = 0;

    string outputSubstring;

    for (int currentIndexOfInput = 0; currentIndexOfInput < input.Length; currentIndexOfInput++)
    {
        outputSubstring = ReturnSubstringWithSameBeginingAndEndNumber(input, currentIndexOfInput);

        if (DoesStringOnlyContainNumbers(outputSubstring))
        {
            sumOfSubstrings += ulong.Parse(outputSubstring);
            startAndEndIndexOfSubStrings.Add((startIndex: currentIndexOfInput, endIndex: currentIndexOfInput + outputSubstring.Length));
        }
    }

    WriteAmoutOfSulutionsWithColor(startAndEndIndexOfSubStrings, input);

    Console.WriteLine($"\nThe sum is: {sumOfSubstrings}");
}

string ReturnSubstringWithSameBeginingAndEndNumber(string input, int startIndex)
{
    string substringOfInput = String.Empty;
    string numberOfStartIndex = input[startIndex].ToString();

    for (int currentIndex = startIndex; currentIndex < input.Length - 1; currentIndex++)
    {
        if (numberOfStartIndex != input[currentIndex + 1].ToString())
        {
            substringOfInput += input[currentIndex].ToString();
        }
        else
        {            
            substringOfInput += input[currentIndex];
            substringOfInput += input[currentIndex + 1];
            break;
        }
    }

    if (!string.IsNullOrEmpty(substringOfInput))
    {
        if (substringOfInput.Length == 1) 
            return String.Empty;
        if (substringOfInput[0] != substringOfInput[substringOfInput.Length - 1])     
            return String.Empty;
    }

    return substringOfInput;
}


bool DoesStringOnlyContainNumbers(string outputSubstring)
{
    if (string.IsNullOrEmpty(outputSubstring)) return false;

    foreach (var charecter in outputSubstring)
    {
        if (!(int.TryParse(charecter.ToString(), out int number))) return false;
    }

    return true;
}


void WriteAmoutOfSulutionsWithColor(List<(int startIndex, int endIndex)> startAndEndIndexOfSubStrings, string input)
{
    for (int indexOfList = 0; indexOfList < startAndEndIndexOfSubStrings.Count; indexOfList++)
    {
        for (int indexOfInput = 0; indexOfInput < input.Length; indexOfInput++)
        {
            if (indexOfInput >= startAndEndIndexOfSubStrings[indexOfList].startIndex &&
                indexOfInput < startAndEndIndexOfSubStrings[indexOfList].endIndex)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(input[indexOfInput]);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(input[indexOfInput]);
            }
        }
        Console.WriteLine();
    }

    Console.ForegroundColor = ConsoleColor.White;
}