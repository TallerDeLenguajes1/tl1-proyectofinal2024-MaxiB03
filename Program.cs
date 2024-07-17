// See https://aka.ms/new-console-template for more information
using EspacioPersonaje;
using EspacioPersistencia;
using GeneracionDePersonajes;

FabricaDePersonajes fabrica = new FabricaDePersonajes();
PersonajesJson personajesJson = new PersonajesJson();

string nombreArchivo="Personajes.json";
List<Personaje> ListaDePersonajes;

if(personajesJson.Existe(nombreArchivo))
{
    ListaDePersonajes = personajesJson.LeerPersonajes("Personajes.json");

}else
{
    ListaDePersonajes = new List<Personaje>();

    for (int i = 0; i < 10; i++)
    {
        Personaje personaje = fabrica.CrearPersonaje();
        ListaDePersonajes.Add(personaje);
    }

    personajesJson.GuardarPersonajes(ListaDePersonajes, nombreArchivo);
}

foreach (var personaje in ListaDePersonajes)
{
    personaje.MostrarPersonaje();
    Console.WriteLine("---------------------------");
}