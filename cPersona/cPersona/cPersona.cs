using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cPersona
{
    public class CPersona
    {
        private string aNombre;

        public CPersona()
        {
            aNombre = " ";
        }

        public CPersona(string pNombre)
        {
            aNombre = pNombre;
        }

        public string Nombre
        {  
            get { return aNombre; }
            set { aNombre = value; }
        }

        public override string ToString() //Sobrescribe el método ToString para devolver el nombre de la persona.
                                          //Esto es útil cuando se imprimen los objetos de la clase en la consola, ya que se mostrará el nombre de la persona.
        {
            return Nombre;
        }
    }
}
