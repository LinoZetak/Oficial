using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaTDA
{
    public class cArbolBB
    {
        #region ************************   ATRIBUTOS  *********************
        private cArbolBB aSubArbolIzq;
        private Object aRaiz;
        private cArbolBB aSubArbolDer;
        #endregion ************************   ATRIBUTOS  *********************

        #region ************************   MÉTODOS  *********************

        #region =======================  Constructores  =====================
        /* -------------------------------------------------------------- */
        public cArbolBB()
        {
            aSubArbolIzq = null;
            aRaiz = null;
            aSubArbolDer = null;
        }

        /* -------------------------------------------------------------- */
        public cArbolBB(Object pRaiz)
        {
            aSubArbolIzq = null;
            aRaiz = pRaiz;
            aSubArbolDer = null;
        }

        /* -------------------------------------------------------------- */
        public cArbolBB(cArbolBB pSubArbolIzq, Object pRaiz, cArbolBB pSubArbolDer)
        {
            aSubArbolIzq = pSubArbolIzq;
            aRaiz = pRaiz;
            aSubArbolDer = pSubArbolDer;
        }

        #endregion =======================  Constructores  =====================

        #region =======================  Propiedades  =====================
        /* ---------------------------------------------------------- */
        public cArbolBB SubArbolIzq
        {
            get
            {
                return aSubArbolIzq;
            }
            set
            {
                aSubArbolIzq = value;
            }
        }

        /* ---------------------------------------------------------- */
        public object Raiz
        {
            get
            {
                return aRaiz;
            }
            set
            {
                aRaiz = value;
            }
        }

        /* ---------------------------------------------------------- */
        public cArbolBB SubArbolDer
        {
            get
            {
                return aSubArbolDer;
            }
            set
            {
                aSubArbolDer = value;
            }
        }

        #endregion =======================  Propiedades  =====================

        #region =======================  Métodos de proceso  =====================
        /* ---------------------------------------------------------- */
        public bool EsVacio()
        {
            return aRaiz == null;
        }
        /* ---------------------------------------------------------- */
        public void Agregar(Object E)
        {
            if (EsVacio())
                aRaiz = E;
            else
                if (E.ToString().CompareTo(aRaiz.ToString()) < 0)
                // -- Agregar objeto en el SubArbolIzq
                if (aSubArbolIzq == null)
                    aSubArbolIzq = new cArbolBB(E);
                else
                    aSubArbolIzq.Agregar(E);
            else
                    // -- Agregar objeto en el SubArbolDer
                    if (aSubArbolDer == null)
                aSubArbolDer = new cArbolBB(E);
            else
                aSubArbolDer.Agregar(E);
        }

        /* ---------------------------------------------------------- */
        public void PreOrden()
        {
            if (!EsVacio())
            {
                // -- Procesar la Raiz
                Console.WriteLine(aRaiz);
                //-- Recorrer Hijo Izq en PreOrden
                if (aSubArbolIzq != null)
                    aSubArbolIzq.PreOrden();
                //-- Recorrer Hijo Der en PreOrden
                if (aSubArbolDer != null)
                    aSubArbolDer.PreOrden();
            }
        }

        /* ---------------------------------------------------------- */
        public void InOrden(Action<Object> Modulo = null)
        {
            if (!EsVacio())
            {
                //-- Recorrer Hijo Izq en InOrden
                if (aSubArbolIzq != null)
                    aSubArbolIzq.InOrden(Modulo);
                // -- Procesar la Raiz
                if (Modulo == null)
                    Console.WriteLine(aRaiz);
                else
                    Modulo(aRaiz);
                //-- Recorrer Hijo Der en InOrden
                if (aSubArbolDer != null)
                    aSubArbolDer.InOrden(Modulo);
            }
        }

        #endregion =======================  Métodos de proceso  =====================

        #endregion ************************   MÉTODOS  *********************
        public void PosOrden()
        {
            if (!EsVacio())
            {
                if (aSubArbolIzq != null)
                    aSubArbolIzq.PosOrden();
                if (aSubArbolDer != null)
                    aSubArbolDer.PosOrden();
                Console.WriteLine(aRaiz);
            }
        }

        public bool Contiene(object E)
        {
            if (EsVacio())
                return false;

            if (E.Equals(aRaiz))
                return true;

            if (E.ToString().CompareTo(aRaiz.ToString()) < 0)
                return aSubArbolIzq != null && aSubArbolIzq.Contiene(E);
            else
                return aSubArbolDer != null && aSubArbolDer.Contiene(E);
        }
    }
}
