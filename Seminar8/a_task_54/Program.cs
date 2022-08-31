Console.Write("Введите кол-во строк: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int n = int.Parse(Console.ReadLine());

int[,] GetArray(int m, int n)
{
    int[,] result = new int[m, n];

    for (int i = 0; i < m; i++)
        for (int j = 0; j < n; j++)
            result[i, j] = new Random().Next(1, 100 + 1);

    return result;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
            Console.Write($"{array[i, j]} ");
        Console.WriteLine();
    }
}

void ArrangeItems(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            for (int h = 0; h < inArray.GetLength(1) - 1; h++)
            {
                if (inArray[i, h] < inArray[i, h + 1])
                {
                    int k = inArray[i, h + 1];
                    inArray[i, h + 1] = inArray[i, h];
                    inArray[i, h] = k;
                }
            }
        }
    }
}

int[,] myArray = GetArray(m, n);
PrintArray(myArray);
ArrangeItems(myArray);
Console.WriteLine();
PrintArray(myArray);