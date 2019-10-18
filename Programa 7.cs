using System;

namespace Programa_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Los numeros del 1 al 100 y del 100 al 1 en columna son: ");
            int Resta = 101;

            for (int i = 1; i <= 100; i++)
            {
                Resta = Resta - 1;
                Console.WriteLine(i + "     " + Resta);
            }

            Console.ReadKey();
        }
    }
}
