// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран

int FillArray(int[] num)
{
    for (int i=0; i<8; i++)
    {
        num[i] = new Random().Next(1, 30);
    }
    return num;
}

void ShowArray(int[] array)
{
    for (int ind = 0; ind < array.Length; ind++)
    {
        Console.Write ($"{array[ind]} ");
    }
}

int arr_1 = FillArray();

ShowArray(arr_1);
