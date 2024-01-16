using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class Problema9
{
    public static void Solve()
    {
        Console.Write("Introduceti lungimea secventei: ");
        int n = int.Parse(Console.ReadLine());

        bool esteMonotonaCrescatoare = true;
        bool esteMonotonaDescrescatoare = true;
        int comparatie = 0;

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Introduceti numarul {i + 1}: ");
            int numar = int.Parse(Console.ReadLine());

            if (i > 0)
            {
                if (numar < comparatie)
                {
                    esteMonotonaCrescatoare = false;
                }

                if (numar > comparatie)
                {
                    esteMonotonaDescrescatoare = false;
                }
            }

            comparatie = numar;
        }

        if (esteMonotonaCrescatoare || esteMonotonaDescrescatoare)
        {
            if (esteMonotonaCrescatoare)
            {
                Console.WriteLine("Secventa este monoton crescatoare.");
            }
            else
            {
                Console.WriteLine("Secventa este monoton descrescatoare.");
            }
        }
        else
        {
            Console.WriteLine("Secventa nu este monotona.");
        }
    }


}

