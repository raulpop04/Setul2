using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class Problema2
{
    public static void Solve()
    {
        Console.Write("Introduceti lungimea secventei: ");
        int n = int.Parse(Console.ReadLine());

        int countNegative = 0;
        int countZero = 0;
        int countPositive = 0;

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Introduceti numarul {i + 1}: ");
            int numar = int.Parse(Console.ReadLine());

            if (numar < 0)
            {
                countNegative++;
            }
            else if (numar == 0)
            {
                countZero++;
            }
            else
            {
                countPositive++;
            }
        }

        Console.WriteLine($"In secventa sunt {countNegative} numere negative, {countZero} numere zero si {countPositive} numere pozitive.");
    }
}