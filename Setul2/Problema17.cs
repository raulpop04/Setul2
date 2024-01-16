using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class Problema17
{

    public static void Solve()
    {
        Console.WriteLine("Introduceti lungimea secventei de paranteze: ");
        int n = int.Parse(Console.ReadLine());

        int[] secventa = CitesteSecventaParanteze(n);

        bool esteCorecta = EsteSecventaParantezeCorecta(secventa);

        if (esteCorecta)
        {
            int nivelMaxim = NivelMaximIncubare(secventa);
            Console.WriteLine($"Secventa de paranteze este corecta cu nivelul maxim de incubare {nivelMaxim}.");
        }
        else
        {
            Console.WriteLine("Secventa de paranteze este incorecta.");
        }
    }

    private static int[] CitesteSecventaParanteze(int lungime)
    {
        int[] secventa = new int[lungime];

        for (int i = 0; i < lungime; i++)
        {
            Console.Write($"Introduceti paranteza {i + 1} (0 pentru deschisa, 1 pentru inchisa): ");
            secventa[i] = int.Parse(Console.ReadLine());
        }

        return secventa;
    }

    private static bool EsteSecventaParantezeCorecta(int[] secventa)
    {
        int nivel = 0;

        foreach (int paranteza in secventa)
        {
            if (paranteza == 0)
            {
                nivel++;
            }
            else if (paranteza == 1)
            {
                nivel--;

                if (nivel < 0)
                {
                    return false;
                }
            }
        }

        return nivel == 0;
    }

    private static int NivelMaximIncubare(int[] secventa)
    {
        int nivel = 0;
        int nivelMaxim = 0;

        foreach (int paranteza in secventa)
        {
            if (paranteza == 0)
            {
                nivel++;
                if (nivel > nivelMaxim)
                {
                    nivelMaxim = nivel;
                }
            }
            else if (paranteza == 1)
            {
                nivel--;
            }
        }

        return nivelMaxim;
    }


}
