//Задайте массив заполненный случайными положительными трёхзначными числами.
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

Console.Write("Введите длину массива: ");
int Length = Convert.ToInt32(Console.ReadLine());

int[] Array = new int[Length];

for (int i = 0; i < Length; i++)
{
    Array[i] = new Random().Next(100, 1000);  
}

Console.WriteLine("[ " + string.Join(", ", Array) + " ]");

int count = 0;

for (int i = 0; i < Length; i++)
{
    if (Array[i]%2 == 0)
    {
        count++;
    }    
}

Console.Write("Количество четных чисел в массив: ");
Console.WriteLine(count);