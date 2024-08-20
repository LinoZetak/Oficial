using System;
using BibliotecaTDA; 
using cPersona;

namespace cPersona
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear personas
            CPersona felipeV = new CPersona("Felipe V");
            CPersona CarlosIII = new CPersona("Carlos III");
            CPersona CarlosVI = new CPersona("Carlos VI");
            CPersona MJoshepe = new CPersona("MJoshepe");

            // Crear árbol genealógico
            cArbolE arbol = cArbolE.Crear(felipeV);
            cArbolE subArbolCarlosIII = arbol.Agregar(arbol, CarlosIII);
            cArbolE subArbolCarlosVI = arbol.Agregar(arbol, CarlosVI);
            cArbolE subArbolMJoshepe = arbol.Agregar(arbol, MJoshepe);

            

            // Recorridos del árbol
            Console.WriteLine("Recorrido Preorden:");
            arbol.PreOrden();

            Console.WriteLine("\nRecorrido Posorden:");
            arbol.PosOrden();

            Console.WriteLine("\nRecorrido Inorden:");
            arbol.InOrden();
        }
    }
}
