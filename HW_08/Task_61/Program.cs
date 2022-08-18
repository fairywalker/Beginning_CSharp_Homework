// Вывести первые N строк треугольника Паскаля. Сделать вывод в виде равнобедренного треугольника

Console.Write("Введите количество строк: ");
int n = Convert.ToInt32(Console.ReadLine());


int[,] matrix = getMatrix(n, n);

//расчет треугольника
matrix[0,0] = 1;

int maxNumber = 1;

for (int i = 0; i < n; i++)
{
     matrix[i,0] = 1;
     matrix[i,i] = 1; 
    
     for (int j = 1; j < i; j++)
    {
        matrix[i,j] = matrix[i-1,j-1] + matrix[i-1,j];
        maxNumber = Math.Max(maxNumber, matrix[i,j]);
    
    }

}


//вывод треугольника
int cellLength = GetNumberLength(maxNumber);

string emptySymbol = " ";
string emptyCell = string.Empty;
for (int i = 0; i < cellLength; i++)
{
    emptyCell = emptyCell + emptySymbol;           
}


for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(0)-i; j++)
    {
        Console.Write(emptyCell);   
    }
    
    for (int j = 0; j <= i; j++)
    {
        Console.Write(AddFullLengthOfCell(matrix[i,j], cellLength, emptySymbol)); 
        Console.Write(emptyCell);   
    }
    Console.WriteLine();
}

int[,] getMatrix(int m, int n)
{
    
    int[,] matrix = new int[m,n];

    return matrix;
}

int GetNumberLength(int num)
{
    string stringNum = Convert.ToString(num);

    int length = stringNum.Length;

    Console.WriteLine(length);

    return length;
}

string AddFullLengthOfCell(int num, int cellLength, string emptySymbol)
{
    string stringNum = Convert.ToString(num);
    for (int i = stringNum.Length+1; i <= cellLength; i++) stringNum = stringNum + emptySymbol;
    return stringNum;
}