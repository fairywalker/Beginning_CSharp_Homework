//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

Console.Write("Введите число: ");
int Number = Convert.ToInt32(Console.ReadLine());

int Result = 0;

while (Number != 0)
{
    Result += Number%10;
    Number = Number/10;
    
}

Console.Write("Ответ: ");
Console.Write(Result);