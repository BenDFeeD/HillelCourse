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
    int firstNum = ReadNumberFromConsole("Введите первое число: ");
    int secondNum = ReadNumberFromConsole("Введите первое число: ");

    if (firstNum == secondNum)
        Console.WriteLine("\nРезультат: Ваши числа равны \n");
    else if (secondNum > firstNum)
    {
        Console.WriteLine($"\nРезультат: {secondNum} > {firstNum}\nЧисло {secondNum} больше");
    }
    else if (secondNum < firstNum)
    {
        Console.WriteLine($"\nРезультат: {firstNum} > {secondNum} \nЧисло {firstNum} больше");
    }
}