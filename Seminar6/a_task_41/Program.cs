Console.Write("Введите размер массива: ");
int num = int.Parse(Console.ReadLine());

int[] ArrResult(int size)
{
    int[] MyArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write("Введите элемент массива: ");
        MyArray[i] = int.Parse(Console.ReadLine());
    }
    return MyArray;
}
int[] array = ArrResult(num);
Console.WriteLine(String.Join(" ", array));

int ResultNum(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            count++;
        }
    }
    return count;
}

Console.Write($"Количество чисел, которые больше нуля: {ResultNum(array)}");