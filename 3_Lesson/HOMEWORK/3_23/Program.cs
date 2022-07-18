// Напишите программу, которая
// принимает на вход число (N) и выдаёт
// выдаёт таблицу кубов чисел от 1 до N.


void Cube (int x)
{
    int index = 1;
    while (index <= x)
    {
        Console.WriteLine ($"{index} -> {Math.Pow(index,3)}");
        index++;
    }
}

Console.WriteLine ("Write a number: ");
int s_a = int.Parse(Console.ReadLine());
Cube (s_a);

