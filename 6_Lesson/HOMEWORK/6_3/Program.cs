// Напишите программу, которая найдёт точку
// пересечения двух прямых, заданных уравнениями y = k1 *
// x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются
// пользователем.

void Point (double k1, double b1, double k2, double b2)
{
    double x = 0;
    double y = 0;

    if (k1 - k2 != 0)
    {
        x = (b1 - b2) / (k1 - k2);
        y = k1 * x + b2;
    }

    else
    {
        Console.WriteLine ("Ошибка");
    }
    
    Console.WriteLine ($"Координаты точки пересечения прямых: {x} ; {y}");
}

Console.WriteLine ("Введите первое значение формулы первой прямой: ");
double num1 = int.Parse (Console.ReadLine());

Console.WriteLine ("Введите второе значение формулы первой прямой: ");
double num2 = int.Parse (Console.ReadLine());

Console.WriteLine ("Введите первое значение формулы второй прямой: ");
double num3 = int.Parse (Console.ReadLine());

Console.WriteLine ("Введите второе значение формулы второй прямой: ");
double num4 = int.Parse (Console.ReadLine());

Point(num1, num2, num3, num4);

