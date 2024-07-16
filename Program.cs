// See https://aka.ms/new-console-template for more information
using EspacioPersonaje;
using GeneracionDePersonajes;

Console.WriteLine("Hello, World!");

FabricaDePersonajes fabrica = new FabricaDePersonajes();

List<Personaje> ListaDePersonajes = new List<Personaje>();

for (int i = 0; i < 10; i++)
{
    Personaje personaje = fabrica.CrearPersonaje();
    ListaDePersonajes.Add(personaje);
}

foreach (var personaje in ListaDePersonajes)
{
    personaje.MostrarPersonaje();
    Console.WriteLine("--------------------");
}
