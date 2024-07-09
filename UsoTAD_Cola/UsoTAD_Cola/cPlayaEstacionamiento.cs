using BibliotecaTDA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace UsoTAD_Cola
{
    public class cPlayaEstacionamiento
    {
        private cCola aPlaya;
        private cCola aEspacioAux;

        public cPlayaEstacionamiento()
        {
            aPlaya = new cCola();   
            aEspacioAux = new cCola();  
        }

        public void IngresarCarro()
        {
            Console.WriteLine("Ingresar carro a la playa de estacionamiento");
            Console.Write("Placa: ");
            string placa = Console.ReadLine();
            aPlaya.Acolar(placa);
        }

        public void RetirarCarro()
        {
            Console.WriteLine("Retirar carro de la playa de estacionamiento");
            Console.Write("Placa: ");
            string placa = Console.ReadLine();

            aEspacioAux = new cCola();

            RetirarCarrosEspacioAux(placa);

            Reingresar();



        }

        public void RetirarCarrosEspacioAux(string placa)
        {
            if (!aPlaya.EsVaciaC())
            {
                if (!aPlaya.Cima().Equals(placa))
                {
                    aEspacioAux.Acolar(aPlaya.Cima());
                }

                aPlaya.Desacolar();
                RetirarCarrosEspacioAux(placa);



            }

        }


        public void Reingresar()
        {
            if (!aEspacioAux.EsVaciaC())
            {
                aPlaya.Acolar(aEspacioAux.Cima());  
                aEspacioAux.Desacolar();
                Reingresar();

            }
        }

        public void ListarCarros()
        {
            Console.WriteLine("Mostrando Los carros que están en la playa de estacionamiento: ");
            aPlaya.ListarCola();
            
        }


    }
}
