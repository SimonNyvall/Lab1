
string input = "29535123p48723487597645723645";

var output = new List<(string outputString, int startingIndex, int endingIndex)>();

ulong sum = 0;

for (int i = 0; i < input.Length; i++)
{
    string numberString = findNumber(input, i);

    if (isNumberVaild(numberString) && numberString != "")
    {
        sum += ulong.Parse(numberString);
        output.Add((outputString: numberString, startingIndex: i, endingIndex: i + numberString.Length));
    }

}

for (int i = 0; i < output.Count; i++)
{
    for (int j = 0; j < input.Length; j++)
    {
        if (j >= output[i].startingIndex && j < output[i].endingIndex)
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
Console.WriteLine($"\n {sum}");

bool isNumberVaild(string subStringOfInput)
{

    for (int i = 0; i < subStringOfInput.Length; i++)
    {
        bool prestateRetuen = int.TryParse(subStringOfInput[i].ToString(), out int b);

        if (prestateRetuen == false)
        {
            return false;
        }
    }

    return true;

}

string findNumber(string input, int start)
{
    string returnString = "";
    string compare = input[start].ToString();
    for (int i = start; i < input.Length - 1; i++)
    {
        if (compare != input[i + 1].ToString())
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
    if (returnString != "")
    {
        if (returnString[0] != returnString[returnString.Length - 1] || 1 == returnString.Length)
        {
            return "";
        }
    }

    return returnString;
}