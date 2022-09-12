// Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("введите числа b1 k1 b2 k2 через пробел");

int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

int b1 = arr[0];

int k1 = arr[1];

int b2 = arr[2];

int k2 = arr[3];

double x = 0; 

double y = 1; 

int tmp1 = b1 / b2;

int tmp2 = k1 / k2;

double delta = (y * -k2)-(y * -k1); //дельта основной матрицы

double delta_y = (b1 * -k2)-(b2 * -k1); //дельта y

double delta_x = (y * b2)-(y * b1); //дельта х

if (delta == 0)
    {
        if ((tmp1 == tmp2) && (tmp2 == y))
            {
                Console.WriteLine($"прямые совпадают, решений бесконечное множество");
            }
            
            else Console.WriteLine($"прямые параллельны, решения не существует");
            
        return;
    }
 
x = delta_x / delta;

y = delta_y / delta;

Console.WriteLine($"координаты точки перечечения: {x}, {y}");
