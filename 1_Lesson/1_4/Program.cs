// вывести числа до N
Console.WriteLine("Write a number a: ");
int a = int.Parse(Console.ReadLine());
// if (a < 0)
int i = -a;
while (i < a)
{
    Console.WriteLine(i);
    i++;
}
