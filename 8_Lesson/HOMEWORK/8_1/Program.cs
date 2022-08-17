// Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

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

int[,] ReverseFromMaxToMin (int[,] arr)
{
    for (int i=0; i< arr.GetLength(0); i++)
    {
        for (int j=0; j<arr.GetLength(1); j++)
        {
            int posMin = 0;
            for (int f = 0; f < arr.GetLength(1) - j; f++)
            {
                if (arr[i, f] < arr[i, posMin])
                posMin = f;
            }

            (arr[i, posMin], arr[i, arr.GetLength(1)- 1 -j]) = (arr[i, arr.GetLength(1)- 1 -j], arr[i, posMin]);
        } 
    }
    return arr;
}

Console.Write("Enter the number of rows: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Enter the number of columns: ");
int column = int.Parse(Console.ReadLine());

int[,] arr_1 = MussNums(row, column, 1, 11);
PrintArray(arr_1);

Console.WriteLine();
int[,] arr2 = ReverseFromMaxToMin(arr_1);
PrintArray(arr2);
