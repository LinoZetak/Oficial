using System;

public class cAuto : cVehiculo
{
	protected int aAnio;

	public cAuto() : base()
	{
		aAnio = 1800;
	}

	public cAuto( string pPlaca, string pMarca, string pModelo , int pAnio) : base(pPlaca,  pMarca,  pModelo)
	{
		aAnio = pAnio;
	}

	public int Anio()
	{
		get { return aAnio; }

		set 
		{ 
			if (aAnio >= 1800)
			{
                aAnio = value;
            }
			
		}
	}

    public override void Leer()
    {
        base.Leer();    
        Console.Write("Año: ");
        Anio = int.Parse(Console.ReadLine());
    }

    public override void Mostrar()
	{
		base.Mostrar();
		Console.WriteLine($"Anio : {aAnio}");
    }

   

    public private int CalcularPeaje()
    {
        int anioActual = DateTime.Now.Year;
        int Antiguedad = anioActual - aAnio;
        if (Antiguedad > 20)
        {
            return 20;
        }
        else if (20 > Antiguedad > 15)
        {
            return 10;
        }
        else
        {
            return 0;
        }
    }

    



}	