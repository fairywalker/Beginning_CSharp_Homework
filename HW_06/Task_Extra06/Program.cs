// Задана целочисленная квадратная матрица размером N x N. Требуется транспонировать ее относительно главной диагонали.
// https://acmp.ru/asp/do/index.asp?main=task&id_course=1&id_section=8&id_topic=120&id_problem=742

Console.Write("Введите размер квадратной матрицы: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] matrix = getMatrix(n);

fillMatrix(matrix);

Console.WriteLine("Исходная матрица");
printMatrix(matrix);

transposeSquareMatrix(matrix);

Console.WriteLine("Транспонированная матрица");
printMatrix(matrix);

int[,] getMatrix(int n)
{
    int[,] matrix = new int[n,n];
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

void transposeSquareMatrix(int[,] matrix)
{
   
   //int temp = 0;

   for (int i = 0; i < matrix.GetLength(0)-1; i++)
    {
        for (int j = i+1; j < matrix.GetLength(1); j++)
        {
            int temp = matrix[i,j];
            matrix[i,j] = matrix[j,i];
            matrix[j,i] = temp;       
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

