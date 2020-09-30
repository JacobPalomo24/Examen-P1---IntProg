using System;

namespace Examen_P1___E1
{
    class Program
    {
        static void Main(string[] args)
        {

            int ht = 0;
            for (byte semana = 0; semana < 6; semana++)
            {
                Console.Write("Ingrese las horas trabajadas el día de hoy: ");
                ht += int.Parse(Console.ReadLine());
            }

            Console.Clear();
            Console.Write("Ingrese el pago por hora: ");
            double ph = double.Parse(Console.ReadLine());

            double s = ht * ph;

            Console.Clear();
            Console.WriteLine("Por " + ht + " horas trabajadas en la semana.");
            Console.WriteLine("Su saldo semanal es de: $" + s + " pesos.");

            Console.Write("\nPresione cualquier tecla para salir...");
            Console.ReadKey(true);
        }
    }
}
