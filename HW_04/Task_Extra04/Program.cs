//Элемент последовательности называется локальным максимумом,
//если он строго больше предыдущего и последующего элемента последовательности.
//Первый и последний элемент последовательности не являются локальными максимумами.
//Задана последовательность натуральных чисел, завершающаяся числом 0.
//Требуется определить наименьшее расстояние между двумя локальными максимумами последовательности натуральных чисел,
//завершающейся числом 0.

Console.WriteLine("Введие последовательность чисел. После ввода каждого числа нажимайте Enter.");
Console.WriteLine("Чтобы завершить ввод последовательности, введите 0 (ноль).");

int NewNumber = 1;
int[] Array = new int[100];
int index = 0;
int ArrayLength = 0;
int MaxIndex = -1;
int Result = 999;

while (NewNumber != 0)
{
    NewNumber = Convert.ToInt32(Console.ReadLine());
    Array[index] = NewNumber;
    index++;
}

ArrayLength =  index;

index = 1;

while (index < ArrayLength-1)
{
    if (Array[index] > Array[index-1] && Array[index] > Array[index+1])
    {
        if (MaxIndex != -1) Result = Math.Min(Result, index-MaxIndex);
        MaxIndex = index;
    }
    index++;
}

if (Result == 999) Result = 0;

Console.Write("Наименьшее расстояние: ");
Console.Write(Result);
