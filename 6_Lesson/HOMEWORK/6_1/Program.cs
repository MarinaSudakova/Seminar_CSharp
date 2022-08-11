//  Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного
// копирования.

int[] FillArray (int size)
{
    int[] array = new int[size];
    for (int i=0; i<size; i++)
    {
        array[i] = new Random().Next (10, 51);
    }
    return array;
}

void PrintArray (int[] arr)
{
    for (int ind = 0; ind<arr.Length; ind++)
    {
        Console.Write ($"{arr[ind]} ");
    }
    Console.WriteLine();
}

void CopyArray (int[] mass)
{
    int[] copy = new int[mass.Length];
    for (int j=0; j<mass.Length; j++)
    {
        copy[j] = mass[j];
        Console.Write ($"{copy[j]} ");
    }
    Console.WriteLine();
}


int[] arr_1 = FillArray(7);
PrintArray (arr_1);

Console.WriteLine ("New Copy: ");
CopyArray(arr_1);
