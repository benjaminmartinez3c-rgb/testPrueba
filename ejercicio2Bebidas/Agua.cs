namespace ejercicio2Bebidas;

public class Agua : Bebida
{
    public bool EsConGas{get;set;}

    public Agua (string bebida, string nombre, decimal precio, bool esConGas) : base (bebida, nombre, precio)
    {
        EsConGas = esConGas;
    }
}
