// Контрольная работа

Console.Write("Введите длину массива: ");
int length = Convert.ToInt32(Console.ReadLine());

string[]? arrayIn = new string[length];
string[]? arrayTemp = new string[length];

for (int i = 0; i < length; i++)
{
    Console.Write("Введите значение элемента " + (i+1) + ": ");
    arrayIn[i] = Console.ReadLine();  
}



int indexOut = 0;

for (int indexIn = 0; indexIn < length; indexIn++)
{
    if (arrayIn[indexIn].Length <= 3)
    {
        arrayTemp[indexOut] = arrayIn[indexIn];
        indexOut++;
    }    
}

string[]? arrayOut = new string[indexOut];

for (int i = 0; i < indexOut; i++)
{
    arrayOut[i] = arrayTemp[i];       
}

Console.Write("Исходный массив: ");
Console.WriteLine("[ " + string.Join(", ", arrayIn) + " ]");
Console.Write("Результат: ");
Console.WriteLine("[ " + string.Join(", ", arrayOut) + " ]");