using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class Problema12
{
    public static void Solve()
    {
        Console.Write("Introduceti lungimea secventei: ");
        int n = int.Parse(Console.ReadLine());

        int numarGrupuri = 0;
        bool inGrup = false;

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Introduceti numarul {i + 1}: ");
            int numar = int.Parse(Console.ReadLine());

            if (numar != 0)
            {
                if (!inGrup)
                {
                    inGrup = true;
                    numarGrupuri++;
                }
            }
            else
            {
                inGrup = false;
            }
        }

        Console.WriteLine($"Numarul de grupuri consecutive diferite de zero: {numarGrupuri}");
    }

}

