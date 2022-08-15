// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] matrix = getMatrix(m, n);

fillMatrix(matrix);

printMatrix(matrix);

Console.Write("Введите номер строки: ");
int i = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите номер колонки: ");
int j = Convert.ToInt32(Console.ReadLine());

if (i > matrix.GetLength(0) || j > matrix.GetLength(1) || i == 0 || j == 0)
    Console.WriteLine("Значение за границами массива");
else
    Console.WriteLine("Искомое значение: " + matrix[i-1, j-1]);   



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