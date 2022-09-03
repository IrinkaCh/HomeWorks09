// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

Console.Write("Введите значение M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
string result = Recursia(n, m).ToString();
Console.WriteLine(result);

int Recursia(int n, int m)
{
    if (n == 0)
    {
        return m + 1;
    }
    else
    {
        if (m == 0)
        {
            return Recursia(n - 1, 1);
        }
        else { return Recursia(n - 1, Recursia(n, m - 1)); }
    }
}