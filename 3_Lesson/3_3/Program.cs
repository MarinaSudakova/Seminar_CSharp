// Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.


void Quarter (int x)
{
    int index = 1;
    while (index <= x)
    {
        Console.Write ($"{Math.Pow(index,2)} ");
        index++;
    }
}

Quarter (7);

