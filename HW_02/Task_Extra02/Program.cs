//В первый день спортсмен пробежал X километров.
//В каждый последующий день он увеличивал пробег на 15% от предыдущего дня.
//По данному числу Y требуется определить номер дня, в который пробег спортсмена составил не менее Y километров.

Console.Write("Расстояние в первый день: ");
double X = Convert.ToInt32(Console.ReadLine());

Console.Write("Целевое растояние: ");
int Y = Convert.ToInt32(Console.ReadLine());

int result = 1;

while (X < Y)
{
    result++;
    X = X * 1.15;
}

Console.Write("Результат: " + Convert.ToString(result));