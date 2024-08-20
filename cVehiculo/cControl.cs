using System;

public class cControl
{

    private cListai ListaVehiculo;

    public cControl()
    {
        ListaVehiculo = new cListai();
        cListai l1 = new cAuto(123566, Toyota, 4x4, 2000)
        cListai l2 = new cCamion(987721, Ferrari, Luna, 2018)

        ListaVehiculo.Agregar(l1);
        ListaVehiculo.Agregar(l2);
    }

    public void IngresarVehiculo()
    {
        Console.WriteLine("\nIngrese una opcion: ");
        Console.WriteLine("1. Auto");
        Console.WriteLine("2. Camion");
        Console.Write("Opcion= ");
        int opcion = int.Parse(Console.ReadLine());


        cVehiculo titi
        if (opcion == 1)
        {
            titi = new cAuto;
        }

        else if (opcion == 2)
        {
            titi = new cCamion;
        }

        else
        {
            Console.WriteLine("Opción inválida.");
            return;
        }

        titi.Leer();
        if (ListaVehiculo.ubicacion(titi.Placa) != -1)
        {
            Console.WriteLine("Ya se registró una vez");
        }
        else
        {
            ListaVehiculo.Agregar(titi);
        }

        private int Ubicacion(string pPlaca)
        {
            ListaVehiculo.ubicacion(pPlaca);    
        }

        public void BuscarVehiculo()
        {
            Console.WriteLine("Ingrese placa del vehiculo a buscar");
            string Placa = Console.ReadLine();
           
            int Ubi = Ubicacion(Placa);   

            if (Ubi >=0) 
            {
                ((cVehiculo)listaDocentes.Iesimo(Ubi).Info).Mostrar();
            }

            else
            {
                Console.WriteLine("No existe en la lista");
            }

            

        }


        public void EliminarVehiculo()
        {
            Console.WriteLine("Ingrese placa del vehiculo a buscar");
            string Placa = Console.ReadLine();

            int Ubi = Ubicacion(Placa);

            if (Ubi >= 0)
            {
                ListaVehiculo.eEliminar(Ubi);
            }

        }


    }




        
}