using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaTDA
{
    public class cCola
    {
        // Atributos
        private object aElemento;
        private cCola aSubCola;

        // Constrcutores
        public cCola()
        {
            aElemento = null;
            aSubCola = null;
        }
        public cCola(object pElemento, cCola pSubCola)
        {
            aElemento = pElemento;
            aSubCola = pSubCola;
        }

        // Propiedades
        public object Elemento
        {
            get { return aElemento; }
            set { aElemento = value; }
        }
        public cCola SubCola
        {
            get { return aSubCola; }
            set { aSubCola = value; }
        }

        // Metodos
        public bool EsVaciaC()
        {   
            return ((aElemento == null) && (aSubCola == null));
        }
        

        

        public Object Cima() //Primero()
        {
            return aElemento;
        }

        public void Acolar(Object pElemento)
        {
            if (EsVaciaC())
            {
                aElemento = pElemento;
                aSubCola = new cCola();
            }
            else
                aSubCola.Acolar(pElemento);
        }

        public void Desacolar() // Avanzar()
        {
            if (!EsVaciaC())
            {
                aElemento = aSubCola.Elemento;
                aSubCola = aSubCola.SubCola;
            }
        }
        


        public void ListarCola()
        {
            if (!EsVaciaC())
            {
                Console.WriteLine(Elemento.ToString());
                aSubCola.ListarCola();
            }
        }

    }
}
