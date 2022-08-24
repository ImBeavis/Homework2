Console.Write("Введите размер массива: ");
int num = int.Parse(Console.ReadLine());
Console.Write("От: ");
int numA = int.Parse(Console.ReadLine());
Console.Write("До: ");
int numB = int.Parse(Console.ReadLine());

double[] ArrResult(int size, int a, int b)
{
    double[] MyArray = new double[size];
    for (int i = 0; i < size; i++)
    {
        MyArray[i] = new Random().Next(a, b);
    }
    return MyArray;
}

double[] array = ArrResult(num, numA, numB);
Console.WriteLine(String.Join(" ", array));

double MaxNum(double[] arr)
{
    double max = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > max)
        {
            max = array[i];
        }
    }
    return max;
}
Console.WriteLine($"Максимальный элемент массива: {MaxNum(array)}");

double MinNum(double[] arr)
{
    double min = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < min)
        {
            min = array[i];
        }
    }
    return min;
}
Console.WriteLine($"Минимальный элемент массива: {MinNum(array)}");
Console.WriteLine($"Разница между максимальным и минимальным: {(MaxNum(array) - MinNum(array))}");