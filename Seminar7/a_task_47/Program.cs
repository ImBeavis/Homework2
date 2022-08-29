Console.Write("m= ");
int m = int.Parse(Console.ReadLine());
Console.Write("n= ");
int n = int.Parse(Console.ReadLine());

double[,] GetArray(int m, int n)
{
    double[,] result = new double[m, n];

    for (int i = 0; i < m; i++)
        for (int j = 0; j < n; j++)
            result[i, j] = new Random().Next(-100, 100) + new Random().NextDouble() * 100;

    return result;
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
            Console.Write($" {array[i, j]:F2} ");
        Console.WriteLine();
    }
}

double[,] myArray = GetArray(m, n);
PrintArray(myArray);