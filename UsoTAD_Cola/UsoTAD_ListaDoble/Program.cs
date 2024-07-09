using System;

namespace BibliotecaTDA
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Crear una instancia de cListaDoble
            cListaDoble listaDoble = new cListaDoble();

            // Comprobar si la lista está vacía
            Console.WriteLine("¿La lista está vacía? " + listaDoble.EsVaciaLD());

            // Insertar elementos en la lista
            listaDoble.InsertarLD("Lino", 0);
            listaDoble.InsertarLD("Z", 0);
            listaDoble.InsertarLD("epic", 0);

            // Mostrar los elementos de la lista
            cNodoListaDoble nodo = listaDoble.PrimerNodo;
            while (nodo != null)
            {
                Console.WriteLine(nodo.Elemento);
                nodo = nodo.NodoPosterior;
            }

            // Comprobar si la lista está vacía después de insertar elementos
            Console.WriteLine("¿La lista está vacía? " + listaDoble.EsVaciaLD());
        }
    }

    
}

