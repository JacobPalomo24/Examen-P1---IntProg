using System;

namespace Examen_P1___E4
{
    class Program
    {
        static void Main(string[] args)
        {
            double estatura, te = 0;
            int cont = 0;
            do
            {
                Console.Write("Ingresa una estatura (cm o m): ");
                estatura = double.Parse(Console.ReadLine());
                te += estatura;
                cont++;
                
            } while (estatura > 0);

            double prom = te / cont;

            Console.Write("El promedio de las estaturas es de: " + prom);

            Console.Write("\nPresione cualquier tecla para salir...");
            Console.ReadKey(true);
        }
    }
}
