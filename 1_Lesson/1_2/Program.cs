// проверить является ли число квадратом
Console.WriteLine("Write a first number: ");
string s_a = Console.ReadLine();
int a = int.Parse(s_a);

Console.WriteLine("Write a second number: ");
string s_b = Console.ReadLine();
int b = int.Parse(s_b);

if (a == b * b)
Console.WriteLine("Yes");
else 
Console.WriteLine("No");