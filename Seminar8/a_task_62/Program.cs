void FillingArray(int[,] array)
{
    int num = 1;
    int lines = 0;
    int columns = 0;

    while (num <= array.GetLength(0) * array.GetLength(1))
    {
        array[lines, columns] = num;
        num++;
        if (lines <= columns + 1 && lines + columns < array.GetLength(1) - 1)
            columns++;
        else if (lines < columns && lines + columns >= array.GetLength(0) - 1)
            lines++;
        else if (lines >= columns && lines + columns > array.GetLength(1) - 1)
            columns--;
        else
            lines--;
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]} ");
        Console.WriteLine();
    }
}

int[,] myArray = new int[4, 4];
FillingArray(myArray);
PrintArray(myArray);