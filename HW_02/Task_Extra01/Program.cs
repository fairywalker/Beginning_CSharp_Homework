//Вклад в банке составляет X рублей. Ежегодно он увеличивается на P процентов,
//после чего дробная часть копеек отбрасывается.
//Требуется определить: через сколько лет вклад составит не менее Y рублей.

Console.Write("Введите размер вклада: ");
double X = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество процентов: ");
int P = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите цель: ");
int Y = Convert.ToInt32(Console.ReadLine());

int result = 0;

while (X < Y)
{
    result++;
    X = X/100*(100+P);
}

Console.Write("Результат: " + Convert.ToString(result));