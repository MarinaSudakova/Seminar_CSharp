// 2. Задайте массив. Напишите программу, которая определяет,
// присутствует ли заданное число в массиве.

int [] MassNums(int size, int from, int to)
{
    int[] array = new int[size];
    for (int i=0; i<size; i++)
    {
        array[i] = new Random().Next(from, to);
    }
    return array;
}


void ShowArray(int[] coll)
{
    for (int ind = 0; ind < coll.Length; ind++)
    {
        Console.Write ($"{coll[ind]} ");
    }
    Console.WriteLine();
}

void Checking (int[] arr)
{
    Console.WriteLine ("Input counting value ");
    int s = int.Parse(Console.ReadLine());
    string text = "No";

    for (int j = 0; j<arr.Length; j++)
    {
        if (arr[j] == s)
        {
            text = "Yes";
            break;
        }
    }
    Console.WriteLine ($"The num value {s} -> {text}");
}


int[] arr_1 = MassNums(12, -9, 10);
ShowArray(arr_1);
Checking (arr_1);

