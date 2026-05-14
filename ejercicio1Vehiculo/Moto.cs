namespace ejercicio1Vehiculo;


public class Moto : Vehiculo
{
    public bool Sidecar { get; set; }
    public Moto(string marca, string modelo, int anio, bool sidecar) : base(marca, modelo, anio)
    {
        Sidecar = sidecar;
    }

    public override string Describir()
    {
        if (Sidecar)
        {
            return base.Describir() + "con sidecar";
        }
        else return base.Describir() + "sin sidecar";
        
    }
}
