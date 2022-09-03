// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

Console.Write("Введите значение M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Recursia(n, m);

void Recursia(int n, int m)
{
    if (m > n) return;
    Console.Write($"{m} ");
    Recursia(n, m + 1);
}