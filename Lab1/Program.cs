
string input = "29535123p48723487597645723645";

var outputs = new List<(int startIndex, int endIndex)>();

ulong sumOfOutput = 0;


for (int i = 0; i < input.Length; i++)
{
    string outputString = FindSequence(input, i);

    if (IsStringNumber(outputString))
    {
        sumOfOutput += ulong.Parse(outputString);
        outputs.Add((startIndex: i, endIndex: i + outputString.Length));
    }

}

PrintOutput();


string FindSequence(string input, int startIndex)
{
    string returnString = String.Empty;
    string numberOfStartIndex = input[startIndex].ToString();

    for (int i = startIndex; i < input.Length - 1; i++)
    {
        if (numberOfStartIndex != input[i + 1].ToString())
        {
            returnString += input[i].ToString();
        }
        else
        {
            returnString += input[i];
            returnString += input[i + 1];
            break;
        }
    }

    if (returnString != String.Empty)
    {
        if (returnString[0] != returnString[returnString.Length - 1] || returnString.Length == 1)
        {
            return String.Empty;
        }
    }

    return returnString;
}


bool IsStringNumber(string outputString)
{
    if (outputString == String.Empty)
    {
        return false;
    }

    for (int i = 0; i < outputString.Length; i++)
    {        
        if (!(int.TryParse(outputString[i].ToString(), out int number)))
        {
            return false;
        }
    }

    return true;
}


void PrintOutput()
{
    for (int i = 0; i < outputs.Count; i++)
    {
        for (int j = 0; j < input.Length; j++)
        {
            if (j >= outputs[i].startIndex && j < outputs[i].endIndex)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(input[j]);
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.Write(input[j]);
            }
        }
        Console.WriteLine();
    }
    Console.WriteLine($"\nThe sum is: {sumOfOutput}");
}
