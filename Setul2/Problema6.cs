using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class Problema6
{
    public static void Solve()
    {
        Console.Write("Introduceti lungimea secventei: ");
        int n = int.Parse(Console.ReadLine());

        bool ordineCrescatoare = true;
        int ultimulNumar = int.MinValue;

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Introduceti numarul {i + 1}: ");
            int numar = int.Parse(Console.ReadLine());

            if (numar < ultimulNumar)
            {
                ordineCrescatoare = false;
                break;
            }

            ultimulNumar = numar;
        }

        Console.WriteLine($"Numerele sunt in ordine crescatoare: {ordineCrescatoare}");
    }


}

