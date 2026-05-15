namespace ejercicio2Bebidas;

public class Jugo : Bebida
{
    public string Fruta {get;set;}

    public Jugo(string bebida, string nombre, decimal precio, string fruta) : base (bebida, nombre, precio)
    {
        Fruta = fruta;
    }
    public override string Preparar()
    {
        return $"Preparar jugo de {Fruta}";
    }
}
