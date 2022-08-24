// Определить номер четверти плоскости, в которой 
// находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0

string CheckQuarter (int x, int y)
{
    string flag = " ";
    if (x != 0 || y != 0)
    {
        if (x > 0 && y > 0)
            flag = "First quarter";
        else if (x > 0 && y < 0)
            flag = "Second quarter";
        else if (x < 0 && y < 0)
            flag = "Third quarter";
        else if (x < 0 && y > 0)
            flag = "Four quarter";
    }
    return flag;
}

Console.WriteLine("Write x: ");
int x = int.Parse (Console.ReadLine());

Console.WriteLine("Write y: ");
int y = int.Parse (Console.ReadLine());

Console.WriteLine (CheckQuarter (x, y));

