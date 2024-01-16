using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class Problema8
{
    public static void Solve()
    {
        Console.Write("Introduceti valoarea pentru n: ");
        int n = int.Parse(Console.ReadLine());

        int fibN = Fibonacci(n);

        Console.WriteLine($"Al {n}-lea numar din sirul lui Fibonacci: {fibN}");
    }

    private static int Fibonacci(int n)
    {
        if (n <= 0)
        {
            return 0;
        }
        else if (n == 1)
        {
            return 1;
        }
        else
        {
            int a = 0, b = 1, c = 0;
            for (int i = 2; i <= n; i++)
            {
                c = a + b;
                a = b;
                b = c;
            }
            return c;
        }
    }

}

