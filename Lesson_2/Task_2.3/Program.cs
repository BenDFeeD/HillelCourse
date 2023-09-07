Console.WriteLine("введите число от 100 до 999");
int s = int.Parse(Console.ReadLine());
if (100 <= s & s <= 999)
{
    string a = s.ToString();
    Console.WriteLine("ваше число теперь имеет такой вид: {0}{1}{2}", a[1], a[0], a[2]);
    Console.ReadLine();
}
Console.WriteLine("Вы ввели не трехзначное число");