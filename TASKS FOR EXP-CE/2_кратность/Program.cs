// Выяснить, кратно ли число заданному, если нет, вывести остаток.

void Multiplicity (int a, int b)
{
    if (a % b == 0)
        Console.WriteLine ("It is ok");
    else
        Console.WriteLine ($" It is not ok, remainder is {a % b} ");
}

Console.WriteLine("Write a first number: ");
int a = int.Parse (Console.ReadLine());

Console.WriteLine("Write a second number: ");
int b = int.Parse (Console.ReadLine());

Multiplicity (a, b);
