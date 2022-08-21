// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 3, n = 2 -> A(m,n) = 29


Console.Write("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());

int result = 0;
result = A(m, n);

Console.WriteLine("Результат: " + result);


int A(int m, int n)
{
    if (m == 0) return n + 1;
    
    if (n == 0) return A(m-1, 1); 
    
    return A(m-1, A(m, n-1));

}