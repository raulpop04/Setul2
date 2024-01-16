using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class Problema10
{
    public static void Solve()
    {
        Console.Write("Introduceti lungimea secventei: ");
        int n = int.Parse(Console.ReadLine());

        int maxConsecutive = 1;
        int consecutiveCurent = 1;

        Console.Write($"Introduceti numarul 1: ");
        int prevNumar = int.Parse(Console.ReadLine());

        for (int i = 1; i < n; i++)
        {
            Console.Write($"Introduceti numarul {i + 1}: ");
            int numar = int.Parse(Console.ReadLine());

            if (numar == prevNumar)
            {
                consecutiveCurent++;
                if (consecutiveCurent > maxConsecutive)
                {
                    maxConsecutive = consecutiveCurent;
                }
            }
            else
            {
                consecutiveCurent = 1;
            }

            prevNumar = numar;
        }

        Console.WriteLine($"Numarul maxim de numere consecutive egale: {maxConsecutive}");
    }


}