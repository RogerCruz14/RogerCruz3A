using System;

namespace Programa_5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Número=n, L=Linea actial, Es=Espacio, *=Aster
            int Número, L, Es, Aster;
            Console.WriteLine("Ingrese número para hacer la piramide: ");
            Número = Convert.ToInt32(Console.ReadLine());
            for (L = 1; L <= Número; L++)
            {
                for (Es = 0; Es < Número - L; Es++)
                {
                    Console.Write(" ");
                }
                for (Aster = 0; Aster < (L * 2) - 1; Aster++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
