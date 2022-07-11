//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

Console.Write("Введите первое число: ");
int NumberA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int NumberB = Convert.ToInt32(Console.ReadLine());

if(NumberA>NumberB)
{
    Console.Write("Большее: ");
    Console.WriteLine(NumberA);
    Console.Write("Меньшее: ");
    Console.WriteLine(NumberB);
}

if(NumberA<NumberB)
{
    Console.Write("Большее: ");
    Console.WriteLine(NumberB);
    Console.Write("Меньшее: ");
    Console.WriteLine(NumberA);
}

if(NumberA==NumberB)
{
    Console.Write("Числа равны");
}