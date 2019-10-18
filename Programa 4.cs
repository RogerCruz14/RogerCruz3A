using System;

namespace Programa_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int Horas, HorasExtras, Resp;
            double Salario, SalarioExtra, SalarioTotal;

            do
            {
                Console.WriteLine("Ingrese las horas trabajadas del personal: ");
                Horas = int.Parse(Console.ReadLine());
                if (Horas <= 35)
                {
                    Salario = Horas * 15;
                }
                else
                {
                    HorasExtras = Horas - 35;
                    SalarioExtra = HorasExtras * 22;
                    SalarioTotal = 35 * 15;
                    Salario = SalarioExtra + SalarioTotal;
                }
                Console.WriteLine("El salario total para su personal es: " + Salario);
                Console.WriteLine("¿Desea calcular el salario de otra persona ? SI 1 / NO 0");
                Resp = int.Parse(Console.ReadLine());

            } while (Resp == 1);
            Console.WriteLine("Su salario se ha calculado exitosamente ");
            Console.ReadLine();
        }
    }
}
