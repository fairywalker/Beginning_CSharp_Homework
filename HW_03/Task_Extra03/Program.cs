//Задана последовательность натуральных чисел, завершающаяся числом 0.
//Требуется определить значение второго по величине элемента в этой последовательности,
//то есть элемента, который будет наибольшим, если из последовательности удалить наибольший элемент.

Console.WriteLine("Введие последовательность чисел. После ввода каждого числа нажимайте Enter.");
Console.WriteLine("Чтобы завершить ввод последовательности, введите 0 (ноль).");

int NewNumber = 1;
int[] Array = new int[100];
int index = 0;
int FirstMax = 0;
int SecondMax = 0;
int ArrayLength = 0;

while (NewNumber != 0)
{
    NewNumber = Convert.ToInt32(Console.ReadLine());
    Array[index] = NewNumber;
    index++;
}

ArrayLength =  index;
index = 0;

while (index < ArrayLength)
{
    FirstMax = Math.Max(FirstMax,Array[index]);
    index++;
}

index = 0;

while (index < ArrayLength)
{
    
    if (Array[index] != FirstMax) SecondMax = Math.Max(SecondMax,Array[index]);
    index++;
        
}

Console.Write("Значение второго по величине элемента: ");
Console.WriteLine(SecondMax);