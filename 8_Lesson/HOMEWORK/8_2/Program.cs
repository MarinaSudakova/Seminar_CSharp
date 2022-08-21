// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

void PrintArray (int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for (int i=0; i< row_size; i++)
    {
        for (int j=0; j< column_size; j++)
        {
            Console.Write ($" {arr[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


int [,] MussNums (int row, int column, int from, int to)
{
    int [,] arr = new int[row, column];

    for (int i=0; i< row; i++)
    {
        for (int j=0; j< column; j++)
        {
            arr[i, j] = new Random().Next (from,to);
        }
    }
    return arr;
}

int[] MaxSearch (int[,] array)
{
    int row = array.GetLength(0);
    int column = array.GetLength(1);
    int [] arrSum = new int [row];

    for (int i=0; i< row; i++)
    {
        int sum = 0;
        for (int j=0; j< column; j++)
        {
            sum = sum + array[i, j];
            arrSum[i] = sum;
        }
    }
    return arrSum ;
}

// версия преподавателя
void RowSmallAmount(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);
    int amount = 1000;
    int num;
    int smallest = 0;

    for (int i = 0; i < row_size; i++)
    {   
        num = 0;
        for (int j = 0; j < column_size; j++)
            num += arr[i, j];
            Console.Write($"{num, 4} ");            

        if (amount > num)
        {
            amount = num;
            smallest = i;
        }
    }
    Console.WriteLine();
    Console.Write($"The row with the lowest amount per position - {smallest + 1}");
}

void ShowMaxString (int[] arr)
{
    int posMax = 0;
    for (int i=0; i< arr.Length; i++)
    {
        if (arr[i] > arr[posMax])
            posMax = i;
    }
    Console.WriteLine ($" String maximum is {posMax +1} ");
}


void ShowArray(int[] coll)
{
    for (int ind = 0; ind < coll.Length; ind++)
    {
        Console.Write ($"{coll[ind]} ");
    }
}

Console.Write("Enter the number of rows: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Enter the number of columns: ");
int column = int.Parse(Console.ReadLine());





int[,] arr_1 = MussNums(row, column, 1, 11);
PrintArray(arr_1);

Console.WriteLine();
int[] arr2 = MaxSearch(arr_1);

ShowArray (arr2);
Console.WriteLine();
ShowMaxString (arr2);

