// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] matrix = getMatrix(m, n);

fillMatrix(matrix);

Console.WriteLine("Заданный массив");
printMatrix(matrix);

double[] result = new double[n];

for (int i = 0; i < matrix.GetLength(1); i++)
{
    int currentSum = 0;
    for (int j = 0; j < matrix.GetLength(0); j++)
    {
        currentSum += matrix[j, i];        
    } 
    result[i] = Math.Round((double)currentSum/m,1);   
}

Console.WriteLine("Средние значения");
Console.WriteLine("[" + string.Join("; ", result) + "]");


int[,] getMatrix(int m, int n)
{
    int[,] matrix = new int[m,n];
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

void printMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j]+" ");        
        } 
        Console.WriteLine();   
    }


}