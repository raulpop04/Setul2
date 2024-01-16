using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class Problema11
{
    public static void Solve()
    {
        Console.Write("Introduceti lungimea secventei: ");
        int n = int.Parse(Console.ReadLine());

        double sumaInverselor = 0;

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Introduceti numarul {i + 1}: ");
            double numar = double.Parse(Console.ReadLine());

            sumaInverselor += 1 / numar;
        }

        Console.WriteLine($"Suma inverselor numerelor: {sumaInverselor}");
    }

}

