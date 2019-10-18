using System;

namespace Programa_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un número");
            int n;
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.Write(i);
                if (i <= n / 2)
                {
                    Console.Write("      " + (i + i));

                }
                else
                {
                    Console.Write(" ");
                }
                if (i <= n / 3)
                {
                    Console.WriteLine("      " + (i + i + i));

                }
                else
                {
                    Console.WriteLine(" ");
                }

            }
            Console.ReadKey();
        }
    }
}
