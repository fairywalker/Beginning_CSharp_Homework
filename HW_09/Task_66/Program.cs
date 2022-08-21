// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

int result = 0;
result = AddNextNumber(m, n, result);

Console.WriteLine("Сумма чисел: " + result);


int AddNextNumber(int m, int n, int result)
{
    if (m > n) return result;

    result += m;

    result = AddNextNumber(m+1, n, result);

    return result;
}