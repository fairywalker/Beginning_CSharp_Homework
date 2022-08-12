//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 4

Console.Write("Введие количество чисел: ");
int m = Convert.ToInt32(Console.ReadLine());

double[] array = new double[m];
int result = 0;

Console.WriteLine("Последовательно введие числа. После ввода каждого числа нажимайте Enter.");

for (int i = 0; i < m; i++)
{
    array[i] = Convert.ToDouble(Console.ReadLine());
}

for (int i = 0; i < m; i++)
{
    if (array[i]>0) result++;

}

Console.Write("Количество чисел больше нуля: ");
Console.Write(result);
