//Задайте двумерный массив из целых чисел.
//Найдите среднее арифметическое элементов в каждом
//столбце.


int [,] FillArray (int row, int column, int from, int to)
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


void PrintArray (int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for (int i=0; i< row_size; i++)
    {
        for (int j=0; j< column_size; j++)
        {
            Console.Write ($" {arr[i, j], 3} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void SumColumn (int[,] arr)
{
    for(int j=0; j<arr.GetLength(1); j++)
    {
        double sum = 0;
        for(int i=0; i<arr.GetLength(0); i++)
        {
            sum = sum + arr[i, j];
        }
        Console.Write ($" {Math.Round(sum/arr.GetLength(0), 2)} " );
    }
}


Console.Write("Enter the number of rows: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Enter the number of columns: ");
int column = int.Parse(Console.ReadLine());

int[,] arr_1 = FillArray(row, column, 1, 11);
PrintArray(arr_1);

SumColumn(arr_1);
