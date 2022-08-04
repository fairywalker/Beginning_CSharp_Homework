//Сбор черники
//https://acmp.ru/asp/do/index.asp?main=task&id_course=1&id_section=5&id_topic=113&id_problem=695

Console.Write("Введие количество кустов: ");
int Bushes = Convert.ToInt32(Console.ReadLine());

int[] Array = new int[Bushes];
int Result = 0;
int Current = 0;
int iPrev;
int iNext;


Console.WriteLine("Последовательно введие количество ягод на каждом кусте. После ввода каждого числа нажимайте Enter.");

for (int i = 0; i < Bushes; i++)
{
    Array[i] = Convert.ToInt32(Console.ReadLine());
}

for (int i = 0; i < Bushes; i++)
{
    iPrev = i-1;
    iNext = i+1;
    if (i == 0) iPrev = Bushes-1;
    if (i == Bushes-1) iNext = 0;

    Current = Array[iPrev] + Array[i] + Array[iNext];
    Result = Math.Max(Result, Current);

}



Console.Write("Максимальное количество ягод: ");
Console.Write(Result);
