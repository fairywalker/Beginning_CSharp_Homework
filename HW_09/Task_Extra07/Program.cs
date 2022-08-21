// Дана строка, состоящая из N попарно различных символов. Требуется вывести все перестановки символов данной строки.
 

Console.Write("Введите символы для перестановки: ");
string? combiningString = Console.ReadLine();

if (combiningString != null)
{
    bool[] usedChairs = new bool[combiningString.Length];

    NetxConbination(combiningString, new char[combiningString.Length], 0, usedChairs);
}


void NetxConbination(string combiningString, char[] combination, int length, bool[] usedChairs)
{
    if (length == combination.Length)
    {
        Console.WriteLine(new String(combination));

        return;
    }

    for (int i = 0; i < combiningString.Length; i++)
    { 
         if (usedChairs[i] != true)
        {
            combination[length] = combiningString[i];
            usedChairs[i] = true;

            NetxConbination(combiningString, combination, length + 1, usedChairs);

            usedChairs[i] = false;
        }
    }
}