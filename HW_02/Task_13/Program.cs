//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.Write("Введите число: ");
int Number = Convert.ToInt32(Console.ReadLine());

if(Number<100)
{
    Console.WriteLine("третьей цифры нет");
}
else
{
    Console.WriteLine(Number%10);
}