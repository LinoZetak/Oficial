namespace EspacioDeNombres
{
    public class cVehiculo
    {
        protected string aPlaca;
        protected string aMarca;
        protected string aModelo;

        public cVehiculo()
        {
            aPlaca = "";
            aMarca = "";
            aModelo = "";
        }
        public cVehiculo(string pPlaca, string pMarca, string pModelo)
        {
            aPlaca = pPlaca;
            aMarca = pMarca;
            aModelo = pModelo;
        }
        // Propiedades
        public string Placa
        {
            get { return aPlaca; }
            set { aPlaca = value; }
        }
        public string Marca
        {
            get { return aMarca; }
            set { aMarca = value; }
        }
        public string Modelo
        {
            get { return aModelo; }
            set { aModelo = value; }
        }
        // Metodos

        public virtual void Leer()
        {
            Console.Write("Placa: ");
            Placa = Console.ReadLine();
            Console.Write("Marca: ");
            Marca = Console.ReadLine();
            Console.Write("Modelo: ");
            Modelo = Console.ReadLine();
        }

        public virtual void Mostrar()
        {
            Console.WriteLine($"Placa: {aPlaca}");
            Console.WriteLine($"Marca: {aMarca}");
            Console.WriteLine($"Modelo: {aModelo}");
        }

        
        public override bool Equals(object pPlaca)
        {
            return aPlaca.Equals(pPlaca.ToString());
        }
    }

  
}