Console.Write("Введите число M: ");
double M = double.Parse(Console.ReadLine());
Console.Write("Введите число N: ");
double N = double.Parse(Console.ReadLine());

double A(double n, double m)
{
    if (n == 0)
        return m + 1;
    else
      if ((n != 0) && (m == 0))
        return A(n - 1, 1);
    else
        return A(n - 1, A(n, m - 1));
}

A(M, N);
Console.Write(A(M, N));