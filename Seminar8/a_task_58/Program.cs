Console.Write("Введите кол-во строк первой матрицы: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите кол-во столбцов первой матрицы (кол-во строк второй матрицы): ");
int n = int.Parse(Console.ReadLine());
Console.Write("Введите кол-во столбцов второй матрицы: ");
int h = int.Parse(Console.ReadLine());

int[,] GetArray(int m, int n)
{
    int[,] result = new int[m, n];

    for (int i = 0; i < m; i++)
        for (int j = 0; j < n; j++)
            result[i, j] = new Random().Next(1, 5);

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

int[,] MatrixProduct(int[,] firstArr, int[,] secondArr, int[,] resultArr)
{
    for (int i = 0; i < resultArr.GetLength(0); i++)
    {
        for (int j = 0; j < resultArr.GetLength(1); j++)
        {
            int work = 0;
            for (int h = 0; h < firstArr.GetLength(1); h++)
            {
                work += firstArr[i, h] * secondArr[h, j];
            }
            resultArr[i, j] = work;
        }
    }
    return resultArr;
}

int[,] firstArray = GetArray(m, n);
PrintArray(firstArray);
Console.WriteLine();
int[,] secondArray = GetArray(n, h);
PrintArray(secondArray);
int[,] resultArray = GetArray(m, h);
Console.WriteLine();
MatrixProduct(firstArray, secondArray, resultArray);
PrintArray(resultArray);