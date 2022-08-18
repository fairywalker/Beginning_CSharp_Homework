// Заполните спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 1 2 3 4
// 2 3 4 5
// 1 6 5 6
// 1 9 8 7

Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] matrix = getMatrix(m, n);

int row = 0;
int col = 0;

FillMatrix(matrix, row, col);

int[,] getMatrix(int m, int n)
{    
    int[,] matrix = new int[m,n];

    return matrix;
}

void FillMatrix(int[,] matrix, int row, int col)
{   
    bool outOfRange = false;
    
    if (row < 0 || col < 0 || row >= matrix.GetLength(0) || col >= matrix.GetLength(1)) outOfRange = true;
   
    if (outOfRange == false && matrix[row, col] == 0)
    {
        matrix[row, col] = new Random().Next(1, 10); 
        printMatrix(matrix, "row: " + (row+1) + ", col: " + (col+1));
        FillMatrix(matrix, row, col+1);
        FillMatrix(matrix, row+1, col);
        FillMatrix(matrix, row, col-1);
        FillMatrix(matrix, row-1, col);
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