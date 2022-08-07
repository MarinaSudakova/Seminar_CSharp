// Массив из 12 цифр положительных и отрицательных
// по отдельносьти суммы положительных и отрицательных

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
}

void SumPosNeg (int[] arr)
{
    int pos, neg;
    pos = neg = 0;

    for (int j = 0; j<arr.Length; j++)
    {
        if (arr[j] >=0)
            pos += arr[j];
        else    
            neg += arr[j];
    }
    Console.WriteLine ($"Positive: {pos}, negative: {neg}");
}


int[] arr_1 = MassNums(12, -9, 10);
ShowArray(arr_1);
SumPosNeg (arr_1);

