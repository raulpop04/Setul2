using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class Problema13
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

        bool esteCrescatoareRotita = false;
        for (int i = 0; i < n; i++)
        {

            secventa.Add(secventa[0]);
            secventa.RemoveAt(0);

            if (EsteCrescatoare(secventa))
            {
                esteCrescatoareRotita = true;
                break;
            }
        }

        Console.WriteLine($"Secventa este crescatoare rotita: {esteCrescatoareRotita}");
    }

    private static bool EsteCrescatoare(List<int> secventa)
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
