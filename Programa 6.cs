using System;

namespace Programa_6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Número=n, L=Linea actial, Es=Espacio, *=Aster
            int Número, L, Es, Aster;
            Console.WriteLine("Ingrese un número para hacer un Rombo: ");
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
            for (L = Número - 2; L >= 0; L--)
            {
                for (Es = 1; Es < Número - L; Es++)
                {
                    Console.Write(" ");
                }
                for (Aster = 0; Aster <= (L * 2); Aster++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
