//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

int[] Array = new int[8];

Console.WriteLine("Введите до восьми чисел, нажамая Enter после каждого.");
//Console.WriteLine("Чтобы завершить ввод раньше, введите 'end'.");
for (int i = 0; i < 8; i++)
{
    string? NewValue = Console.ReadLine();
    //if (NewValue == "end") break;
    Array[i] = Convert.ToInt32(NewValue);
}

Console.WriteLine("[" + string.Join(", ", Array) + "]");