using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class Problema16
{
    public static void Solve()
    {
        Console.WriteLine("Introduceti lungimea secventei: ");
        int n = int.Parse(Console.ReadLine());

        int[] secventa = CitesteSecventa(n);

        bool esteBitonicaRotita = EsteSecventaBitonicaRotita(secventa);

        if (esteBitonicaRotita)
            Console.WriteLine("Secventa este bitonica rotita.");
        else
            Console.WriteLine("Secventa nu este bitonica rotita.");
    }

    private static int[] CitesteSecventa(int lungime)
    {
        int[] secventa = new int[lungime];

        for (int i = 0; i < lungime; i++)
        {
            Console.Write($"Introduceti elementul {i + 1}: ");
            secventa[i] = int.Parse(Console.ReadLine());
        }

        return secventa;
    }

    private static bool EsteSecventaBitonicaRotita(int[] secventa)
    {
        int lungime = secventa.Length;
        int indexMaxim = GasesteMaxim(secventa, 0, lungime - 1);

        return indexMaxim != -1 && indexMaxim != 0 && indexMaxim != lungime - 1;
    }

    private static int GasesteMaxim(int[] secventa, int stanga, int dreapta)
    {
        while (stanga <= dreapta)
        {
            int mijloc = stanga + (dreapta - stanga) / 2;

            if (secventa[mijloc] > secventa[mijloc - 1] && secventa[mijloc] > secventa[mijloc + 1])
            {
                return mijloc; 
            }
            else if (secventa[mijloc] > secventa[mijloc - 1])
            {
                stanga = mijloc + 1;
            }
            else
            {
                dreapta = mijloc - 1;
            }
        }

        return -1;
    }
}

