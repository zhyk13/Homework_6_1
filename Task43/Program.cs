// Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


double InputNumber(string msg)
{
    Console.Write(msg);
    return Convert.ToDouble(Console.ReadLine());
}

double k1 = InputNumber("Введите коэффициент k1: ");
double b1 = InputNumber("Введите коэффициент b1: ");
double k2 = InputNumber("Введите коэффициент k2: ");
double b2 = InputNumber("Введите коэффициент b2: ");
double x = 0;
double y = 0;

if ((k1 == k2) & (b1 != b2))
    {
        Console.WriteLine("Прямые не пересекаются");
    }
else
{
    if ((k1 == k2) & (b1 == b2))
    {
        Console.WriteLine("Прямые совпадают");
    }
    else
    {
        x = (b2 - b1) / (k1 - k2);
        y = k1 * x + b1;  
        Console.WriteLine($"Координаты точки пересечения: ({x}, {y})");
    }
}



