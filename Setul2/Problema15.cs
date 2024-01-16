using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class Problema15
{
    public static void Solve()
    {
        Console.Write("Introduceti lungimea secventei: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Introduceti elementele secventei:");

        List<int> secventa = new List<int>();
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Introduceti numarul {i + 1}: ");
            secventa.Add(int.Parse(Console.ReadLine()));
        }


        bool esteBitonica = false;
        int varfBitonic = GasesteVarfulBitonic(secventa, n);

        if (varfBitonic != -1)
        {
            esteBitonica = EsteMonotonaCrescatoare(secventa.GetRange(0, varfBitonic + 1)) && EsteMonotonaDescrescatoare(secventa.GetRange(varfBitonic, n - varfBitonic));
        }

        Console.WriteLine($"Secventa este bitonica: {esteBitonica}");
    }

    private static int GasesteVarfulBitonic(List<int> secventa, int lungime)
    {
        int stanga = 0;
        int dreapta = lungime - 1;

        while (stanga <= dreapta)
        {
            int mijloc = stanga + (dreapta - stanga) / 2;

            if (mijloc > 0 && mijloc < lungime - 1)
            {
                if (secventa[mijloc] > secventa[mijloc - 1] && secventa[mijloc] > secventa[mijloc + 1])
                {
                    return mijloc;
                }
                else if (secventa[mijloc - 1] > secventa[mijloc])
                {
                    dreapta = mijloc - 1;
                }
                else
                {
                    stanga = mijloc + 1;
                }
            }
            else
            {
                return -1; 
            }
        }

        return -1; 
    }

    private static bool EsteMonotonaDescrescatoare(List<int> secventa)
    {
        for (int i = 1; i < secventa.Count; i++)
        {
            if (secventa[i] > secventa[i - 1])
            {
                return false;
            }
        }
        return true;
    }
    private static bool EsteMonotonaCrescatoare(List<int> secventa)
    {
        for (int i = 1; i < secventa.Count; i++)
        {
            if (secventa[i] < secventa[i - 1])
            {
                return false;
            }
        }
        return true;
    }

}

