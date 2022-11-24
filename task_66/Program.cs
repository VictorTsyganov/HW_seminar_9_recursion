// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();

Console.Write("Введите число M: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine());

Console.Write($"{SumNumbers(m, n)} ");

int SumNumbers(int m, int n)
{
    if (m == n) return n;
    else return m + SumNumbers(m + 1, n);
}