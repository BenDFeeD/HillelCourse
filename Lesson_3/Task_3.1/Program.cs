double ReadNumberFromConsole(string message)
{
    Console.WriteLine(message);
    string input = Console.ReadLine();
    bool resParse = double.TryParse(input, out double result);
    if (!resParse)
    {
        Console.WriteLine("Error");
        return 0;
    }
    return result;
}

while (true)
{

    double num = ReadNumberFromConsole("Enter your number:");
    if ((num % 2) == 0)
    {
        Console.WriteLine("Your number is even \n");
    }
    else
    {
        Console.WriteLine("Your number is odd \n");
    }
}