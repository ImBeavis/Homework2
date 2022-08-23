Console.Write("Введите размер массива: ");
int num = int.Parse(Console.ReadLine());

int[] ArrResult(int size)
{
    int[] MyArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        MyArray[i] = new Random().Next(100, 1000);
    }
    return MyArray;
}

int[] array = ArrResult(num);
Console.WriteLine(String.Join(" ", array));

int PositiveNumber(int[] arr)
{
    int countPositive = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            countPositive += 1;
        }
    }
    return countPositive;
}
Console.Write($"Количество четных чисел в массиве: {PositiveNumber(array)}");