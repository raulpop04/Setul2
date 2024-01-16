using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class Problema4
{
    public static void Solve()
    {
        Console.Write("Introduceti lungimea secventei: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Introduceti numarul a: ");
        int a = int.Parse(Console.ReadLine());

        int pozitie = -1;

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Introduceti numarul {i + 1}: ");
            int numar = int.Parse(Console.ReadLine());

            if (numar == a)
            {
                pozitie = i;
                break;
            }
        }

        Console.WriteLine($"Numarul {a} se afla pe pozitia: {pozitie}");
    }

}