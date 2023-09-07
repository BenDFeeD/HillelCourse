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
    double FirstNum = ReadNumberFromConsole("Введите первое число: ");
    double SecondNum = ReadNumberFromConsole("Введите первое число: ");

    if (FirstNum == SecondNum)
        Console.WriteLine("\nРезультат: Ваши числа равны \n");
    else if (SecondNum >= FirstNum)
    {
        Console.WriteLine($"\nРезультат: {SecondNum} > {FirstNum}\nЧисло {SecondNum} больше");
    }
    else if (SecondNum <= FirstNum)
    {
        Console.WriteLine($"\nРезультат: {FirstNum} > {SecondNum} \nЧисло {FirstNum} больше");
    }
}