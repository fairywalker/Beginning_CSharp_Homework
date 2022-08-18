// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// массив размером 2 x 2 x 2
// 12(0,0,0) 22(0,0,1)
// 45(1,0,0) 53(1,0,1)

Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество рядов: ");
int z = Convert.ToInt32(Console.ReadLine());

int[,,] matrix = getMatrix(m, n, z);

fillMatrix(matrix);

printMatrix(matrix, "Элементы массива: ");

int[,,] getMatrix(int m, int n, int z)
{
    
    int[,,] matrix = new int[m,n,z];

    return matrix;
}

void fillMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int y = 0; y < matrix.GetLength(2); y++)
            {
                matrix[i,j,y] = new Random().Next(0, 10);    
            }
                    
        }    
    }
}

void printMatrix(int[,,] matrix, string text)
{
    
    if (text != string.Empty) Console.WriteLine(text);

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int y = 0; y < matrix.GetLength(2); y++)
            {
                Console.WriteLine(matrix[i, j, y] + " (" + i + ", " + j + ", " + y + ")");    
            }
                    
        }  
    }

}

