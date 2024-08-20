public class cFecha
{
    // Atributos
    private int aD;
    private int aM;
    private int aA;

    // Métodos
    public cFecha()
    {
        // Constructor por defecto
        aD = 0;
        aM = 0;
        aA = 0;
    }

    // Constructor con *validación* de fecha
    public cFecha(int pD, int pM, int pA)
    {
        if (FechaValida(pD, pM, pA))
        {
            aD = pD;
            aM = pM;
            aA = pA;
        }
        else
        {
            aD = 1;
            aM = 1;
            aA = 0;
        }
    }

    public int D
    {
        get { return aD; }
        set
        {
            if (FechaValida(value, aM, aA))
                aX = value;
        }
    }

    public bool FechaValida(int pD, int pM, int pA)
    {
        int MaxDias = 0;

        if (pM == 1 || pM == 3 || pM == 5 || pM == 7 || pM == 8 || pM == 10 || pM == 12)
            MaxDias = 31;
        else if (pM == 4 || pM == 6 || pM == 9 || pM == 11)
            MaxDias = 30;
        else if (pM == 2)
        {
            if (pA % 4 == 0)
                MaxDias = 29;
            else
                MaxDias = 28;
        }
        else
            return false;

        return (pD >= 1 && pD <= MaxDias);
    }
}

