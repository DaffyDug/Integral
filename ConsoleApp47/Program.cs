using System;
class Program
{
    delegate double F(double x);
    static double Porabola(double x)
    {
        return x * x;
    }
    static double Formula(double x)
    {

        return -(1 / 8 * (x-8) * (x + 8)) + 6;
    }

    static double IntegralRectangle(double begin, double end, F f)
    {
        double sum = 0;
        for (double x = begin; x< end; x+=0.0001)
        {
            sum += 0.0001 * f(x);
        }
        return sum;
    }
    static void Main(string[] args)
    {

        Console.WriteLine(IntegralRectangle(4,12, Formula));
        double a = 288.0012 - 47.9999 - 48.0005 - 48.0005;
        Console.WriteLine(a);

    }
}