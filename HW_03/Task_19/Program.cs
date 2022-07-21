//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

Console.Write("Введите пятизначное число: ");
string Number = Console.ReadLine();

if (Number[0] == Number[4] && Number[1] == Number[3]) Console.WriteLine("да");    

else Console.WriteLine("нет");  
