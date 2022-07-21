//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты первой точки.");

Console.Write("X: ");
int AX = Convert.ToInt32(Console.ReadLine());

Console.Write("Y: ");
int AY = Convert.ToInt32(Console.ReadLine());

Console.Write("Z: ");
int AZ = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки.");

Console.Write("X: ");
int BX = Convert.ToInt32(Console.ReadLine());

Console.Write("Y: ");
int BY = Convert.ToInt32(Console.ReadLine());

Console.Write("Z: ");
int BZ = Convert.ToInt32(Console.ReadLine());


double D = Math.Sqrt(Math.Pow(BX-AX,2)+Math.Pow(BY-AY,2)+Math.Pow(BZ-AZ,2));

Console.Write("Расстояние: ");
Console.WriteLine(Math.Round(D,2));