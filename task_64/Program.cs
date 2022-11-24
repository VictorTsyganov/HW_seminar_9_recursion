// Решаем все задачи через рекурсию!
// Задача 64: Задайте значение N. Напишите программу, которая выведет все чётные числа в промежутке от N до 1.
// N = 5 -> "4, 2"
// N = 8 -> "8, 6, 4, 2"

Console.Clear();

Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine());

GetNumbers(n);

void GetNumbers(int n)
{
    if (n % 2 != 0) n--;
    {
        if (n == 2) Console.Write($"{n}");
        else
        {
            Console.Write($"{n}, ");
            GetNumbers(n - 2);
        }
    }
}