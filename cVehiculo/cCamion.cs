using System;

public class cCamion :  cVehiculo
{
	private int aNroRuedas;

	public cCamion() : base()
	{
		aNroRuedas = 4;
	}


	public cCamion( string pPlaca, string pMarca, string pModelo, int pNroRuedas) : base	(string pPlaca, string pMarca, string pModelo)
	{
		if (pNroRuedas < 4)
		{
			aNroRuedas = 4;
		}

		else if (pNroRuedas % 2 == 0 )
		{
			aNroRuedas = pNroRuedas;
		}

		else
		{
            aNroRuedas = 4;
        }

    }


	public int NroRuedas()
	{
		get{ return aNroRuedas; }
		set
		{
            if (value < 0)
            {
                aNroRuedas = 0;
            }
            else
            {
                aNroRuedas = value;
            }
	}



    public override void Leer()
    {
        base.Leer();
        Console.Write("Numero de Ruedas: ");
        NroRuedas = int.Parse(Console.ReadLine());
    }

    public override void Mostrar()
    {
        base.Mostrar();
        Console.WriteLine($"Numero de Ruedas : {aNroRuedas}");
    }

	public private int CalcularPeaje()
	{
		if (aNroRuedas > 4)

		{
			return 20;
		}
		else
		{
			return 10;
		}
	}



}
