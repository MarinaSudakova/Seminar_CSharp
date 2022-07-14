// Напишите программу, которая выводит случайное трёхзначное число и 
// удаляет вторую цифру этого числа.

void CutNum (string num)
{
    Console.WriteLine(num[0],num[2]);
}

int number = new Random().Next(100,1000);
string s_a = number.ToString();

Console.Write($"{number} change to ");
CutNum (s_a);
