// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, заданы 2 массива:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// и
// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7
// Их произведение будет равно следующему массиву:
// 1 20 56 10
// 20 81 8 6
// 56 8 4 24
// 10 6 24 49

Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] matrixA = getMatrix(m, n);
fillMatrix(matrixA);
printMatrix(matrixA, "Заданный массив А");

int[,] matrixB = getMatrix(m, n);
fillMatrix(matrixB);
printMatrix(matrixB, "Заданный массив Б");


int[,] matrixResult = getMatrix(m, n);

for (int i = 0; i < matrixResult.GetLength(0); i++)
{
    for (int j = 0; j < matrixResult.GetLength(1); j++)
    {
        matrixResult[i,j] = matrixA[i,j] * matrixB[i,j];   
    }           
}

printMatrix(matrixResult, "Результа умножения значений");



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

