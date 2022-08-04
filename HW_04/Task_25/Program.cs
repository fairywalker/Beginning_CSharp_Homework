//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

Console.Write("Введите число: ");
double Number = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите степень: ");
double Power = Convert.ToDouble(Console.ReadLine());


double Result = Math.Pow(Number, Power);

Console.Write("Ответ: ");
Console.Write(Result);