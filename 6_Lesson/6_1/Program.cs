// 1. Напишите программу, которая принимает на вход три числа
//    и проверяет, может ли существовать треугольник с сторонами такой длины.


void Triangle (int x, int y, int z)
{
    if (x+y > z && x+z > y && z+y > y)
    {
        Console.WriteLine ("Yes");
    }
    else
        Console.WriteLine ("No");
}

Triangle (1, 2, 3);


