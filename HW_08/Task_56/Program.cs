// Задача 56: Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] matrix = getMatrix();

int result = 0;

for (int i = 1; i < matrix.GetLength(0); i++)
{
    
    if (GetSumOfRow(matrix, i) < GetSumOfRow(matrix, result)) result = i;  
        
}

Console.Write("Номер строки с наименьшей суммой элементов: " + (result+1));


int GetSumOfRow(int[,] matrix, int row)
{
    int currentSum = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        currentSum += matrix[row,j];    
    } 
    return currentSum;
}

int[,] getMatrix()
{
    
    Console.Write("Введите количество строк: ");
    int m = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите количество столбцов: ");
    int n = Convert.ToInt32(Console.ReadLine());

    int[,] matrix = new int[m,n];

    fillMatrix(matrix);

    printMatrix(matrix, "Заданный массив");

    return matrix;
}

void fillMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(0, 10);        
        }    
    }
}

void printMatrix(int[,] matrix, string text)
{
    
    if (text != string.Empty) Console.WriteLine(text);

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j]+" ");        
        } 
        Console.WriteLine();   
    }

}
