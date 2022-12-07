Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine()!);

for (int i = 1; i <= N; i++)
{
    double sqr = Math.Pow(i, 3);
    Console.Write(sqr + ", ");
}
Console.WriteLine();
