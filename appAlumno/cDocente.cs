using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace appAlumno
{
    public class cDocente
    {
        // ********* Atributos ********
        private int aCodigo;

        // ********** Constructores ********
        public cDocente()
        {
            aCodigo = 0;
        }

        public cDocente(int pCodigo)
        {
            aCodigo = pCodigo;
        }

        // ********* Propiedades ************
        public int Codigo
        {
            get { return aCodigo; }
            set { aCodigo = value; }
        }

        // Metodos de proceso

        public virtual void Leer()
        {
            Console.WriteLine("Ingrse el codigo: ");
            Codigo = int.Parse(Console.ReadLine());
        }
        public void Mostrar()
        {
            Console.WriteLine(" " + Codigo);
        }
        public override string ToString()
        {
            return $"  {Codigo}  ";
        }
    }
}
