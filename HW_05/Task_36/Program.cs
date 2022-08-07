//Задайте одномерный массив, заполненный случайными числами.
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

Console.Write("Введите длину массива: ");
int Length = Convert.ToInt32(Console.ReadLine());

int[] Array = new int[Length];

for (int i = 0; i < Length; i++)
{
    Array[i] = new Random().Next(-100, 100);  
}

Console.WriteLine("[ " + string.Join(", ", Array) + " ]");

int result = 0;

int j = 1;

while (j < Length)
{
    result += Array[j];
    j += 2;

}

Console.Write("Сумма элементов, стоящих на нечётных позициях: ");
Console.WriteLine(result);