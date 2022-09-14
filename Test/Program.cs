// Контрольная работа

Console.Write("Введите длину массива: ");
int length = Convert.ToInt32(Console.ReadLine());

string[] arrayIn = new string[length];

for (int i = 0; i < length; i++)
{
    Console.Write("Введите значение элемента " + i+1 + ": ");
    arrayIn[i] = Console.ReadLine();  
}

