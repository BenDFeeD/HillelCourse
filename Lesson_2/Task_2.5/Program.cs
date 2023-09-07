// Собственно решения из своей головы я не нашел, поэтому полез в интернет, благодаря чему узнал о таком методе
int x, y;
Console.WriteLine("Введите число x");
x = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число y");
y = int.Parse(Console.ReadLine());
(x, y) = (y, x);
Console.WriteLine($"Теперь x={x}, y={y}");