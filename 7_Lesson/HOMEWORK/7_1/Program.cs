//Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами

double [,] FillArray (int row, int column)
{
    double[,] array = new double[row, column];
    Random n_new = new Random();
    for (int i = 0; i<row; i++)
    {
        for (int j = 0; j<column; j++)
        {
            array[i, j] = Math.Round(n_new.NextDouble() * (10 + 20) -10, 2);
        }
    }
    return array;
}

void PrintArray (double[,] array_num)
{
    for (int i = 0; i < array_num.GetLength(0); i++)
    {
        for (int j = 0; j< array_num.GetLength(1); j++)
        {
            Console.Write ($" {array_num[i, j], 6} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.WriteLine ("Write number of rows: ");
int rows = int.Parse(Console.ReadLine());

Console.WriteLine ("Write number of columns: ");
int columns = int.Parse(Console.ReadLine());

double[,] arr_1 = FillArray(rows, columns);
PrintArray(arr_1);

