Console.Write("Введите число от: ");
int M = int.Parse(Console.ReadLine());
Console.Write("Введите число до: ");
int N = int.Parse(Console.ReadLine());

int PrintNumbers(int k, int n)
{
    if (k == n)
    {
        return k;
    }
    int sum = 0;
    return  sum = k + PrintNumbers(k + 1, n);
}

Console.Write($"M = {M}, N = {N} -> {PrintNumbers(M, N)}");