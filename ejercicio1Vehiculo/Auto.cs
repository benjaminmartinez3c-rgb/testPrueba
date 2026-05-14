namespace ejercicio1Vehiculo;

public class Auto : Vehiculo
{
    public int CantPuertas { get; set; }
    public Auto(string marca, string modelo, int anio, int cantPuertas) : base(marca, modelo, anio)
    {
        CantPuertas = cantPuertas;
    }
    public override string Describir()
    {
        return base.Describir() + $"{CantPuertas} puertas";
    }
}
