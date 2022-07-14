// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

void ThirdDigit (int num)
{
    if (num < 100)
    Console.WriteLine("Third digit is not found");

    else
    {
      while (num > 999)
         num = num/10;
      Console.WriteLine($"Third digit is {num % 10}");
    }
}

Console.WriteLine("Write a three-digit number: ");
int s_a = int.Parse(Console.ReadLine());

ThirdDigit (s_a);

