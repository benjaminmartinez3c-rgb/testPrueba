
List<Bebida> bebidas = new List<Bebida>
{
new Cafe ("capuccino", 50, true),
new Agua ("agua", 25, false),
new Jugo ("Jugo de", 100, " naranja")
};

foreach (var beb in bebidas) {
    Console.WriteLine(beb.Preparar());
    Console.WriteLine(beb.MostrarPrecio());
}

try
{
    Cafe cafeMalo = new Cafe ("Cafe malo", -10, true);
} catch (ArgumentException e) {
    Console.WriteLine($"Error: {e.Message}");
}

