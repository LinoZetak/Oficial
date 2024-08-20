using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace appAlumno
{
    public class cAlumno 

    {
        // *** Atributos ****
        private string aNombre;

        // *** Constructores ****
        public cAlumno()
        {
            aNombre = "";          
        }

        public cAlumno(string pNombre)
        {
            aNombre = pNombre;
        }

        // **** Propiedades ****
        public string Nombre
        {
            get { return aNombre; }
            set { aNombre = value; }
        }


        // ***** Metodos de proceso *****
        public virtual void Leer()
        {
            Console.WriteLine("Ingrese el Nombre: ");
            Nombre = Console.ReadLine();
        }
        public void Mostrar()
        {
            Console.WriteLine($" {Nombre} ");
        }

        public override string ToString()
        {
            return $"  {Nombre}  ";
        }
    }
}
