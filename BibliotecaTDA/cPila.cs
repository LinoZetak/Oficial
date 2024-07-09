using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaTDA
{
    public class cPila
    {
        // *** Atributos ***
        private object aElemento;
        private cPila aSubPila;

        // *** Constructores *****
        public cPila()
        {
            aElemento = null;
            aSubPila = null;
        }
        public cPila(object pElemento, cPila pSubLista)
        {
            aElemento = pElemento;
            aSubPila = pSubLista;
        }
        public static cPila CrearPila()
        {
            return new cPila();
        }

        // *** Modificadores ****
        public void AsignarElemento(object pElemento)
        {
            aElemento = pElemento;
        }
        public void AsignarPila(cPila pSubPila)
        {
            aSubPila = pSubPila;
        }

        // **** Selectores *****
        public object Elemento()
        {
            return aElemento;
        }
        public cPila SubPila()
        {
            return aSubPila;
        }
        public Boolean EsVacia()
        {
            return aElemento == null && aSubPila == null;
        }
        // **** Metodos de proceso ****
        public void Apilar(object pElemento)
        {
            aSubPila = new cPila(aElemento, aSubPila);
            aElemento = pElemento;
        }
        /* -----------------------------------------------*/
        public void Desapilar()
        {
            if (!EsVacia())
            {
                aElemento = aSubPila.Elemento;
                aSubPila = aSubPila.aSubPila;
            }
        }
        /* -----------------------------------------------*/
        public Object Cima()
        {
            if (EsVacia())
                return null;
            else
                return aElemento;
        }
    }
}

