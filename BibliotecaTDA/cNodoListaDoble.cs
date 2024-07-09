using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaTDA
{
    public class cNodoListaDoble
    {
        private cNodoListaDoble aNodoAnterior;
        private object aElemento;
        private cNodoListaDoble aNodoPosterior;

        public cNodoListaDoble()
        {
            aNodoAnterior = null;
            aElemento = null;
            aNodoPosterior = null;
        }

        public cNodoListaDoble(cNodoListaDoble pNodoAnterior, object pElemento, cNodoListaDoble pNodoPosterior)
        {
            aNodoAnterior = pNodoAnterior;
            aElemento = pElemento;
            aNodoPosterior = pNodoPosterior;
        }

        public cNodoListaDoble NodoAnterior
        {
            get { return aNodoAnterior; }
            set {  aNodoAnterior = value; }
        }

        public object Elemento
        {
            get { return aElemento; }
            set { aElemento = value; }
        }

        public cNodoListaDoble NodoPosterior
        {
            get { return aNodoPosterior; }
            set { aNodoPosterior = value; }
        }




    }
}
