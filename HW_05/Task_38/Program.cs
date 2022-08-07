//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76


Console.Write("Введите длину массива: ");
int Length = Convert.ToInt32(Console.ReadLine());

double[] Array = new double[Length];

for (int i = 0; i < Length; i++)
{
    Array[i] = new Random().Next(-100, 100);  
}

Console.WriteLine("[ " + string.Join(", ", Array) + " ]");

double max = Array[0];
double min = Array[0];

for (int i = 1; i < Length; i++)
{
    max = Math.Max(max, Array[i]);    
    min = Math.Min(min, Array[i]);    
}

Console.Write("Разница между максимальным и минимальным элементов массива: ");
Console.WriteLine(max - min);