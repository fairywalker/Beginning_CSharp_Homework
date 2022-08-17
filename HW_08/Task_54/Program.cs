// Задайте двумерный массив.
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 1 2 4 7
// 2 3 5 9
// 2 4 4 8


int[,] matrix = getMatrix();

for (int i = 0; i < matrix.GetLength(0); i++)
{
    sortRow(matrix, i);    
}

printMatrix(matrix, "Отсортированный массив");


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

void sortRow(int[,] matrix, int rowNumber)
{

    int temp;
    for (int i = 0; i < matrix.GetLength(1) - 1; i++)
    {
        for (int j = i + 1; j < matrix.GetLength(1); j++)
        {
            if (matrix[rowNumber, i] > matrix[rowNumber, j])
            {
                temp = matrix[rowNumber,i];
                matrix[rowNumber, i] = matrix[rowNumber, j];
                matrix[rowNumber, j] = temp;
            }
        }
    }


}