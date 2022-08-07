// 3. Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов 
//массива, значения которых лежат в отрезке [10,99].

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

int Find (int[] arr)
{
    int count = 0;
    for (int j = 0; j<arr.Length; j++)
    {
        if (arr[j] >= 10 && arr[j]<=99)
        count+=1;
    }
    return count;
}

int[] arr_1 = MassNums(123, -9, 100);
ShowArray(arr_1);
Console.WriteLine (Find (arr_1));


