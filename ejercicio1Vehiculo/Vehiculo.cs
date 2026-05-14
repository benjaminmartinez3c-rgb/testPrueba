namespace ejercicio1Vehiculo;

public class Vehiculo
{
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public int Anio { get; set; }
    public Vehiculo(string marca, string modelo, int anio)
    {
        Marca = marca;
        Modelo = modelo;
        if (anio < 1900)
        {
            throw new ArgumentException("no puede ser tan viejo");
        }
        else Anio = anio;
    }
    
    public virtual string Describir()
    {
        return $"{Marca} { Modelo} ({Anio})";
    }
       
}
