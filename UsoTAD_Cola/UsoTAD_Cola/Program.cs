using System;
using UsoTAD_Cola;

namespace AplicacionEstacionamiento
{
    class Program
    {
        static void Main(string[] args)
        {
            cPlayaEstacionamiento estacionamiento = new cPlayaEstacionamiento();
            int opcion;

            do
            {
                Console.Clear();
                Console.WriteLine("Menú de Playa de Estacionamiento");
                Console.WriteLine("1. Ingresar carro");
                Console.WriteLine("2. Retirar carro");
                Console.WriteLine("3. Listar carros");
                Console.WriteLine("4. Salir");
                Console.Write("Seleccione una opción: ");

                if (int.TryParse(Console.ReadLine(), out opcion))
                {
                    switch (opcion)
                    {
                        case 1:
                            estacionamiento.IngresarCarro();
                            break;
                        case 2:
                            estacionamiento.RetirarCarro();
                            break;
                        case 3:
                            estacionamiento.ListarCarros();
                            Console.WriteLine("Presione una tecla para continuar...");
                            Console.ReadKey();
                            break;
                        case 4:
                            Console.WriteLine("Saliendo del programa...");
                            break;
                        default:
                            Console.WriteLine("Opción no válida. Intente nuevamente.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Entrada no válida. Intente nuevamente.");
                }

            } while (opcion != 4);
        }
    }
}
