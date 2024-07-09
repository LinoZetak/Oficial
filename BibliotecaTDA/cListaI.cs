using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaTDA
{
    public class cListaI
    {
        // Atributos
        private cNodo aInicio;
        private int aNroElementos;

        // Constructores
        public cListaI()
        {
            aInicio = null;
            aNroElementos = 0;
        }
        public cListaI(cNodo pInicio, int pNroElemntos)
        {
            if (pInicio != null)
            {
                aInicio = pInicio;
                aNroElementos = pNroElemntos;
            }
        }

        // Propiedades
        public cNodo Inicio
        {
            get { return aInicio; }
            set { aInicio = value; }
        }

        public int NroElemntos
        {
            get { return aNroElementos; }
        }
        public Boolean EsVacio()
        {
            return aInicio == null;
        }

        // Metodos de proceso
        public void Listar()
        {
            // Recorrer nodos y proceasr cada elemento
            cNodo NodoAux = aInicio;
            while (NodoAux != null)
            {
                if (NodoAux.Elemento != null)
                {
                    Console.WriteLine(NodoAux.Elemento.ToString());
                }
                else
                {
                    Console.WriteLine("null");
                }
                NodoAux = NodoAux.Enlace;
            }          
        }
        public cNodo IesimoNodo(int posicion)
        {
            cNodo NodoAux = Inicio;
            int contador = 0;

            while (NodoAux != null)
            {
                if (contador == posicion)
                {
                    return NodoAux;
                }
                NodoAux = NodoAux.Enlace;
                contador++;
            }

            return null; // Devuelve null si la posición no se encuentra
        }
        public int Longitud()
        {
            int k = 0;
            cNodo Aux = aInicio;
            while (Aux != null)
            {
                k++;
                Aux = Aux.Enlace; // SgteNodo
            }
            return k;
        }
        public void Agregar(object Informacion)
        {
            cNodo nuevoNodo = new cNodo(Informacion);
            if (aInicio == null)
            {
                aInicio = nuevoNodo;
            }
            else
            {
                cNodo aux = aInicio;
                while (aux.Enlace != null)
                {
                    aux = aux.Enlace;
                }
                aux.Enlace = nuevoNodo;
            }
            aNroElementos++;           
        }
        public void Eliminar(int Posicion)
        {
            if (Posicion == 0)
            {
                Inicio = Inicio.Enlace;
                aInicio = null;
            }
            else
            {
                cNodo aux1 = IesimoNodo(Posicion);
                cNodo aux = IesimoNodo(Posicion - 1);
                aux.Enlace = aux1.Enlace;
                aux1.Enlace = null;
            }
            aNroElementos--;
        }
        public void Insertar(int posicion, object Informacion)
        {
            if (posicion >= 0 && posicion <= aNroElementos)
            {
                // El primer nodo es un caso especial 
                if (posicion == 0)
                {
                    aInicio = new cNodo(Informacion);
                }
                else
                {
                    cNodo NodoAux = IesimoNodo(posicion - 1);
                    NodoAux.Enlace = new cNodo(NodoAux.Elemento);
                    NodoAux.Elemento = Informacion;
                }
                aNroElementos++;
            }
        }
        public int Ubicar(object Informacion)
        {
            cNodo NodoAux = Inicio;
            int posicion = 0;

            while (NodoAux != null)
            {
                if (NodoAux.Elemento.Equals(Informacion))
                {
                    return posicion;
                }
                NodoAux = NodoAux.Enlace;
                posicion++;
            }

            return -1; // Devuelve -1 si el elemento no se encuentra

        }
    }
}
