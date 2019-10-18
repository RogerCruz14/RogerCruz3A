using System;

namespace Programa_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int Número, Num1, Num2, Suma;
            do
            {
                Console.WriteLine("Elegir una opción\n" +
                    "\n 1) Salir" +
                    "\n 2) Sumatorio" +
                    "\n 3) Factorial");

                Número = Convert.ToInt32(Console.ReadLine());

                switch (Número)
                {
                    case 1:
                        Console.WriteLine("Salir");
                        break;

                    case 2:

                        Console.WriteLine("Ingrese primer número: ");
                        Num1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número:");
                        Num2 = int.Parse(Console.ReadLine());

                        Suma = Num1 + Num2;
                        Console.WriteLine("El resultado es:" + Suma);
                        Console.WriteLine();
                        break;

                    case 3:
                        Console.WriteLine("Introduzca el número:");
                        int fact, Factorial = 1, Contador = 0;
                        fact = int.Parse(Console.ReadLine());
                        for (int i = 1; i <= fact; i++)
                        {
                            Contador = Contador + 1;
                            Factorial = Factorial * Contador;

                        }
                        Console.WriteLine("El Factorial de el número es igual a :" + Factorial);
                        Console.WriteLine();
                        break;
                }
            } while (Número != 1);
            Console.ReadKey();
        }
    }
}
