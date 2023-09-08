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
    if (1 <= num & num <= 100)
    {
        if ((num % 3 == 0) & (num % 5 != 0) & (num % 15 != 0))
        {
            Console.WriteLine("Fizz");
        }
        else if ((num % 5 == 0) & (num % 15 != 0) & (num % 3 != 0))
        {
            Console.WriteLine("Buzz");
        }
        else if (num % 15 == 0)
        {
            Console.WriteLine("FizzBuzz");
        }
        else
        {
            Console.WriteLine("Your number is not multiple 3, 5, 15");
        }
    }
    else
    {
        Console.WriteLine("Your number is bigger than 100, or less 1. Try again.");
    }
}