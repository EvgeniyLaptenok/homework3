Console.WriteLine("Введите пятизначное число: ");
int number = int.Parse(Console.ReadLine()!);
int num = Math.Abs(number);
int firstPair = num / 10000 + ((num / 1000) % 10 * 10);
int secondPair = num % 100;

if (num >= 100000 || num <= 9999)
{
    Console.WriteLine("Неверное число");
}
else
{
    if (firstPair == secondPair)
    {
        Console.WriteLine("Палидром");
    }
    else
    {
        Console.WriteLine("Не палидром");
    }
}
