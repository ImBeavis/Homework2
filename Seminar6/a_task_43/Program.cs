Console.Write("Введите координату k1: ");
double k1 = double.Parse(Console.ReadLine());
Console.Write("Введите координату b1: ");
double b1 = double.Parse(Console.ReadLine());
Console.Write("Введите координату k2: ");
double k2 = double.Parse(Console.ReadLine());
Console.Write("Введите координату b2: ");
double b2 = double.Parse(Console.ReadLine());

double CoordinatesX(double NumK, double NumB, double NumK2, double NumB2)
{
    return (NumB2 - NumB) / (NumK - NumK2);
}
double x = CoordinatesX(k1, b1, k2, b2);

double CoordinatesY(double NumX)
{
    return (k1 * NumX) + b1;
}

Console.WriteLine(CoordinatesX(k1, b1, k2, b2));
Console.WriteLine(CoordinatesY(x));