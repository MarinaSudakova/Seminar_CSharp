// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Write a number a: ");
int a = int.Parse(Console.ReadLine());

if (a > 0)
{
    int i = 2;
    while (i < a)
    {
        Console.WriteLine(i);
        i += 2;
    }
}

else
{
    int i = 0;
    while (i > a)
    {
        Console.WriteLine(i);
        i += -2;
    }
}


