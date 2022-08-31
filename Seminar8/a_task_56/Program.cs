Console.Write("Введите кол-во строк: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int n = int.Parse(Console.ReadLine());

int[,] GetArray(int m, int n)
{
    int[,] result = new int[m, n];

    for (int i = 0; i < m; i++)
        for (int j = 0; j < n; j++)
            result[i, j] = new Random().Next(1, 10);

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

int SumElementsInRow(int[,] array, int i)
{
    int sumLine = array[i, 0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
        sumLine += array[i, j];
    }
    return sumLine;
}


void ResultMinSumLine(int[,] arr)
{
    int resultMinSum = 0;
    int sumLine = SumElementsInRow(arr, 0);
    for (int i = 1; i < arr.GetLength(0); i++)
    {
        int currentSum = SumElementsInRow(arr, i);
        if (sumLine > currentSum)
        {
            sumLine = currentSum;
            resultMinSum = i;
        }
    }
    Console.Write($"{resultMinSum + 1}-ая строка с наименьшей суммой {sumLine}");
}

int[,] myArray = GetArray(m, n);
PrintArray(myArray);
ResultMinSumLine(myArray);