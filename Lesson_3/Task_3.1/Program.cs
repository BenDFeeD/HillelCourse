int ReadNumberFromConsole(string message)
{
    Console.WriteLine(message);
    string input = Console.ReadLine();
    bool resParse = int.TryParse(input, out int result);
    if (!resParse)
    {
        Console.WriteLine("Error");
        return 0;
    }
    return result;
}

while (true)
{

    int num = ReadNumberFromConsole("Enter your number:");
    if ((num % 2) == 0)
    {
        Console.WriteLine("Your number is even \n");
    }
    else
    {
        Console.WriteLine("Your number is odd \n");
    }
}