using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BibliotecaTDA
{
    public class cListaDoble
    {
        private cNodoListaDoble aPrimerNodo;
        private cNodoListaDoble aNodoActual;
        private cNodoListaDoble aUltimoNodo;

        public cListaDoble()
        {
            aPrimerNodo = null;
            aNodoActual = null;
            aUltimoNodo = null;
        }

        public cListaDoble(cNodoListaDoble pPrimerNodo, cNodoListaDoble pNodoActual, cNodoListaDoble pUltimoNodo)
        {
            aPrimerNodo = pPrimerNodo;
            aNodoActual = pNodoActual;
            aUltimoNodo = pUltimoNodo;
        }

        public cNodoListaDoble PrimerNodo
        {
            get { return aPrimerNodo; }
            set { aPrimerNodo = value; }
        }

        public cNodoListaDoble NodoActual
        {
            get { return aNodoActual; }
            set { aNodoActual = value; }
        }

        public cNodoListaDoble UltimoNodo
        {
            get { return aUltimoNodo;}
            set { aUltimoNodo = value; }
        }

        public bool EsVaciaLD()
        {
            return (PrimerNodo == null);
        }

        public void InsertarLD( object Elemento , int index)
        {
            if (EsVaciaLD()) 
            {
                PrimerNodo = new cNodoListaDoble(null, Elemento, null);
                aUltimoNodo = PrimerNodo;
            }

            else if (index == 0)
            {
                cNodoListaDoble NodoAux = PrimerNodo;
                PrimerNodo = new cNodoListaDoble(null, Elemento, NodoAux);
                PrimerNodo.NodoPosterior = NodoAux;

            }
        }



    }
}
