// Задача 65: Задайте значения M и N. 
// Напишите программу, которая выведет все 
// натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

Console.Write("Введи N: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи M: ");
int M = Convert.ToInt32(Console.ReadLine());
string naturalNum(int N, int M)
{
    if (N < M)
    {
        for (int i = N; i <= M; i++)
        Console.Write($" {i}");
        return string.Empty;
    }
    else
    {
        for (int i = M; i <= N; i++)
        Console.Write($" {i}");
        return string.Empty;
    }
}
Console.WriteLine(naturalNum(N, M));