using System;
using BibliotecaTDA;

namespace appAlumno
{
    public class cControl
    {
        // *** Atributos ****
        private cListaEnlazada ListaOrdenada1 = new cListaEnlazada();
        private cListaEnlazada ListaOrdenada2 = new cListaEnlazada();

        // **** Constructores ****
        public cControl()
        {
            cAlumno a1 = new cAlumno("Perez");
            cAlumno a2 = new cAlumno("Alvarez");
            cAlumno a3 = new cAlumno("Gomez");

            cDocente cDocente = new cDocente(1241);
            cDocente cDocente1 = new cDocente(1632);
            cDocente cDocente2 = new cDocente(16412);

            ListaOrdenada1.Agregar(a1);
            ListaOrdenada1.Agregar(a2);
            ListaOrdenada1.Agregar(a3);

            ListaOrdenada2.Agregar(cDocente);
            ListaOrdenada2.Agregar(cDocente1);
            ListaOrdenada2.Agregar(cDocente2);
        }

        // *** Métodos de proceso ***

        private void AgregarAlumno()
        {       
            Console.WriteLine("\nDigite el numero del Vehiculo que desea agregar:");
            Console.WriteLine("1. Nombre de Alumno");
            Console.WriteLine("2. Codigo de Docente");
            Console.Write("Opcion --> ");
            int opcion = int.Parse(Console.ReadLine());
            if (opcion == 1)
            {
                cAlumno alumno = new cAlumno();
                alumno.Leer();
                ListaOrdenada1.Agregar(alumno);
            }
            else if (opcion == 2)
            {
                cDocente Docente = new cDocente();
                Docente.Leer();
                ListaOrdenada2.Agregar(Docente);
            }
            Console.WriteLine("Agregado correctamente.");
        }

        public void MostrarAlumnosOrdenados()
        {
            Console.WriteLine("1. Relacion de Alumno");
            Console.WriteLine("2. Relacion de Docente");
            Console.Write("Opcion --> ");
            int opcion = int.Parse(Console.ReadLine());
            if (opcion == 1)
            {
                Console.WriteLine("Relacion de nombres");
                ListaOrdenada1.MostrarLista();
            }
            else if (opcion == 2)
            {
                Console.WriteLine("Relacion de codigos");
                ListaOrdenada2.MostrarLista();
            }
        }
        public static void Menu()
        {
            Console.WriteLine("******");
            Console.WriteLine("* Menu Principal *");
            Console.WriteLine("******");
            Console.WriteLine("1. Agregar Alumno");            
            Console.WriteLine("2. Mostrar alumnos Ordenados");
            Console.WriteLine("3. Salir");
            Console.WriteLine("Ingrese la opción deseada...");
        }

        //----------------------------------------------------------------/
        public void Ejecutar()
        {
            bool salir = false;
            while (!salir)
            {
                Console.Clear();
                Menu();
                Console.Write("\nIngrese Opción: ");
                int op;
                if (!int.TryParse(Console.ReadLine(), out op))
                {
                    Console.WriteLine("Ingrese un número válido.");
                    continue;
                }
                switch (op)
                {
                    case 1:
                        AgregarAlumno();
                        break;
                    case 2:
                        MostrarAlumnosOrdenados();
                        break;
                    case 3:
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("\nIngrese un número entre 1 y 7.");
                        break;
                }
                Console.WriteLine("\nPresione [ENTER] para continuar...");
                Console.ReadLine();
            }
        }
    }
}
