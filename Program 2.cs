using System;

namespace Programa_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite un número para realizar el cuadrado: ");
            int Número = Convert.ToInt32(Console.ReadLine());

            if (Número >= 0 && Número <= 100)
            {
                //Linea Superior
                for (int i = 0; i < Número; i++)
                {
                    Console.Write("*");
                }
                //Salto de linea
                Console.WriteLine();
                //Centro del cuadrado
                for (int i = 0; i < Número - 2; i++)
                {
                    Console.Write("*");
                    for (int j = 0; j < Número - 2; j++)
                    {
                        //Espacio de en medio
                        Console.Write(" ");
                    }
                    Console.WriteLine("*");
                }
                //Linea Inferior
                for (int i = 0; i < Número; i++)
                {
                    Console.Write("*");
                }
            }
        }
    }
}
