// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.Write("Введите значение M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Recursia(m, n);

void Recursia(int m, int n, int sum = 0)
{
    sum = sum + m;
    if (m > n)
    {
        return;
    }
    if (m == n)
    {
        Console.WriteLine(sum);
    }
    Recursia(m + 1, n, sum);
}