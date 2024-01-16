using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class Problema7
{
    public static void Solve()
    {
        Console.Write("Introduceti lungimea secventei: ");
        int n = int.Parse(Console.ReadLine());

        int minValoare = int.MaxValue;
        int maxValoare = int.MinValue;

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Introduceti numarul {i + 1}: ");
            int numar = int.Parse(Console.ReadLine());

            if (numar < minValoare)
            {
                minValoare = numar;
            }

            if (numar > maxValoare)
            {
                maxValoare = numar;
            }
        }

        Console.WriteLine($"Cea mai mica valoare din secventa: {minValoare}");
        Console.WriteLine($"Cea mai mare valoare din secventa: {maxValoare}");
    }

}
