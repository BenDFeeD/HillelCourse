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
    int numberOfDay = ReadNumberFromConsole("Введите число от 1 до 7:");
    string day;
    switch (numberOfDay)
    {
        case 1:
            day = "Понедельник";
            break;
        case 2:
            day = "Вторник";
            break;
        case 3:
            day = "Среда";
            break;
        case 4:
            day = "Четверг";
            break;
        case 5:
            day = "Пятница";
            break;
        case 6:
            day = "Суббота";
            break;
        case 7:
            day = "Воскресенье";
            break;
        default:
            day = "Вы ввели число больше 7, либо меньше 1. Попробуйте еще раз.";
            break;
    }
    Console.WriteLine(day);
}