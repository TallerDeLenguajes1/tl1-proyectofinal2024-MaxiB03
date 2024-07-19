// See https://aka.ms/new-console-template for more information
using EspacioPersonaje;
using EspacioPersistencia;
using GeneracionDePersonajes;
using EspacioCombate;
using EspacioAscii;

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

/*Console.WriteLine("--- Personajes Disponibles ---");
int j=0;

foreach (var personaje in ListaDePersonajes)
{
    j += 1;
    Console.WriteLine($"======== PERSONAJE [{j}] ========");
    personaje.MostrarPersonaje();
    Console.WriteLine("-------------------------------");
}*/

Ascii ascii = new Ascii();

ascii.titulo();

Combate combate = new Combate();
combate.IniciarTorre(ListaDePersonajes);