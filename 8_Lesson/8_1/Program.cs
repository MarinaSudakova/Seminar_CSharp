// 1. Задайте двумерный массив. Напишите программу,
//    которая поменяет местами первую и последнюю строку массива.

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

int[,] ReverseArray (int[,] arr)
{
    int vrem = 0;
    for (int i=0; i< arr.GetLength(1); i++)
    {
        vrem = arr[0, i];
        arr[0,i] = arr[arr.GetLength(0)-1, i];
        arr[arr.GetLength(0)-1, i] = vrem;
    }
    Console.WriteLine();
    return arr;
}

Console.Write("Enter the number of rows: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Enter the number of columns: ");
int column = int.Parse(Console.ReadLine());

int[,] arr_1 = MussNums(row, column, 1, 11);
PrintArray(arr_1);
ReverseArray(arr_1);
Console.WriteLine();
PrintArray(arr_1);

// void FirstWithLast(int[,] arr)
// {
//     int row = arr.GetLength(0);
//     int column = arr.GetLength(1);

//     for (int i = 0; i < column; i++)
//     {        
//         (arr[0, i], arr[row - 1, i]) = (arr[row - 1, i], arr[0, i]);        
//     }
// }
