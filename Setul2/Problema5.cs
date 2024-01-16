using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class Problema5
{
    public static void Solve()
    {
        Console.Write("Introduceti lungimea secventei: ");
        int n = int.Parse(Console.ReadLine());

        int numerePozitieEgala = 0;

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Introduceti numarul {i + 1}: ");
            int numar = int.Parse(Console.ReadLine());

            if (numar == i)
            {
                numerePozitieEgala++;
            }
        }

        Console.WriteLine($"Numerele cu pozitie egala sunt: {numerePozitieEgala}");
    }


}
