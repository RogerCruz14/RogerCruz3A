using System;

namespace Programa_3
{
    class Program
    {
        static void Main(string[] args)
        {
            { 
            int Número;
            double precio;
            double total = 0;

            do
            {
                do
                {
                    Console.WriteLine("\nIngrese la cantidad vendida del producto: ");
                    Número = Convert.ToInt16(Console.ReadLine());
                    if (Número < 0) Console.WriteLine("Cantidad no valida");
                } while (Número < 0);
                if (Número > 0)
                {
                    Console.WriteLine("Ingrese el precio unitario del producto: ");
                    do
                    {
                        precio = Convert.ToDouble(Console.ReadLine());
                        if (precio < 0) Console.WriteLine("Precio no valido");
                        else total += Número * precio;
                    } while (precio < 0);
                }
            } while (Número != 0);

            Console.WriteLine("Total vendido = " + total);
            Console.WriteLine();
        }
        Console.ReadKey();
        }
    }
}
