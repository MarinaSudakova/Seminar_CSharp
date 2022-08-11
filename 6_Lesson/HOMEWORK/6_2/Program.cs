// Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.



int[] FillArray (int count)
{
    int[] array = new int[count];

    for (int i=0; i<count; i++)
    {
        Console.WriteLine ("Write next number: ");
        int elem = int.Parse (Console.ReadLine());
        array[i] = elem;
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

void HowMany (int[] arr)
{
    int sum =0;
    for (int ind = 0; ind<arr.Length; ind++)
    {
        if (arr[ind] >0)
            sum++;
    }
    Console.WriteLine($"There are {sum} positive numbers");
}

Console.WriteLine ("How many numbers do you want to write? ");
int size = int.Parse (Console.ReadLine());

int[] arr_1 = FillArray (size);
PrintArray(arr_1);

HowMany (arr_1);
