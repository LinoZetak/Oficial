using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaTDA
{
    public class cListaEnlazada
    {
        // ****** Atributos *******
        private object aElemento;
        private cListaEnlazada aSubLista;

        // ***** Constructores ******
        public cListaEnlazada()
        {
            aElemento = null;
            aSubLista = null;
        }
        public cListaEnlazada(object pElemento, cListaEnlazada pSubLista)
        {
            aElemento = pElemento;
            aSubLista = pSubLista;
        }

        // ***** Propiedades *****
        public object Elemento
        {
            get { return aElemento; }
            set { aElemento = value; }
        }
        public cListaEnlazada SubLista
        {
            get { return aSubLista; }
            set { aSubLista = value; }
        }

        // **** Metodos de proceso ****
        public bool EsVacia()
        {
            return ((aElemento == null) && (aSubLista == null));
        }
        /* --------------------------------------------------- */
        public void Agregar(object pElemento)
        {
            if (EsVacia() || (pElemento.ToString().CompareTo(Elemento.ToString()) <= 0))
            {
                aSubLista = new cListaEnlazada(aElemento, aSubLista);
                aElemento = pElemento;
            }
            else
            {
                aSubLista.Agregar(pElemento);
            }
        }

        /* --------------------------------------------------- */
        public int Ubicacion(object pElemento)
        {
            if (EsVacia() || (pElemento.ToString().CompareTo(Elemento.ToString()) < 0))
            {
                // No existe en la lista
                return 0;
            }
            else
            {
                if (Elemento.Equals(pElemento))
                    return 1;
                else
                {
                    int k = SubLista.Ubicacion(pElemento);
                    return ((k > 0) ? 1 + k : 0);
                }  
            }
        }
        public object Iesimo(int Posicion)
        {
            if (Posicion == 1)
            {
                return aElemento;
            }
            else if (aSubLista != null)
            {
                return aSubLista.Iesimo(Posicion - 1);
            }
            else
            {
                return $"Posición fuera de rango en la lista enlazada.";
            }
        }
        /* --------------------------------------------------- */
        public void MostrarLista()
        {
            if (!EsVacia())
            {
                Console.WriteLine(Elemento.ToString());
                SubLista.MostrarLista();
            }
        }      
    }

}
