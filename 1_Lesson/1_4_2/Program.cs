// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Write a number: ");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Write a second number: ");
int b = int.Parse(Console.ReadLine());

Console.WriteLine("Write a third number: ");
int c = int.Parse(Console.ReadLine());

int max = a;

if (b > max)
max = b;

else 
max = a;

if (c > max)
max = c;

Console.Write("Maximum is: ");
Console.WriteLine(max);
