namespace ejercicio2Bebidas;

public class Cafe : Bebida
{
public bool TieneLeche {get;set;}

public Cafe(string bebida, string nombre, decimal precio, bool tieneLeche) : base (bebida, nombre, precio)
    {
        TieneLeche = tieneLeche;
    }

public override string Preparar()
    {
        if (tieneLeche) {
            return "Preparar café con leche";
        } else
        {
            return "Preparar café sin leche";
        }
        
    }
}
