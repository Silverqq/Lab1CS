using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("x= ");
        var x = Double.Parse(Console.ReadLine());
        Console.WriteLine("n= ");
        var n = int.Parse(Console.ReadLine());

        double result = 0;
        for (int i = 0; i < n; i++)
        {
            result += Math.Pow(-1, i) * Math.Pow(x, i) / Factorial(i);
        }
           
        Console.WriteLine($"Результат вычисления экспоненты для x = {x} с использованием {n} итераций: {result}");
    }

    static double Factorial(int n)
    {
        if (n == 0)
            return 1;
        else
            return n * Factorial(n - 1);
    }
}