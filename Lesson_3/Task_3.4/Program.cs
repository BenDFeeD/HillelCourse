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
    int numberOfMonth = ReadNumberFromConsole("Введите число от 1 до 12:");
    string month;
    switch (numberOfMonth)
    {
        case 12:
        case 1:
        case 2:
            month = "Зима";
            break;
        case 3:
        case 4:
        case 5:
            month = "Весна";
            break;
        case 6:
        case 7:
        case 8:
            month = "Лето";
            break;
        case 9:
        case 10:
        case 11:
            month = "Осень";
            break;
        default:
            month = "Вы ввели число больше 12, либо меньше 1. Попробуйте еще раз.";
            break;
    }
    Console.WriteLine($"{month}\n");
}