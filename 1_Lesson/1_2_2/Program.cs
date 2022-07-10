// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Write a first number: ");
string s_a = Console.ReadLine();
int a = int.Parse(s_a);

Console.WriteLine("Write a second number: ");
int b = int.Parse(Console.ReadLine());

if (a > b)
{
    Console.Write("max is ");
    Console.WriteLine(a);
}

else
{
    Console.Write("max is ");
    Console.WriteLine(b);
}

