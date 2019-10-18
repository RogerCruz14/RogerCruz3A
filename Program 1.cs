using System;

namespace Programa_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int Cantidad, Número, Mayor = 0;
            Console.Write("El número máximo es: ");

            Cantidad = int.Parse(Console.ReadLine());
            for (int i = 0; i < Cantidad; i++)
            {
                Console.WriteLine("Escriba un Número:");
                Número = int.Parse(Console.ReadLine());

                if (i == 0)
                {
                    Mayor = Número;
                }
                else if (i == 0)
                {
                }
                if (Número > Mayor)
                {
                    Mayor = Número;
                }
            }
            Console.WriteLine("El número mayor es: " + Mayor);
            Console.ReadKey();
        }
    }
}
