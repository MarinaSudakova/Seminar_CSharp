// Массив из 8 элементов заполненный 0 и 1 в случаом порядке

void RandomArr (int num)
{
    int[] array = new int[num];
    for (int i=0; i<num; i++)
    {
        array[i] = new Random().Next(0, 2);
        Console.Write($"{array[i]} ");
    }
}

RandomArr(8);

