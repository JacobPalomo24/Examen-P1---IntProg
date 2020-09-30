using System;

namespace Examen_P1___E2
{
    class Program
    {
        static void Main(string[] args)
        {

            int kmP1 = 70, kmP2 = 150;
            while (kmP1 <= 150 && kmP2 >= 70)
            {
                kmP1++;
                kmP2--;
                if(kmP1 == kmP2)
                {
                    Console.WriteLine("Se encontrarán en el km: " + kmP1);
                    break;
                }
            }

            Console.Write("\nPresione cualquier tecla para salir...");
            Console.ReadKey(true);
        }
    }
}
