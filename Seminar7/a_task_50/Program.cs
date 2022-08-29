Console.Write("Введите кол-во строк: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int n = int.Parse(Console.ReadLine());
Console.Write("Введите индекс строки: ");
int line = int.Parse(Console.ReadLine());
Console.Write("Введите индекс столбца: ");
int column = int.Parse(Console.ReadLine());

int[,] GetArray(int m, int n)
{
    int[,] result = new int[m, n];

    for (int i = 0; i < m; i++)
        for (int j = 0; j < n; j++)
            result[i, j] = new Random().Next(-100, 100);

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

bool ReturnItem(int[,] arr, int index1, int index2)
{
    bool result = true;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (i == index1 && j == index2)
            {
                result = true;
                Console.Write($"Элемент данных индексов -> {arr[index1, index2]}");
                break;
            }
            else if (index1 >= arr.GetLength(0) || index2 >= arr.GetLength(1))
            {
                result = false;
                Console.WriteLine("Индекс не найден!");
                break;
            }
        }
    }
    return result;
}

int[,] myArray = GetArray(m, n);
PrintArray(myArray);
Console.WriteLine();
ReturnItem(myArray, line, column);