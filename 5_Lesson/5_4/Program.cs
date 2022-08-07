// 4. Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.

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

int[] NewMass (int[] arr)
{
    int size = arr.Length;
    int flex_size = size/2 + size%2;
    int[] new_arr = new int[flex_size];

    for (int j = 0; j<size/2; j++)
    {
        new_arr[j] = arr[j] * arr[size-j-1];
    }

    if (new_arr[flex_size-1] == 0)
        new_arr[flex_size-1] = arr[flex_size-1];

    return new_arr;
}

int[] arr_1 = MassNums(5, 1, 10);
ShowArray(arr_1);


int[] new_arr_1 = NewMass(arr_1);
ShowArray(new_arr_1);
