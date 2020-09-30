using System;

namespace Examen_P1___E3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el peso (kg) de su paquete: ");
            double peso = double.Parse(Console.ReadLine());

            if (peso > 5)
            {
                Console.Write("Los paquetes mayores a 5kg no pueden ser transportados por motivos de seguridad, lo sentimos.");
            }
            else
            {
                Console.Write("Ingrese el número de zona a la que desea enviar su paquete: ");
                int zona = int.Parse(Console.ReadLine());

                switch (zona)
                {
                    case 1:
                        {
                            string nomZona = "América del Norte";
                            double precio = 11 * peso;
                            Console.WriteLine("El costo por enviar su paquete a " + nomZona + ", es de $" + precio + " pesos.");
                            break;
                        }

                    case 2:
                        {
                            string nomZona = "América Central";
                            double precio = 10 * peso;
                            Console.WriteLine("El costo por enviar su paquete a " + nomZona + ", es de $" + precio + " pesos.");
                            break;
                        }

                    case 3:
                        {
                            string nomZona = "América del Sur";
                            double precio = 12 * peso;
                            Console.WriteLine("El costo por enviar su paquete a " + nomZona + ", es de $" + precio + " pesos.");
                            break;
                        }

                    case 4:
                        {
                            string nomZona = "Europa";
                            double precio = 24 * peso;
                            Console.WriteLine("El costo por enviar su paquete a " + nomZona + ", es de $" + precio + " pesos.");
                            break;
                        }

                    case 5:
                        {
                            string nomZona = "Asia";
                            double precio = 27 * peso;
                            Console.WriteLine("El costo por enviar su paquete a " + nomZona + ", es de $" + precio + " pesos.");
                            break;
                        }

                    default:
                        {
                            Console.WriteLine("Esa zona no existe. Intente de nuevo.");
                            break;
                        }
                }
            }

            Console.Write("\nPresione cualquier tecla para salir...");
            Console.ReadKey(true);
        }
    }
}
