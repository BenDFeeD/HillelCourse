Console.WriteLine("введите число квадрат которого хотите вычеслить");
double s = int.Parse(Console.ReadLine());
s = Math.Pow(s, (double)2);
// s = s * s второй способ
Console.WriteLine("Квадрат вашего числа равен: {0}", s);
Console.ReadKey();