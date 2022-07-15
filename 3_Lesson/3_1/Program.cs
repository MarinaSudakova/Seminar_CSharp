// 1. Напишите программу, которая по заданному номеру четверти,
//    показывает диапазон возможных координат точек в этой четверти (x и y).


void Var (int a)
{
    if (a == 1)
    Console.WriteLine ("x>o, y>0");
    else if (a == 2)
    Console.WriteLine ("x<o, y>0");
    else if (a == 3)
    Console.WriteLine ("x<o, y<0");
    else if (a == 4)
    Console.WriteLine ("x>o, y<0");
    else
    Console.WriteLine ("Error");
}

Var(9);
Var(1);
Var(2);
Var(3);
Var(4);
