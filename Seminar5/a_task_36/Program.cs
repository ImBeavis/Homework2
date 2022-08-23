Console.Write("Введите размер массива: ");
int num = int.Parse(Console.ReadLine());
Console.Write("От: ");
int numA = int.Parse(Console.ReadLine());
Console.Write("До: ");
int numB = int.Parse(Console.ReadLine());

int[] ArrResult(int size, int a, int b)
{
    int[] MyArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        MyArray[i] = new Random().Next(a, b);
    }
    return MyArray;
}
int[] array = ArrResult(num, numA, numB);
Console.WriteLine(String.Join(" ", array));

int Result(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i = i + 2)
    {
        count = count + arr[i];
    }
    return count;
}
Console.Write($"Сумма чисел на нечетных индексах массива: {Result(array)}");