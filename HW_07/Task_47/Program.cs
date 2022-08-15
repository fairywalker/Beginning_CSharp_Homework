// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] matrix = getDoubleMatrix(m,n);

fillDoubleMatrix(matrix);
printMatrix(matrix);




double[,] getDoubleMatrix(int m, int n)
{
    double[,] matrix = new double[m,n];
    return matrix;
}

void fillDoubleMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            double Num = new Random().Next(-99, 100);
            matrix[i,j] = Num/10;        
        }    
    }
}

void printMatrix(double[,] matrix)
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